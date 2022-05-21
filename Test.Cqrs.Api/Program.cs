using AppService.Cqrs.Api.Commands.User;
using AppService.Cqrs.Api.Contract;
using Domain.Cqrs.Api.Entities.User;
using Infra.Cqrs.Api.Implementation;
using Infra.Cqrs.Api.Mapper;
using MediatR;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(AddUserCommand).Assembly);

builder.Services.AddTransient<IRepository<Users>, Repository>();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MapperBootstraper>();
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
