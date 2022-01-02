using justr.SnapcastApi.Models.Request.Stream;
using justr.SnapcastApi.Models.Response.Results;
using System.Threading.Tasks;

namespace justr.SnapcastApi;
public partial class SnapcastApiClient
{
    public async Task<IdResponse> StreamAddStream(string streamUri) =>
        await Execute<IdResponse>(new StreamAddStreamMethod(streamUri));
    public async Task<IdResponse> StreamRemoveStream(string id) =>
        await Execute<IdResponse>(new StreamRemoveStreamMethod(id));

}
