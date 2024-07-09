using Application.DTO.Response.Products;
using MediatR;

namespace Application.Service.Products.Queries.Categories;

public class GetCategoriesWithProductsQuery : IRequest<IEnumerable<GetCategoryResponseDTO>> { }
