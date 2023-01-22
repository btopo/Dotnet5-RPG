using System.Text.Json.Serialization;

namespace Dotnet5_RPG.Controllers.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}