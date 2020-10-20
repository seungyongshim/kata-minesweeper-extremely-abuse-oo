namespace SeungyongShim.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SeungyongShim.Model;

    public class MineItemRepository
    {
        private Dictionary<(int, int), MineItem> MineItems { get; } = new Dictionary<(int, int), MineItem>();

        public async Task Add(MineItem mineItem)
        {
            MineItems[(mineItem.X, mineItem.Y)] = mineItem;
            await Task.CompletedTask;
        }

        public async Task Add(IEnumerable<MineItem> mineItems)
        {
            foreach (var x in mineItems)
            {
                await Add(x);
            }
        }

        public async Task<MineItem> Get(int x, int y) => await Task.FromResult(MineItems[(x, y)]);

        public async Task<IEnumerable<MineItem>> GetAll() => await Task.FromResult(MineItems.Values.ToArray());

        public override string ToString() => string.Join(string.Empty, MineItems.Values);
    }
}
