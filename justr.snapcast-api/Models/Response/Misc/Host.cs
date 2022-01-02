using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class Host
{
    [JsonPropertyName("arch")]
    public string Arch { get; set; }

    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    [JsonPropertyName("mac")]
    public string Mac { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("os")]
    public string Os { get; set; }
}


