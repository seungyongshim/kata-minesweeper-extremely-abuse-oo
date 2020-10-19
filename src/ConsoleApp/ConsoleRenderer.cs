namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SeungyongShim.Core;
    using SeungyongShim.Service;

    class ConsoleRenderer : IRenderer
    {
        public ConsoleRenderer(GameSize gameSize)
        {
            GameSize = gameSize;
        }

        public GameSize GameSize { get; }

        public async Task Render(string value)
        {
            var buffer = string.Join('\n', value.Split(null, GameSize.Width)
                                                .Select(x => x.Select(a => a + " ")));

            Console.SetCursorPosition(0, 0);
            await Console.Out.WriteAsync(buffer);
            await Console.Out.FlushAsync();
        }
    }
}
