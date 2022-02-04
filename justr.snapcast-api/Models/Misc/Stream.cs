using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Misc;

public class Stream
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("uri")]
    public Uri Uri { get; set; }
}