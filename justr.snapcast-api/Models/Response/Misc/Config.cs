using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class Config
{
    [JsonPropertyName("instance")]
    public int Instance { get; set; }

    [JsonPropertyName("latency")]
    public int Latency { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("volume")]
    public Volume Volume { get; set; }
}


