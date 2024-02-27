using BookWorm_DotNet.Dal;
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
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddDbContext<BookwormContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddCors(
            (p) => p.AddDefaultPolicy(policy => policy.WithOrigins("*")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    )
            );
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }




            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();
            app.MapControllers();

            app.Run();
        }
    }
}
