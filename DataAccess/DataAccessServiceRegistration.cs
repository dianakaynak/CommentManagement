using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
	public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<CommentManagementContext>(options => options.UseSqlServer(configuration.GetConnectionString("CommentManagement")));


		services.AddScoped<IAccountDal, EfAccountDal>();
		services.AddScoped<IUserDal, EfUserDal>();
		services.AddScoped<IUserOperationClaimDal, EfUserOperationClaimDal>();
		services.AddScoped<IOperationClaimDal, EfOperationClaimDal>();
		services.AddScoped<IAssignmentDal, EfAssignmentDal>();
		services.AddScoped<ICommentDal,EfCommentDal>();

		return services;
	}
}