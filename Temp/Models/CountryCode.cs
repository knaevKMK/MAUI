using System.Text.Json.Serialization;

namespace Temp.Models
{
    public class CountryCode
    {
        [JsonPropertyName("flag")]
        public string IconUrl { get; set; }

        [JsonPropertyName("dialCode")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Country { get; set; }
    }
}
