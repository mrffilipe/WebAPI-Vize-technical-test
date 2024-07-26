using WebAPI_Vize_technical_test.src.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services
    .AddAutoMapper(typeof(Program).Assembly)
    .AddSwaggerConfiguration()
    .AddCorsConfiguration()
    .AddAuthenticationConfiguration()
    .AddDbContextConfiguration(builder.Configuration)
    .AddAdapters()
    .AddServices()
    .AddRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();