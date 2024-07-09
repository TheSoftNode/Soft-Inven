using Application.DTO.Response;
using MediatR;

namespace Application.Service.Orders.Commands;

public record CancelOrderCommand(Guid OrderId) : IRequest<ServiceResponse>;
