using Application.DependencyInjection;
using Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor.Services;
using NetcodeHub.Packages.Components.DataGrid;
using NetcodeHub.Packages.Extensions.LocalStorage;
using Syncfusion.Blazor;
using WebUI.Components;
using WebUI.Components.Layout.Identity;
using WebUI.Hubs;
using WebUI.States;
using WebUI.States.Administration;
using WebUI.States.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureService(builder.Configuration);
builder.Services.AddApplicationService();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthStateProvider>();
builder.Services.AddScoped<ICustomAuthorizationService, CustomAuthorizationService>();
builder.Services.AddScoped<SoftHubConnectionService>();
builder.Services.AddSingleton<ChangePasswordState>();
builder.Services.AddScoped<UserActiveOrderCountState>();
builder.Services.AddScoped<AdminActiveOrderCountState>();
builder.Services.AddScoped<GenericHomeHeaderState>();

builder.Services.AddSyncfusionBlazor();
builder.Services.AddVirtualizationService();
builder.Services.AddNetcodeHubLocalStorageService();
Syncfusion.Licensing
    .SyncfusionLicenseProvider
    .RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXhedXRXRmJdVEJyW0M=");
    //.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCeUx3RHxbf1x0ZFJMY1lbQXZPIiBoS35RckVkWXtfeXdQQ2BbU0Zy");
builder.Services.AddMudServices();
builder.Services.AddSignalR();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.MapSignOutEndpoint();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
