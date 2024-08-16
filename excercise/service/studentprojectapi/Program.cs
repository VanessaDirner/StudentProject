using studentprojectapi.GeneratedModels;
using studentprojectapi.Services;
using Microsoft.EntityFrameworkCore;

// auto mapper https://docs.automapper.org/en/stable/Getting-started.html
var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<studentprojectContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.EnableSensitiveDataLogging();
});
builder.Services.AddTransient<PersonService>();
builder.Services.AddTransient<DepartmentService>();
builder.Services.AddTransient<AssignmentServices>();
builder.Services.AddTransient<ReportingServices>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
        builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});


builder.Services.AddControllers()
 .AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



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
