namespace ConsoleApp
{
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    internal class Program
    {
        private static async Task Main(string[] args) =>
            await Host.CreateDefaultBuilder()
                      .ConfigureServices(sc => sc.AddHostedService<GameHostedService>())
                      .Build()
                      .StartAsync();

    }
}
