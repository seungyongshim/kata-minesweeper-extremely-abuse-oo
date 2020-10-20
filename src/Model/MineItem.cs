namespace SeungyongShim.Model
{
    using System;
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    public class MineItem : IGameObject
    {
        public MineItem(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsBomb => MineItemImpl.IsBomb;
        public int X { get; }
        public int Y { get; }
        private MineItemImpl MineItemImpl { get; set; } = MineItemImpl.Make();
        public async Task Click() => await MineItemImpl.Accept(new ClickVisitor());
        public async Task RightClick() => await MineItemImpl.Accept(new RightClickVisitor());
        public async Task SetBomb() => await MineItemImpl.Accept(new BombCreateVisitor());
        public override string ToString() => MineItemImpl.ToString();

        public async Task CountAdd() => await MineItemImpl.Accept(new CountAddVisitor());
    }
}
