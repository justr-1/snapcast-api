using System;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request;

sealed class RpcRequest
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; } = "2.0";

    [JsonPropertyName("id")]
    public int Id { get; } = new Random().Next();

    [JsonPropertyName("method")]
    public string Method { get; set; }

    [JsonPropertyName("params")]
    public IMethod Params { get; set; }

    public static RpcRequest For(IMethod method) =>
        new()
        {
            Params = method,
            Method = method.GetName()
        };
}