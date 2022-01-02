using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Group;

class GroupSetMuteMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }


    [JsonPropertyName("mute")]
    public bool Mute { get; set; }
    public GroupSetMuteMethod(string id, bool mute)
    {
        Id = id;
        Mute = mute;
    }
    public string GetName() => "Group.SetMute";
}
