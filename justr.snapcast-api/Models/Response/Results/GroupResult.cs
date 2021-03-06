using justr.SnapcastApi.Models.Misc;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class GroupResult : IResult
{
    [JsonPropertyName("group")]
    public Group Group { get; set; }
}