using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class Meta
{
    [JsonPropertyName("STREAM")]
    public string STREAM { get; set; }
}



