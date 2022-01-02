using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Client;

class ClientGetStatusMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    public ClientGetStatusMethod(string id) =>
        Id = id;

    public string GetName() => "Client.GetStatus";

}
