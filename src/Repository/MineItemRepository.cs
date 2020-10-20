namespace SeungyongShim.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using LanguageExt;
    using SeungyongShim.Model;

    public class MineItemRepository
    {
        private IDictionary<(int, int), MineItem> MineItems { get; } = new Dictionary<(int, int), MineItem>();

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

        public async Task<IEnumerable<MineItem>> GetBombs() => await Task.FromResult(MineItems.Values.Where(x => x.IsBomb));

        public IEnumerable<Option<MineItem>> Nears(MineItem mineItem)
        {
            yield return MineItems.TryGetValue((mineItem.X - 1, mineItem.Y - 1));
            yield return MineItems.TryGetValue((mineItem.X, mineItem.Y - 1));
            yield return MineItems.TryGetValue((mineItem.X + 1, mineItem.Y - 1));
            yield return MineItems.TryGetValue((mineItem.X - 1, mineItem.Y));
            yield return MineItems.TryGetValue((mineItem.X + 1, mineItem.Y));
            yield return MineItems.TryGetValue((mineItem.X - 1, mineItem.Y + 1));
            yield return MineItems.TryGetValue((mineItem.X, mineItem.Y + 1));
            yield return MineItems.TryGetValue((mineItem.X + 1, mineItem.Y + 1));
        }

        public override string ToString() => string.Join(string.Empty, MineItems.Values);
    }
}
