using System.Text.Json.Serialization;

namespace Otus.HomerWork.DapperProject.DAL.Model
{
    public class Customer
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}
