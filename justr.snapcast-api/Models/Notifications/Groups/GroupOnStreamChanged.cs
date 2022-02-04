using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Notifications.Groups;

public class GroupOnStreamChanged : IParams
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("stream_id")]
    public string StreamId { get; set; }
}

