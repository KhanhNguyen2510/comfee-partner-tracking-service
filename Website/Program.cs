
const string __myAllowAllOrigins = "_myAllowAllOrigins";

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Service Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(__myAllowAllOrigins, policyBuilder =>
    {
        policyBuilder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithExposedHeaders("location", "Content-Disposition", "Link", "X-Total-Count", "X-Limit");
    });
});


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

