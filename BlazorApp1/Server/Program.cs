global using BlazorApp1.Server.Data_Access;
global using BlazorApp1.Shared.Etms;
global using BlazorApp1.Shared.Protos;
global using Grpc.Core;
global using Mapster;
global using Microsoft.EntityFrameworkCore;
using BlazorApp1.Server.feaT1Karyawan.GrpcServices;
using BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.GrpcServices;
using BlazorApp1.Server.Features.feaT0Jabatan.GrpcServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddGrpc();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var config = TypeAdapterConfig.GlobalSettings;
config.Default.NameMatchingStrategy(NameMatchingStrategy.Flexible);
config.Default.IgnoreNullValues(true);
builder.Services.AddSingleton(config);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseGrpcWeb();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcService<svsT1Karyawan>().EnableGrpcWeb();
    endpoints.MapGrpcService<svsT0DivisiPerusahaan>().EnableGrpcWeb();
    endpoints.MapGrpcService<svsT0Jabatan>().EnableGrpcWeb();

});

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
