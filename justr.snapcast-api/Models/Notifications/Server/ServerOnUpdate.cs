using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;
using justr.SnapcastApi.Models.Misc;

namespace justr.SnapcastApi.Models.Notifications.Streams;

public class ServerOnUpdate : IParams
{
    [JsonPropertyName("stream")]
    public Stream Stream { get; set; }

}
