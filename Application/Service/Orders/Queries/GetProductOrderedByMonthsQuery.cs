using Application.DTO.Response.Orders;
using MediatR;

namespace Application.Service.Orders.Queries;

public record GetProductOrderedByMonthsQuery(string UserId = null) : IRequest<IEnumerable<GetProductOrderedByMonthsResponseDTO>>;
