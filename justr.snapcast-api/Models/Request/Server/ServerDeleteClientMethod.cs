using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Server;

class ServerDeleteClientMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    public ServerDeleteClientMethod(string id)
    {
        Id = id;
    }

    public string GetName() => "Server.DeleteClient";
}