using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class Uri
{
    [JsonPropertyName("fragment")]
    public string Fragment { get; set; }

    [JsonPropertyName("host")]
    public string Host { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("query")]
    public Query Query { get; set; }

    [JsonPropertyName("raw")]
    public string Raw { get; set; }

    [JsonPropertyName("scheme")]
    public string Scheme { get; set; }
}



