using API.IServices;
//using API.Middlewares;
using API.Services;
using Data;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IUserSecurityService, UserSecurityService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserRolService, UserRolService>();
builder.Services.AddScoped<IOrderService, OrderService>();

//builder.Services.AddScoped<IUserSecurityLogic, UserSecurityLogic>();
builder.Services.AddScoped<IUserLogic, UserLogic>();
builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IUserRolLogic, UserRolLogic>();
builder.Services.AddScoped<IOrderLogic, OrderLogic>();


builder.Services.AddDbContext<ServiceContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
    builder =>
    {
        builder.AllowAnyOrigin()
     .AllowAnyMethod()
    .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();