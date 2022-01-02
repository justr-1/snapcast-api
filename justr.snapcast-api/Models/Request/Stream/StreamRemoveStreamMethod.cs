﻿using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Models.Request.Stream;

class StreamRemoveStreamMethod : IMethod
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    public StreamRemoveStreamMethod(string id) =>
        Id = id;

    public string GetName() => "Stream.RemoveStream";
}