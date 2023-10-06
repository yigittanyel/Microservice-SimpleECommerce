using Microsoft.EntityFrameworkCore;
using OrderService.ApplicationDbContext;
using OrderService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>
    (options => options.UseMySQL(builder.Configuration.GetConnectionString("MySqlCnnStr")));

builder.Services.AddScoped<IOrderService,OrderService.Services.OrderService>(); 

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
