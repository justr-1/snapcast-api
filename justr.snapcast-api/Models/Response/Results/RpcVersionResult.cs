using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Results;
public class RpcVersionResult : IResult
{
    [JsonPropertyName("major")]
    public int Major { get; set; }

    [JsonPropertyName("minor")]
    public int Minor { get; set; }

    [JsonPropertyName("patch")]
    public int Patch { get; set; }
}

