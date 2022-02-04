using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifcations;

sealed class Notification
{

    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; }

    [JsonPropertyName("method")]
    public string Method { get; set; }  

    [JsonPropertyName("params")]
    public IParams Params { get; set; }

}
