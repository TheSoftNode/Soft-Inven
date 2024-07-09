using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Products;

public class ProductBase
{
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; }
}
