using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Misc;

public class Volume
{
    [JsonPropertyName("muted")]
    public bool Muted { get; set; }

    [JsonPropertyName("percent")]
    public int Percent { get; set; }
}


