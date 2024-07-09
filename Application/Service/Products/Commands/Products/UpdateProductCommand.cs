using Application.DTO.Request.Products;
using Application.DTO.Response;
using MediatR;

namespace Application.Service.Products.Commands.Products;

public record UpdateProductCommand(UpdateProductRequestDTO ProductModel) : IRequest<ServiceResponse>;
