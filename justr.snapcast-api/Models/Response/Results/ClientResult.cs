using justr.SnapcastApi.Models.Response.Misc;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class ClientResult : IResult
{
    [JsonPropertyName("client")]
    public Client Client { get; set; }
}