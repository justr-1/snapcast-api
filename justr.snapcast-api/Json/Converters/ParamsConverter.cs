using justr.SnapcastApi.Models.Request;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace justr.SnapcastApi.Json.Converters;

class ParamsConverter : JsonConverter<IMethod>
{
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(IMethod);

    public override IMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        throw new NotImplementedException();

    public override void Write(Utf8JsonWriter writer, IMethod value, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(writer, value, value.GetType(), options);

}

