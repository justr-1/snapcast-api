using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifications.Groups;

public class GroupOnNameChanged : IParams
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

