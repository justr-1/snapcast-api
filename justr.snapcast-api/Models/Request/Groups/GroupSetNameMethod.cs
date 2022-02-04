using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Groups;

class GroupSetNameMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    public GroupSetNameMethod(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public string GetName() => "Group.SetName";
}
