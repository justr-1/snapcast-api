using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifications.Clients;

public class ClientOnNameChanged : IParams
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

