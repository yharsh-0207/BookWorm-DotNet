using BookWorm_DotNet.DAL;
using BookWorm_DotNet.Controllers;
using BookWorm_DotNet.Data;
using Microsoft.EntityFrameworkCore;


namespace BookWorm_DotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddControllers();


            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IMyShelfRepository, MyShelfRepository>();
            builder.Services.AddScoped<IRoyaltyCalculationRepository, RoyaltyCalculationRepository>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddDbContext<BookwormContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
