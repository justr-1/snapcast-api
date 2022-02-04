using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Misc;

public class Client
{
    [JsonPropertyName("config")]
    public Config Config { get; set; }

    [JsonPropertyName("connected")]
    public bool Connected { get; set; }

    [JsonPropertyName("host")]
    public Host Host { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("lastSeen")]
    public LastSeen LastSeen { get; set; }

    [JsonPropertyName("snapclient")]
    public Snapclient Snapclient { get; set; }
}


