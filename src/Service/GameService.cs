namespace SeungyongShim.Service
{
    using System;
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

        public GameSize GameSize { get; }

        public MineItemRepository MineItemRepository { get; }

        public IRenderer Renderer { get; }

        public async Task Click()
        {
            foreach (var item in await MineItemRepository.GetAll())
            {
                await item.Click();
            }
            var mineItem = await MineItemRepository.Get(0, 0);
            await mineItem.Click();
        }

        public async Task Initialize()
        {
            var rand = new Random();
            var mineItems = from y in Enumerable.Range(0, GameSize.Height)
                            from x in Enumerable.Range(0, GameSize.Width)
                            select new MineItem(x, y);

            await MineItemRepository.Add(mineItems);

            for (var i = 0; i < 5; i++)
            {
                var item = await MineItemRepository.Get(rand.Next(GameSize.Width), rand.Next(GameSize.Height));
                if (item.IsBomb)
                {
                    i--;
                    continue;
                }
                item.SetBombs();
            }
        }
            

        public async Task Render() => await Renderer.Render(MineItemRepository.ToString());
    }
}
