using Application.DTO.Response.Products;
using MediatR;

namespace Application.Service.Products.Queries.Products;

public record GetProductByIdQuery(Guid Id) : IRequest<GetProductResponseDTO>;

