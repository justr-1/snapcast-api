using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class Query
{
    [JsonPropertyName("chunk_ms")]
    public string ChunkMs { get; set; }

    [JsonPropertyName("codec")]
    public string Codec { get; set; }

    [JsonPropertyName("dryout_ms")]
    public string DryoutMs { get; set; }

    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("sampleformat")]
    public string Sampleformat { get; set; }
}



