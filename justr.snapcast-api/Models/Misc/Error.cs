using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Misc;

public class Error
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("data")]
    public string Data { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    public override string ToString() =>
        $"{Code} {Message}: {Data}";
}
