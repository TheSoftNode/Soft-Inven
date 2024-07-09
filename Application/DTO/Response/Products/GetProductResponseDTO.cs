namespace Application.DTO.Response.Products;

public class GetProductResponseDTO : ProductBaseDTO
{
	public Guid Id { get; set; }

	public GetCategoryResponseDTO Category { get; set; }

	public GetLocationResponseDTO Location { get; set; }

	public DateTime DateAdded { get; set; } = DateTime.Now;
}
