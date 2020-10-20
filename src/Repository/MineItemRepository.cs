namespace SeungyongShim.Repository
{
    using System.Collections.Generic;
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

        public override string ToString() =>
            string.Join(string.Empty, MineItems.Values);

        public async Task Add(IEnumerable<MineItem> mineItems)
        {
            foreach (var x in mineItems)
            {
                await Add(x);
            }
        }
    }
}
