namespace eShop.Product.RestService.Converters
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    internal class ClassConverter<M, I> : JsonConverter<I> where M : class, I
    {
        public override I Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<M>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, I value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
