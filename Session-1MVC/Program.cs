using Microsoft.AspNetCore.Builder;

namespace Session_1MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews(); // Register Bult-in MVC Server


            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            ////app.MapGet("/login", () => "U R Signed In!");
            //app.MapGet("/login", Singin);

            app.UseStaticFiles();

            // MVC : 
            app.MapControllerRoute(
                name : "default",
                pattern : "{controller=Home}/{action=Index}/{id}"
                
                
                );

            app.Run();
        }

        public static string Singin()
        {
            return $"U R Signed In!";
        }
    }
}
