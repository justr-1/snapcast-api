using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;
public class Group
{
    [JsonPropertyName("clients")]
    public IList<Client> Clients { get; set; } = new List<Client>();

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("muted")]
    public bool Muted { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("stream_id")]
    public string StreamId { get; set; }
}


