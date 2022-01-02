using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Client;

class ClientSetVolumeMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("volume")]
    public Volume Volume { get; set; }

    public ClientSetVolumeMethod(string id, bool muted)
    {
        Id = id;
        Volume = new Volume(muted);
    }

    public ClientSetVolumeMethod(string id, int percent)
    {
        Id = id;
        Volume = new Volume(percent);
    }

    public string GetName() => "Client.SetVolume";
}
class Volume
{
    [JsonPropertyName("muted")]
    public bool? Muted { get; set; }

    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    public Volume(bool muted) =>
        Muted = muted;

    public Volume(int percent) =>
        Percent = percent;

}
