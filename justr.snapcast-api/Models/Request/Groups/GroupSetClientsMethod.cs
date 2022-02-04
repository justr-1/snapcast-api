using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Groups;

class GroupSetClientsMethod : IMethod
{
    [JsonPropertyName("clients")]
    public List<string> Clients { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
    public GroupSetClientsMethod(string id, List<string> clients)
    {
        Id = id;
        Clients = clients;
    }
    public string GetName() => "Group.SetClients";
}
