using System.Text.Json.Serialization;

namespace Otus.HomerWork.DapperProject.DAL.Model
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("stock_quantity")]
        public int StockQuantity { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }
    }
}
