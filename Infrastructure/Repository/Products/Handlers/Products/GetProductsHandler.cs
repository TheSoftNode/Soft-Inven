using Application.DTO.Response.Products;
using Application.Service.Products.Queries.Products;
using Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Products.Handlers.Products;

public class GetProductsHandler(DataAccess.IDbContextFactory<AppDbContext> contextFactory) : IRequestHandler<GetProductsQuery, IEnumerable<GetProductResponseDTO>>
{
	public async Task<IEnumerable<GetProductResponseDTO>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
	{
		using var context = contextFactory.CreateDbContext();
		var products = await context.Products.AsNoTracking().Include(c => c.Category).Include(l => l.Location).ToListAsync(cancellationToken: cancellationToken);
		return products.Select(product => new GetProductResponseDTO
		{
			Id = product.Id,
			Name = product.Name,
			Description = product.Description,
			Base64Image = product.Base64Image,
			CategoryId = product.CategoryId,
			LocationId = product.LocationId,
			Price = product.Price,
			DateAdded = product.DateAdded,
			Quantity = product.Quantity,
			SerialNumber = product.SerialNumber,
			Location = new GetLocationResponseDTO
			{
				Id = product.LocationId,
				Name = product.Location.Name,
			},
			Category = new GetCategoryResponseDTO
			{
				Id = product.CategoryId,
				Name = product.Category.Name,
			}
		}).ToList();
	}
}
