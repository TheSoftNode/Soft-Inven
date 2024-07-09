using Application.DTO.Request.Products;
using System.Text.Json.Serialization;

namespace Application.DTO.Response.Products;

public class GetLocationResponseDTO : UpdateLocationRequestDTO
{
	[JsonIgnore]
	public virtual ICollection<GetProductResponseDTO> Products { get; set; } = null;
}
