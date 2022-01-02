using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Response.Misc;

public class Server
{
    [JsonPropertyName("groups")]
    public IList<Group> Groups { get; set; } = new List<Group>();

    [JsonPropertyName("server")]
    public ServerInformation ServerInformation { get; set; }

    [JsonPropertyName("streams")]
    public IList<Stream> Streams { get; set; } = new List<Stream>();
}






