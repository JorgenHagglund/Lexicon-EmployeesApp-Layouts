using System.Globalization;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("sv-SE");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllers();
            app.UseStaticFiles();
            app.Run();
        }
    }
}