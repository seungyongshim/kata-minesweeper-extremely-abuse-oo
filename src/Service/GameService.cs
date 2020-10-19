namespace SeungyongShim.Service
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using SeungyongShim.Core;
    using SeungyongShim.Model;

    public class GameService
    {
        public GameService(GameSize gameSize, IRenderer renderer, MineItemRepository mineItemRepository)
        {
            GameSize = gameSize;
            ConsoleRenderer = renderer;
            MineItemRepository = mineItemRepository;

            for (int j = 0; j < GameSize.Height; j++)
            {
                for (int i = 0; i < GameSize.Width; i++)
                {
                    mineItemRepository.Add(new MineItem(i, j));
                }
            }
        }

        public GameSize GameSize { get; }
        public IRenderer ConsoleRenderer { get; }
        public MineItemRepository MineItemRepository { get; }

        public async Task Render() => await ConsoleRenderer.Render(MineItemRepository.ToString());
    }
}
