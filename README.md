

# .NET Snapcast API Wrapper

This is a .NET wrapper for the [Snapcast](https://github.com/badaix/snapcast) RPC API.

## Target Frameworks

 - netstandard2.0
 - net6.0

## Install

### NuGet
```
Install-Package justr.snapcast-api
```

## Usage

### Init

__Default__
```csharp
var api = new SnapcastApiClient("snapserver.lan", 1780);
```

__With logging__
```csharp
// init logging
var loggerFactory = LoggerFactory.Create(_ => _.AddDebug());
var logger = loggerFactory.CreateLogger<SnapcastApiClient>();

// init api client
var api = new SnapcastApiClient(new() { Host = "snapserver.lan", Port = 1780 }, logger);
```

__With di and logging__
```csharp
// init di
var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection);
var serviceProvider = serviceCollection.BuildServiceProvider();

// init api client
var api = serviceProvider.GetService<SnapcastApiClient>();

static void ConfigureServices(ServiceCollection services)
{
    services.AddLogging(_ => _.AddDebug());
    services.AddTransient<SnapcastApiClient>();
    services.AddSingleton(new Connection { Host = "snapserver.lan", Port = 1780 });
}
```
### Requests
__Server__
```csharp
api.ServerGetStatus();
api.ServerGetRPCVersion();
api.ServerDeleteClient(clientId);
```
__Client__
```csharp
api.ClientGetStatus(clientId);
api.ClientSetLatency(clientId, latency);
api.ClientSetName(clientId, name);
api.ClientSetMuted(clientId, muted);
api.ClientSetVolume(clientId, percent);
api.ClientChangeVolume(clientId, percentDiff);
```

__Group__
```csharp
api.GroupGetStatus(groupId);
api.GroupSetClients(groupId, clientId1, clientId2);
api.GroupSetClients(groupId, new List<string> { clientId1, clientId2 });
api.GroupSetName(groupId, name);
api.GroupSetMute(groupId, muted);
api.GroupSetStream(groupId, streamId);
```

__Stream__
```csharp
api.StreamAddStream(streamUri); // pipe:///tmp/snapfifo?name=stream1
api.StreamRemoveStream(streamId);
```

### Exceptions

 The `SnapcastApiException` will be thrown if anything goes wrong.
 
## Roadmap

 - [x] API access using http protocol 
 - [x] Support Snapcast 0.25 API requests and responses
 - [ ] Support notifications
 - [ ] Support new Snapcast 0.26 API features (metadata and control api for audio streams)  
 - [ ] (API access using tcp socket)

