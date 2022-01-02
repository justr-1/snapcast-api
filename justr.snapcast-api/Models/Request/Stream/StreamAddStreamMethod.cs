using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Stream;

class StreamAddStreamMethod : IMethod
{
    [JsonPropertyName("streamUri")]
    public string StreamUri { get; set; }

    public StreamAddStreamMethod(string streamUri) =>
        StreamUri = streamUri;

    public string GetName() => "Stream.AddStream";
}