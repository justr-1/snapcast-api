using justr.SnapcastApi.Models.Notifcations;
using justr.SnapcastApi.Models.Misc;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifications.Clients;

public class ClientOnVolumeChanged : IParams
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("volume")]
    public Volume Volume { get; set; }
}

