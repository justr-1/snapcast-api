using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using justr.SnapcastApi.Exceptions;
using justr.SnapcastApi.Models.Request;
using justr.SnapcastApi.Models.Response;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static justr.SnapcastApi.Json.Serializer;

namespace justr.SnapcastApi;

public partial class SnapcastApiClient
{
    private readonly string _host;
    private readonly int _port;
    private readonly ILogger<SnapcastApiClient> _logger;

    public SnapcastApiClient(string host, int port = 1780) : this(new() { Host = host, Port = port }, null) { }

    public SnapcastApiClient(Connection connection, ILogger<SnapcastApiClient> logger = null)
    {
        _host = connection.Host;
        _port = connection.Port;
        _logger = logger ?? NullLogger<SnapcastApiClient>.Instance;
    }

    private async Task<TResult> Execute<TResult>(IMethod method) where TResult : IResult
    {
        var request = RpcRequest.For(method);
        var client = new HttpClient();

        var url = $"http://{_host}:{_port}/jsonrpc";
        var requestBody = Serialize(request);

        _logger.LogInformation($"request url: {url} content: {requestBody}");
        var responseMessage = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));

        var responseBody = await responseMessage.Content.ReadAsStringAsync();
        _logger.LogInformation($"response status code: {responseMessage.StatusCode} content: {responseBody}");

        responseMessage.EnsureSuccessStatusCode();

        var response = Deserialize(responseBody);
        AssertValidResult(request, response);
        return (TResult)response.Result!;
    }

    private static void AssertValidResult(RpcRequest request, RpcResponse result)
    {
        if (request.Id != result.Id)
            throw new SnapcastApiException($"id mismatch {request.Id} <-> {result.Id}");

        if (!string.Equals(request.JsonRpc, result.JsonRpc))
            throw new SnapcastApiException($"rpc version mismatch {request.JsonRpc} <-> {result.JsonRpc}");

        if (result.Error != null)
            throw new SnapcastApiException($"{result.Error}");
    }

}
