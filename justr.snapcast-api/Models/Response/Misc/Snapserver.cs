using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class Snapserver
{
    [JsonPropertyName("controlProtocolVersion")]
    public int ControlProtocolVersion { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("protocolVersion")]
    public int ProtocolVersion { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }
}


