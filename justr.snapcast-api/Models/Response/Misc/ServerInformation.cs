using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class ServerInformation
{
    [JsonPropertyName("host")]
    public Host Host { get; set; }

    [JsonPropertyName("snapserver")]
    public Snapserver Snapserver { get; set; }
}






