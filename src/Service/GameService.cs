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

        public async Task GenerateNearCount()
        {
            foreach(var item in await MineItemRepository.GetBombs())
            {
                foreach(var x in MineItemRepository.Nears(item).Where(x => x.IsSome).Bind(x => x))
                {
                    x.CountAdd();
                }
            }
        }

        public async Task Initialize()
        {
            var mineItems = from y in Enumerable.Range(0, GameSize.Height)
                            from x in Enumerable.Range(0, GameSize.Width)
                            select new MineItem(x, y);

            await MineItemRepository.Add(mineItems);
        }

        public async Task SetBombs(int count = 5)
        {
            var rand = new Random();
            for (var i = 0; i < count; i++)
            {
                var item = await MineItemRepository.Get(rand.Next(GameSize.Width),
                                                        rand.Next(GameSize.Height));
                if (item.IsBomb)
                {
                    i--;
                    continue;
                }
                await item.SetBomb();
            }
        }

        public async Task Render() => await Renderer.Render(MineItemRepository.ToString());
    }
}
