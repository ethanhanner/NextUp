using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using NextUp.API.Data;
using NextUp.API.Interfaces;
using NextUp.API.Models.Configuration;
using NextUp.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NextUpDb"));
});

builder.Services.Configure<FileStorageSettings>(builder.Configuration.GetSection("FileStorageSettings"));
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IUploadService, UploadService>();

var app = builder.Build();

var storageSettings = builder.Configuration.GetSection("FileStorageSettings").Get<FileStorageSettings>();

if (storageSettings != null)
{
    if (!Directory.Exists(storageSettings.LocalImageDirectory))
    {
        Directory.CreateDirectory(storageSettings.LocalImageDirectory);
    }

    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(storageSettings.LocalImageDirectory),
        RequestPath = storageSettings.RequestPath
    });
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
