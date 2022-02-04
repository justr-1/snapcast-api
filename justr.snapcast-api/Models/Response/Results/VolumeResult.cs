using justr.SnapcastApi.Models.Misc;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class VolumeResult : IResult
{
    [JsonPropertyName("volume")]
    public Volume Volume { get; set; }
}