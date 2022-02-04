using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifications.Groups;

public class GroupOnMute : IParams
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("mute")]
    public bool Mute { get; set; }
}

