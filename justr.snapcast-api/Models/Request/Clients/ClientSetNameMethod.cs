using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Clients;

class ClientSetNameMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    public ClientSetNameMethod(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public string GetName() => "Client.SetName";
}

