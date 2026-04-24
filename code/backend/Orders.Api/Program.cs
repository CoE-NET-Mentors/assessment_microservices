using Microsoft.EntityFrameworkCore;
using Orders.Api.Data;
using Orders.Api.Services;

var builder = WebApplication.CreateBuilder(args);
// ------------ Builder configuration ------------

builder.Services.AddControllers();
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}
builder.Services.AddDbContext<OrdersDbContext>(options =>
    options.UseInMemoryDatabase("OrdersDb"));

builder.Services.AddScoped<IOrdersService, OrdersService>();


var app = builder.Build();
// ------------ Request pipeline configuration ------------

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();