using EmployeeManagement.Models;

var builder = WebApplication.CreateBuilder(args);

//register services
builder.Services.AddMvc();
builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{Id?}"
        );
});

//app.MapGet("/", () => "Hello World!");

app.Run();
