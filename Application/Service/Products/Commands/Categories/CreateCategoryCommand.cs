using Application.DTO.Request.Products;
using Application.DTO.Response;
using MediatR;

namespace Application.Service.Products.Commands.Categories;

public record CreateCategoryCommand(AddCatgoryRequestDTO CategoryModel) : IRequest<ServiceResponse>;

