namespace SeungyongShim.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    public class MineItem : IGameObject, IClickable, IRenderable
    {
        public MineItem(int x, int y, MineItemRepository mineItemRepository)
        {
            this.X = x;
            this.Y = y;
            this.MineItemRepository = mineItemRepository;
        }

        public int X { get; }
        public int Y { get; }
        public MineItemRepository MineItemRepository { get; }

        public Task Click() => throw new NotImplementedException();
    }
}
