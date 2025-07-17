using DAL.Services.DI;
using BL.Services.DI;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Api.Helpers;

namespace WebApplication1
{
	public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllers(options =>
			{
				options.Conventions.Add(new RouteTokenTransformerConvention(new KebabCaseControllerNameConvention()));
			});

			builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.UseDAL(builder.Configuration);
            builder.Services.UseBL();

            var app = builder.Build();

			app.UseSwagger();
			app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nutrition v1"));

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
