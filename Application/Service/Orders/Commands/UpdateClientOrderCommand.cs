using Application.DTO.Request.Orders;
using Application.DTO.Response;
using MediatR;

namespace Application.Service.Orders.Commands;

public record UpdateClientOrderCommand(UpdateClientOrderRequestDTO Model) : IRequest<ServiceResponse>;
