using WebApplicationLoggingMiddlewareDI;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<DIDatabaseContext>();
builder.Services.AddScoped<DIRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//ILogger logger = builder.Logging.Services.BuildServiceProvider().GetRequiredService<ILogger<Program>>();
//app.Use(async (context, next) =>
//{
//    logger.LogInformation("start M1");
//    await next();
//    logger.LogInformation("end M1");
//});
//app.Use(async (context, next) =>
//{
//    logger.LogInformation("start M2");
//    await next();
//    logger.LogInformation("end M2");
//});
//app.UseMiddleware<LogURLMiddleware>();
//app.UseLogURLMiddleware();
app.UseAuthorization();

app.MapControllers();

app.Run();
