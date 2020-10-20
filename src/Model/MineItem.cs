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

        private MineItemImpl MineItemImpl { get; init; } = new MineItemImplCovered(new MineItemImplEmpty());

        public async Task Click()
        {
            var clickVisitor = new ClickVisitor();
            await MineItemImpl.Accept(clickVisitor);
        }

        public override string ToString() => MineItemImpl.ToString();

        
    }
}
