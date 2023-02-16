using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ElevenNote.Server.Data;
using ElevenNote.Services.Configurations;
using ElevenNote.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using ElevenNote.Services.Services.IServices;
using ElevenNote.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddAutoMapper(typeof(MappingConfigurations));
builder.Services.AddDbContext<AppDbContext>(options=>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICategoryService,CategoryService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
