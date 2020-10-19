namespace ConsoleApp
{
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using SeungyongShim.Core;
    using SeungyongShim.Model;
    using SeungyongShim.Service;

    internal class Program
    {
        private static async Task Main(string[] args) =>
            await Host.CreateDefaultBuilder()
                      .ConfigureServices(sc =>
                      {
                          sc.AddSingleton<IRenderer, ConsoleRenderer>();
                          sc.AddSingleton<MineItemRepository>();
                          sc.AddSingleton<GameSize>(sp => new GameSize(8, 8));
                          sc.AddSingleton<GameService>();
                          sc.AddHostedService<GameHostedService>();
                      })
                      .Build()
                      .StartAsync();

    }
}
