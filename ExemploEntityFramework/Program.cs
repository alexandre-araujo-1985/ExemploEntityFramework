using ExemploEntityFramework.Infra.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ExemploEntityFrameworkContext>();

var app = builder.Build();

app.UseSwaggerUI();
app.UseSwagger();

app.MapControllers();

app.Run();