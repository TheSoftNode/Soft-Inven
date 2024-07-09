using Application.DTO.Response;
using MediatR;

namespace Application.Service.Products.Commands.Categories;

public record DeleteCategoryCommand(Guid Id) : IRequest<ServiceResponse>;
