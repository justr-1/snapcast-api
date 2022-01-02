using justr.SnapcastApi.Models.Response.Misc;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response;
sealed class RpcResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; }

    [JsonPropertyName("result")]
    public IResult Result { get; set; }

    [JsonPropertyName("error")]
    public Error Error { get; set; }

}
