using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class MuteResult : IResult
{
    [JsonPropertyName("mute")]
    public bool Mute { get; set; }
}