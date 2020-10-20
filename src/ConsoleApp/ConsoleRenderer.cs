namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SeungyongShim.Core;
    using SeungyongShim.Service;

    internal class ConsoleRenderer : IRenderer
    {
        public ConsoleRenderer(GameSize gameSize)
        {
            GameSize = gameSize;
        }

        public GameSize GameSize { get; }

        public async Task Render(string value)
        {
            var buffer = SplitRenderWidth(value).Select(x => x.Aggregate(new StringBuilder(),
                                                                        (c, a) => c.Append(a)
                                                                                   .Append(' ')));

            var joinBuffer = string.Join('\n', buffer);


            Console.SetCursorPosition(0, 0);
            await Console.Out.WriteLineAsync(joinBuffer);
            await Console.Out.FlushAsync();

            IEnumerable<IEnumerable<char>> SplitRenderWidth(string v)
            {
                for (var i = 0; i < GameSize.Height; i++)
                {
                    yield return v.Skip(GameSize.Width * i).Take(GameSize.Width);
                }

            }
        }
    }
}
