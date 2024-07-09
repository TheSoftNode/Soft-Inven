using NetcodeHub.Packages.Extensions.Attributes.RequiredGuid;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request.Orders;

public class OrderBaseDTO
{
	[NetcodeHubRequiredGuid(ErrorMessage = "Product must be selected")]
	public Guid ProductId { get; set; }

	[Required]
	[Range(1, int.MaxValue)]
	public int Quantity { get; set; }
}
