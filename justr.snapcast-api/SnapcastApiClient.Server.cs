using justr.SnapcastApi.Models.Request.Server;
using justr.SnapcastApi.Models.Response.Results;
using System.Threading.Tasks;

namespace justr.SnapcastApi;
public partial class SnapcastApiClient
{
    public async Task<ServerResult> ServerGetStatus() =>
        await Execute<ServerResult>(new ServerGetStatusMethod());

    public async Task<RpcVersionResult> ServerGetRPCVersion() =>
        await Execute<RpcVersionResult>(new ServerGetRPCVersionMethod());

    public async Task<ServerResult> ServerDeleteClient(string id) =>
        await Execute<ServerResult>(new ServerDeleteClientMethod(id));
}
