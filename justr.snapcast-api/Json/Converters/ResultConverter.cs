using justr.SnapcastApi.Models.Response;
using justr.SnapcastApi.Models.Response.Results;
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Json.Converters;

class ResultConverter : JsonConverter<IResult>
{
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(IResult);

    public override IResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        return getFirstPropertyName() switch
        {
            "server" => deserialize<ServerResult>(),
            "client" => deserialize<ClientResult>(),
            "major" => deserialize<RpcVersionResult>(),
            "volume" => deserialize<VolumeResult>(),
            "latency" => deserialize<LatencyResult>(),
            "name" => deserialize<NameResult>(),
            "stream_id" => deserialize<StreamResult>(),
            "group" => deserialize<GroupResult>(),
            "mute" => deserialize<MuteResult>(),
            "id" => deserialize<IdResponse>(),
            _ => throw new NotImplementedException(),
        };

        string getFirstPropertyName() =>
            doc.RootElement.EnumerateObject().First().Name;

        IResult deserialize<TResult>() where TResult : IResult =>
            JsonSerializer.Deserialize<TResult>(doc)!;
    }

    public override void Write(Utf8JsonWriter writer, IResult value, JsonSerializerOptions options)
    {
    }

}
