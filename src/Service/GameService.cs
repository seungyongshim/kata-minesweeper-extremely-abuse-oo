namespace SeungyongShim.Service
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using SeungyongShim.Core;
    using SeungyongShim.Model;
    using SeungyongShim.Repository;

    public class GameService
    {
        public GameService(GameSize gameSize, IRenderer renderer, MineItemRepository mineItemRepository)
        {
            GameSize = gameSize;
            Renderer = renderer;
            MineItemRepository = mineItemRepository;

            
        }

        public async Task Initialize()
        {
            var mineItems = from y in Enumerable.Range(0, GameSize.Height)
                            from x in Enumerable.Range(0, GameSize.Width)
                            select new MineItem(x, y);

            await MineItemRepository.Add(mineItems);
        }

        public GameSize GameSize { get; }
        public IRenderer Renderer { get; }
        public MineItemRepository MineItemRepository { get; }

        public async Task Render() => await Renderer.Render(MineItemRepository.ToString());
    }
}
