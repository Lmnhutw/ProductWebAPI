using System.Text.Json;
using System.Text.Json.Serialization;

namespace firstProject.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Makers { get; set; }

        public string Name { get; set; }
        public string Url { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int[] Ratetings { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}
