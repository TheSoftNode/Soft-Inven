using Application.DTO.Request.Orders;
using Application.DTO.Response;
using MediatR;

namespace Application.Service.Orders.Commands;

 public record CreateOrderCommand(CreateOrderRequestDTO Model) : IRequest<ServiceResponse>;

