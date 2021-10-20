using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OBMCShopApp.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SaleType
    {
        Paid,
        Credit,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentType
    {
        Cash,
        Credit,
        Electronic,
        USSD,
        Cheque,
        Other
    }
}