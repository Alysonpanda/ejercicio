using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Repository.Tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                    {
                        services.AddDbContext<Database.DatabaseContext>(options =>
                        {
                            var connectionString = "Data Source=.;Initial Catalog=ejercicio;Max Pool Size=100;Integrated Security=True;Encrypt=False";
                            options.UseSqlServer(connectionString, x => x.MigrationsAssembly("Repository.Tool"));
                        });

                    }).Build();

            host.Run();
        }
    }
}