using justr.SnapcastApi;

var api = new SnapcastApiClient("snapserver.lan");
var status = await api.ServerGetStatus();
