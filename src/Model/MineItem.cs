namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    public class MineItem : IGameObject, IClickable<IResult>, IRenderable
    {
        public MineItem(int x, int y)
        {
            X = x;
            Y = y;

        }

        public int X { get; }
        public int Y { get; }

        private MineItemImpl MineItemImpl { get; } = new MineItemCovered();

        public async Task<IResult> Click() => await Task.FromResult(new Result());

        public override string ToString() => MineItemImpl.ToString();
    }
}
