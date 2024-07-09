using Application.DTO.Response.Products;

namespace Application.DTO.Request.Products;

public class UpdateProductRequestDTO : ProductBaseDTO
{
	public Guid Id { get; set; }
}
