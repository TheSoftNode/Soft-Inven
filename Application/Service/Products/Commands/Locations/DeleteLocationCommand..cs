using Application.DTO.Response;
using MediatR;

namespace Application.Service.Products.Commands.Locations;

public record DeleteLocationCommand(Guid Id) : IRequest<ServiceResponse>;
