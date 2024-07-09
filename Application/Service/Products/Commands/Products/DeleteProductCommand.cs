using Application.DTO.Response;
using MediatR;

namespace Application.Service.Products.Commands.Products;

public record DeleteProductCommand(Guid Id) : IRequest<ServiceResponse>;
