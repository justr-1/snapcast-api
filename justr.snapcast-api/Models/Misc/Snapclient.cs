using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Misc;

public class Snapclient
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("protocolVersion")]
    public int ProtocolVersion { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }
}


