using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class LatencyResult : IResult
{
    [JsonPropertyName("latency")]
    public int Latency { get; set; }
}