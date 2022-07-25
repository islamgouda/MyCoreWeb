using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyCoreWeb.Model;
using MyCoreWeb.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(corsOptions =>
{
    corsOptions.AddPolicy("mypolicy", policyBuider =>
    {
        policyBuider.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<Icourse, CourseRepository>();
string con =builder.Configuration.GetConnectionString("cs");
builder.Services.AddDbContext<Context>(OptionsBuilder =>
OptionsBuilder.UseSqlServer(con));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("mypolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
