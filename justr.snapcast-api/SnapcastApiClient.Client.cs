using justr.SnapcastApi.Exceptions;
using justr.SnapcastApi.Models.Request.Client;
using justr.SnapcastApi.Models.Response.Results;
using System;
using System.Threading.Tasks;

namespace justr.SnapcastApi;
public partial class SnapcastApiClient
{
    public async Task<ClientResult> ClientGetStatus(string id) =>
        await Execute<ClientResult>(new ClientGetStatusMethod(id));

    public async Task<VolumeResult> ClientSetMuted(string id, bool muted) =>
        await Execute<VolumeResult>(new ClientSetVolumeMethod(id, muted));

    public async Task<VolumeResult> ClientSetVolume(string id, int percent)
    {

#if NETCOREAPP2_0_OR_GREATER
        percent = Math.Clamp(percent, 0, 100);
#else
        percent = Math.Min(100, Math.Max(0, percent));
#endif

        return await Execute<VolumeResult>(new ClientSetVolumeMethod(id, percent));
    }

    public async Task<VolumeResult> ClientChangeVolume(string id, int percentDiff)
    {
        var status = await ClientGetStatus(id);
        if (status?.Client.Config?.Volume == null)
            throw new SnapcastApiException($"{id}: cannot get current volume");
        var percent = status.Client.Config.Volume.Percent + percentDiff;
        return await ClientSetVolume(id, percent);
    }

    public async Task<LatencyResult> ClientSetLatency(string id, int latency) =>
        await Execute<LatencyResult>(new ClientSetLatencyMethod(id, latency));

    public async Task<NameResult> ClientSetName(string id, string name) =>
        await Execute<NameResult>(new ClientSetNameMethod(id, name));
}
