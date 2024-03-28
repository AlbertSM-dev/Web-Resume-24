using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace Web_Resume_24
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            app.UseDefaultFiles();
            app.UseStaticFiles();

        }
    }
}
