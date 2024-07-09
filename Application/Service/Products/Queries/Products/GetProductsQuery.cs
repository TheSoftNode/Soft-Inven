using Application.DTO.Response.Products;
using MediatR;

namespace Application.Service.Products.Queries.Products;

public class GetProductsQuery : IRequest<IEnumerable<GetProductResponseDTO>> { }

