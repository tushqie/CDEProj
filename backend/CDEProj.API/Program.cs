using Microsoft.EntityFrameworkCore;
using CDEProj.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();

// Configure SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection")
                )
                );

                // Add OpenAPI
                builder.Services.AddOpenApi();

                var app = builder.Build();

                // Configure HTTP pipeline
                if (app.Environment.IsDevelopment())
                {
                    app.MapOpenApi();
                    }

                    app.UseHttpsRedirection();

                    app.UseAuthorization();

                    app.MapControllers();

                    app.Run();