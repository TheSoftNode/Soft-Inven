using Application.DTO.Response.Products;
using MediatR;

namespace Application.Service.Products.Queries.Categories;

public class GetAllCategoriesQuery : IRequest<IEnumerable<GetCategoryResponseDTO>> { }
