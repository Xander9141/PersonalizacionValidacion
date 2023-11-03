var builder = WebApplication.CreateBuilder(args);
//indicar que usaremos MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();
//Configuracion de rutas, archivos estaticos y autentificacion
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(name: "default",    
    pattern: "{controller=PrincipalController}/{action=Index}/{id?}");


app.Run();