using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request.Products;

public class AddCatgoryRequestDTO
{
	[Required]
	public string Name { get; set; }
}
