using justr.SnapcastApi.Models.Notifcations;
using System.Text.Json.Serialization;
using justr.SnapcastApi.Models.Misc;

namespace justr.SnapcastApi.Models.Notifications.Streams;

public class OnError : IParams
{
    public Error Error { get; set; }

}
