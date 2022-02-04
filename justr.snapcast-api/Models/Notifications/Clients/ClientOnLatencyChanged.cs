using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifications.Clients;

public class ClientOnLatencyChanged : IParams
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("latency")]
    public int Latency { get; set; }
}

