using Hangfire;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Workdb.Data;
using Workdb.Models;
using Workdb.Services.City;
using Workdb.Services.EmployeeService;
using Workdb.Services.EmployeeTransferSalary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DEFAULT_CONNECTION")));
builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddHangfire(x => x.UseSqlServerStorage(builder.Configuration.GetConnectionString("DEFAULT_CONNECTION")));
builder.Services.AddHangfireServer();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<ICityService,CityService>();
builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<ITransferSalaryService,EmployeeTransferSalaryService>();

builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHangfireDashboard("/dashboard");

app.MapControllers();

app.Run();
