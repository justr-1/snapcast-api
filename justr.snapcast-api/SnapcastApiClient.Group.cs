using justr.SnapcastApi.Models.Request.Group;
using justr.SnapcastApi.Models.Response.Results;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justr.SnapcastApi;
public partial class SnapcastApiClient
{
    public async Task<GroupResult> GroupGetStatus(string id) =>
        await Execute<GroupResult>(new GroupGetStatusMethod(id));

    public async Task<StreamResult> GroupSetStream(string id, string streamId) =>
        await Execute<StreamResult>(new GroupSetStreamMethod(id, streamId));
    public async Task<MuteResult> GroupSetMute(string id, bool mute) =>
        await Execute<MuteResult>(new GroupSetMuteMethod(id, mute));

    public async Task<NameResult> GroupSetName(string id, string name) =>
        await Execute<NameResult>(new GroupSetNameMethod(id, name));

    public async Task<ServerResult> GroupSetClients(string id, params string[] clients) =>
        await GroupSetClients(id, clients.ToList());

    public async Task<ServerResult> GroupSetClients(string id, List<string> clients) =>
        await Execute<ServerResult>(new GroupSetClientsMethod(id, clients));
}
