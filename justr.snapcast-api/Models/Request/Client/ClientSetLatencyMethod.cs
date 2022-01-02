using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Client;

class ClientSetLatencyMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("latency")]
    public int Latency { get; set; }

    public ClientSetLatencyMethod(string id, int latency)
    {
        Id = id;
        Latency = latency;
    }
    public string GetName() => "Client.SetLatency"; 
}