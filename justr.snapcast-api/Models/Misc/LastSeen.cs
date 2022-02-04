using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Misc;

public class LastSeen
{
    [JsonPropertyName("sec")]
    public int Sec { get; set; }

    [JsonPropertyName("usec")]
    public int Usec { get; set; }
}


