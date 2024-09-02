namespace session01mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            //builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();
            //builder.Services.AddRazorPages();
            //builder.Services.AddMvc();
            var app = builder.Build();
            //app.MapGet("/", () => "Hello World!");
            app.UseRouting();
            app.UseStaticFiles();   
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllerRoute(name:"Default",pattern:"{controller=Home}/{action=index}/{id?}" );
            });
            app.Run();
        }
    }
}
