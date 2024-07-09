using Application.DTO.Response;
using Application.Service.Products.Commands.Categories;
using Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Products.Handlers.Categories;

public class DeleteCategoryHandler(DataAccess.IDbContextFactory<AppDbContext> contextFactory) : IRequestHandler<DeleteCategoryCommand, ServiceResponse>
{
	public async Task<ServiceResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
	{
		try
		{
			using var dbContext = contextFactory.CreateDbContext();
			var data = await dbContext.Categories.FirstOrDefaultAsync(_ => _.Id.Equals(request.Id), cancellationToken: cancellationToken);
			if (data == null)
				return GeneralDbResponses.ItemNotFound("Category");

			dbContext.Categories.Remove(data);
			await dbContext.SaveChangesAsync(cancellationToken);
			return GeneralDbResponses.ItemDelete(data.Name);
		}
		catch (Exception ex)
		{
			return new ServiceResponse(true, ex.Message);
		}

	}
}
