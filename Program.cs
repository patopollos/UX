using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvcCore();
builder.Services.AddRazorPages();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/General/Error/Index");
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseStatusCodePagesWithReExecute("/General/Error/Index/{0}");



//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});




/*app.MapAreaControllerRoute(
    name: "default",
    areaName: "General",
    pattern: "{controller=Inicio}/{action=Index}/{id?}");*/

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
				  name: "default",
				  pattern: "{area:exists}/{controller=Inicio}/{action=Index}/{id?}");


	endpoints.MapAreaControllerRoute(
			   name: "default",
			   areaName: "General",
			   pattern: "{controller=Inicio}/{action=Index}/{id?}");
	endpoints.MapRazorPages();
});



AppDomain.CurrentDomain.SetData("ContentRootPath", app.Environment.ContentRootPath);
AppDomain.CurrentDomain.SetData("WebRoothPath", app.Environment.WebRootPath);

app.MapRazorPages();
app.Run();
