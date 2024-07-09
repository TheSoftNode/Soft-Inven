using System.Text.Json.Serialization;

namespace Domain.Entities.Products;

public class Category : ProductBase
{
	[JsonIgnore]
	public virtual ICollection<Product> Products { get; set; } = null;
}
