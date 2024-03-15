using Microsoft.AspNetCore.Builder;

namespace Web_Resume_24
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
