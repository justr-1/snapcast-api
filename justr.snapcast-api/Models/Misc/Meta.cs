using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Misc;

public class Meta
{
    [JsonPropertyName("STREAM")]
    public string STREAM { get; set; }
}



