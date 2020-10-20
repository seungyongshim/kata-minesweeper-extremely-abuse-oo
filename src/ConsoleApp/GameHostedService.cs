namespace ConsoleApp
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Hosting;
    using SeungyongShim.Core;
    using SeungyongShim.Service;

    internal class GameHostedService : BackgroundService
    {
        public GameHostedService(GameService gameService) => GameService = gameService;

        public GameService GameService { get; }
        public IRenderer ConsoleRenderer { get; set; }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await GameService.Initialize();

            while(!stoppingToken.IsCancellationRequested)
            {
                await GameService.Render();
                await Console.In.ReadLineAsync();
            }
        }
    }
}
