using BlazorApp3.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MatBlazor;
using MudBlazor.Services;
using Protocol.Type;
using RiotSharp.Misc;
using Syncfusion.Blazor;
using Blazored.LocalStorage;
using Microsoft.JSInterop;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMudServices();
builder.Services.AddServerSideBlazor();
builder.Services.AddMatToaster(config =>
{
    config.Position = MatToastPosition.TopCenter;
    config.PreventDuplicates = true;
    config.NewestOnTop = true;
    config.ShowCloseButton = true;
    config.MaximumOpacity = 95;
    config.VisibleStateDuration = 3000;
});

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<PlayerService>();

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