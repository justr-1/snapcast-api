using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class StreamResult : IResult
{
    [JsonPropertyName("stream_id")]
    public string StreamId { get; set; }
}