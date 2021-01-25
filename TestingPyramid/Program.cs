using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace TestingPyramid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            var config = Fluently.Configure()
                .Database(
                    MySQLConfiguration.Standard
                        .ConnectionString("server=localhost;port=3306;database=pyramid;user=root;password=pyramid")
                )
                .BuildConfiguration()
                .BuildSessionFactory();
            
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }
    }
}