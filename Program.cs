
namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers().AddControllersAsServices();
            builder.Services.AddMvc();
            builder.Services.AddCors();
            builder.Services.AddDbContext<MedBaseContext>();
           

            var app = builder.Build();


            app.UseCors(op => op.AllowAnyOrigin());
            app.UseFileServer();
            app.MapControllers();

            app.Run();
        }
    }
}
