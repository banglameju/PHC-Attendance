using DataAccess.Repository;
using Domain.CSBImportModels;
using PHCAttendanceService.Profiles;
using PHCAttendanceService.Services.AttendanceService;
using PHCAttendanceService.Services.CSBImportServices;
//using PHCAttendanceService.Services.CSBLeave;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddScoped<CsbimportContext>();
builder.Services.AddScoped<CsbHealthEmpDataService>();
builder.Services.AddScoped<HealthEmpAttendanceService>();
builder.Services.AddScoped<AccessLogService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<PatternService>();
//builder.Services.AddScoped<CsbLeaveService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
//app.UseMiddleware<ApiKeyAuthMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
