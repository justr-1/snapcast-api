using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using static justr.SnapcastApi.Json.Serializer;
using justr.SnapcastApi.Models.Notifcations;

namespace justr.SnapcastApi;
public partial class SnapcastApiClient
{
    public event EventHandler<IParams> OnNotification; // event
    public async Task StartNotificationListener()
    {
        try
        {
            var ws = new ClientWebSocket();
            var cts = new CancellationTokenSource();
            await ws.ConnectAsync(new Uri($"ws://{_host}:{_port}/jsonrpc"), cts.Token);
            _logger.LogInformation($"Websocket connection: {ws.State}");

            while (ws.State == WebSocketState.Open)
            {
                using var ms = new MemoryStream();
                WebSocketReceiveResult result;
                do
                {
                    var messageBuffer = WebSocket.CreateClientBuffer(1024, 16);
                    result = await ws.ReceiveAsync(messageBuffer, CancellationToken.None);
                    ms.Write(messageBuffer.Array, messageBuffer.Offset, result.Count);
                }
                while (!result.EndOfMessage);

                if (result.MessageType == WebSocketMessageType.Text)
                {
                    var content = Encoding.UTF8.GetString(ms.ToArray());
                    _logger.LogDebug($"ws content: {content}");

                    var response = Deserialize<Notification>(content).Params;
                    OnNotification?.Invoke(this, response);
                }
            }

        }
        catch (Exception e)
        {
            _logger.LogError($"Websocket error: {e}");
            Thread.Sleep(1000);
            await StartNotificationListener();
        }

    }
}
