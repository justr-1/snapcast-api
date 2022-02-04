using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;
using justr.SnapcastApi.Models.Misc;

namespace justr.SnapcastApi.Models.Notifications.Streams;

public class StreamOnUpdate : IParams
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("stream")]
    public Stream Stream { get; set; }

}
