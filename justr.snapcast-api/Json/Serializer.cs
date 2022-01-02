using justr.SnapcastApi.Json.Converters;
using justr.SnapcastApi.Models.Request;
using justr.SnapcastApi.Models.Response;
using System.Text.Json;

namespace justr.SnapcastApi.Json;
static class Serializer
{
    public static string Serialize(RpcRequest request)
       => JsonSerializer.Serialize(request, GetOptions());

    public static RpcResponse Deserialize(string response)
        => JsonSerializer.Deserialize<RpcResponse>(response, GetOptions())!;

    private static JsonSerializerOptions GetOptions() =>
         new()
         {
             WriteIndented = true,
             Converters =
                {
                    new ResultConverter(),
                    new ParamsConverter()
                }
         };
}
