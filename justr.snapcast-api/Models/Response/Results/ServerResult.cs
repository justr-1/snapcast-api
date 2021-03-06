using justr.SnapcastApi.Models.Misc;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;

public class ServerResult : IResult
{
    [JsonPropertyName("server")]
    public Server Server { get; set; }
}
