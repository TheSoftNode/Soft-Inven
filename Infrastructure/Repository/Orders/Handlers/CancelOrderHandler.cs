using Application.DTO.Response;
using Application.Extension;
using Application.Service.Orders.Commands;
using Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Orders.Handlers;

public class CancelOrderHandler(DataAccess.IDbContextFactory<AppDbContext> contextFactory) : IRequestHandler<CancelOrderCommand, ServiceResponse>
{
	public async Task<ServiceResponse> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
	{
		try
		{
			using var dbContext = contextFactory.CreateDbContext();
			var order = await dbContext.Orders.Where(_ => _.Id == request.OrderId).FirstOrDefaultAsync(cancellationToken: cancellationToken);
			if (order == null)
				return new ServiceResponse(false, "Order not found");

			order.OrderState = OrderState.Canceled;
			dbContext.Orders.Update(order);
			await dbContext.SaveChangesAsync(cancellationToken);
			return new ServiceResponse(true, "Order canceled successfully");
		}
		catch (Exception ex)
		{
			return new ServiceResponse(true, ex.Message);	
		}
	}
}
