namespace SeungyongShim.Model
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    public class MineItemRepository
    {
        private IList<MineItem> MineItems { get; } = new List<MineItem>();
        public async Task Add(MineItem mineItem)
        {
            MineItems.Add(mineItem);
            await Task.CompletedTask;
        }

        public override string ToString() =>
            string.Join(string.Empty, MineItems);
    }
}
