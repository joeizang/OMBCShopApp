using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OBMCShopApp.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnitMeasure
    {
        KG,
        CARTON,
        PACKS,
        CRATE,
        DOZEN,
        HALF_DOZEN,
        PIECES,
        SET,
        ROLLS,
        BOTTLE,
        BUNDLE
    }
}