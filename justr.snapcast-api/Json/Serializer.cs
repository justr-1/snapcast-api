using justr.SnapcastApi.Json.Converters;
using justr.SnapcastApi.Models.Request;
using System.Text.Json;

namespace justr.SnapcastApi.Json;
static class Serializer
{
    public static string Serialize(RpcRequest request)
       => JsonSerializer.Serialize(request, GetOptions());

    public static T Deserialize<T>(string response)
        => JsonSerializer.Deserialize<T>(response, GetOptions())!;

    private static JsonSerializerOptions GetOptions() =>
         new()
         {
             WriteIndented = true,
             Converters =
                {
                    new ResultConverter(),
                    new ParamsConverter(),
                    new NotificationConverter()
                }
         };
}
