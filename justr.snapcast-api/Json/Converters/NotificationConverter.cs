using justr.SnapcastApi.Models.Notifcations;
using justr.SnapcastApi.Models.Notifications.Clients;
using justr.SnapcastApi.Models.Notifications.Groups;
using justr.SnapcastApi.Models.Notifications.Streams;
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Json.Converters;

class NotificationConverter : JsonConverter<Notification>
{
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(Notification);

    public override Notification Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);

        return new Notification
        {
            JsonRpc = doc.RootElement.GetProperty("jsonrpc").GetString(),
            Method = doc.RootElement.GetProperty("method").GetString(),
            Params = getNotificationType() switch
            {
                "Client.OnConnect" => deserialize<ClientOnConnect>(),
                "Client.OnDisconnect" => deserialize<ClientOnDisconnect>(),
                "Client.OnVolumeChanged" => deserialize<ClientOnVolumeChanged>(),
                "Client.OnLatencyChanged" => deserialize<ClientOnLatencyChanged>(),
                "Client.OnNameChanged" => deserialize<ClientOnNameChanged>(),
                "Group.OnMute" => deserialize<GroupOnMute>(),
                "Group.OnStreamChanged" => deserialize<GroupOnStreamChanged>(),
                "Group.OnNameChanged" => deserialize<GroupOnNameChanged>(),
                "Stream.OnUpdate" => deserialize<StreamOnUpdate>(),
                "Server.OnUpdate" => deserialize<ServerOnUpdate>(),
                _ => throw new NotSupportedException("Unknown notification type")
            }
        };

        string getNotificationType() =>
            doc.RootElement.EnumerateObject().ElementAtOrDefault(1).Value.ToString();

        TNotification deserialize<TNotification>() where TNotification : IParams =>
            JsonSerializer.Deserialize<TNotification>(doc.RootElement.GetProperty("params"));
    }

    public override void Write(Utf8JsonWriter writer, Notification value, JsonSerializerOptions options) { }

}

