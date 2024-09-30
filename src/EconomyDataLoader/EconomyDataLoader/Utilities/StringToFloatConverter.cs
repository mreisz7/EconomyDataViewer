using System.Text.Json;
using System.Text.Json.Serialization;

namespace EconomyDataLoader.Utilities;

public class StringToFloatConverter : JsonConverter<float>
{
    public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String && float.TryParse(reader.GetString(), out float result))
        {
            return result;
        }

        return 0; // Default value if the conversion fails
    }

    public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}
