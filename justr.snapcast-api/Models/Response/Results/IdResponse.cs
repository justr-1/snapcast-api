using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class IdResponse : IResult
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
}