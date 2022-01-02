using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class NameResult : IResult
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}