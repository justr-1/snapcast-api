using justr.SnapcastApi.Models.Notifcations;
using justr.SnapcastApi.Models.Misc;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifications.Clients;

public class ClientOnConnect : IParams
{
    [JsonPropertyName("client")]
    public Client Client { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

