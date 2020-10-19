namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    public class MineItem : IGameObject, IClickable<IResult>, IRenderable
    {
        public MineItem(int x, int y, MineItemRepository mineItemRepository)
        {
            X = x;
            Y = y;

            MineItemRepository = mineItemRepository;
        }

        public int X { get; }
        public int Y { get; }
        public MineItemRepository MineItemRepository { get; }

        private MineItemImpl MineItemImpl { get; } = new MineItemCovered();

        public async Task<IResult> Click() => await Task.FromResult(new Result());
    }
}
