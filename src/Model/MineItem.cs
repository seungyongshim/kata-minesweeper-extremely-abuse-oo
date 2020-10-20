namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    public class MineItem : IGameObject
    {
        public MineItem(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        private MineItemImpl MineItemImpl { get; } = new MineItemImplCovered(new MineItemImplEmpty());

        public async Task<IResult> Click()
        {
            var clickVisitor = new ClickVisitor();
            await MineItemImpl.Accept(clickVisitor);

            return null;
        }

        public override string ToString() => MineItemImpl.ToString();
    }
}
