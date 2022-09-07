using System.ComponentModel.DataAnnotations;

namespace GeekShopping.Web.Models
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        [Range(1, 100)]
        public int Count { get; set; } = 1;

        public string SubstringName()
        {
            return SubstringText(Name, 24);
        }

        public string SubstringDescription()
        {
            return SubstringText(Description, 355);
        }

        private string SubstringText(string property, int substringLength)
        {
            if (property.Length < substringLength)
            {
                return property;
            }

            return $"{property.Substring(0, substringLength - 3)}...";
        }
    }
}
