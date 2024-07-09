using Application.DTO.Response;
using Application.Service.Products.Commands.Products;
using Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Products.Handlers.Products;

public class DeleteProductHandler(DataAccess.IDbContextFactory<AppDbContext> contextFactory) : IRequestHandler<DeleteProductCommand, ServiceResponse>
{
	public async Task<ServiceResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
	{
		try
		{
			using var dbContext = contextFactory.CreateDbContext();
			var data = await dbContext.Products.FirstOrDefaultAsync(_ => _.Id.Equals(request.Id), cancellationToken: cancellationToken);
			if (data == null)
				return GeneralDbResponses.ItemNotFound("Products");

			dbContext.Products.Remove(data);
			await dbContext.SaveChangesAsync(cancellationToken);
			return GeneralDbResponses.ItemDelete(data.Name);
		}
		catch (Exception ex)
		{
			return new ServiceResponse(true, ex.Message);
		}

	}
}
