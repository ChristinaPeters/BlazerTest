using static BlazerTest.Pages.Bewaartermijnen;
using System.Text.Json.Serialization;

namespace BlazerTest.Models
{
    public class Error
    {
        [JsonPropertyName("error")]
        public ErrorDetail detail { get; set; }
        public int statuscode { get; set; }
        public string reason { get; set; }

    }
}
