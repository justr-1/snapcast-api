using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Streams;

class StreamAddStreamMethod : IMethod
{
    [JsonPropertyName("streamUri")]
    public string StreamUri { get; set; }

    public StreamAddStreamMethod(string streamUri) =>
        StreamUri = streamUri;

    public string GetName() => "Stream.AddStream";
}