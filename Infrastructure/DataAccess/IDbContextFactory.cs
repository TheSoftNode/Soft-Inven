namespace Infrastructure.DataAccess;

public interface IDbContextFactory<T> where T : class
{
	T CreateDbContext();
}
