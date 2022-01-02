using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Group;

class GroupGetStatusMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    public GroupGetStatusMethod(string id) =>
        Id = id;

    public string GetName() => "Group.GetStatus";
}
