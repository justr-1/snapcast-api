using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Groups;

class GroupSetStreamMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }


    [JsonPropertyName("stream_id")]
    public string StreamId { get; set; }
    public GroupSetStreamMethod(string id, string streamId)
    {
        Id = id;
        StreamId = streamId;
    }
    public string GetName() => "Group.SetStream";
}
