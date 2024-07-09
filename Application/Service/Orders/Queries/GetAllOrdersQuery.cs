using Application.DTO.Response.Orders;
using MediatR;

namespace Application.Service.Orders.Queries;

public record GetAllOrdersQuery : IRequest<IEnumerable<GetOrderResponseDTO>>;
