using System.Threading.Tasks;

namespace SeungyongShim.Model
{
    public class MineItemRepository
    {
        public async Task Add(MineItem mineItem) => await Task.CompletedTask;
    }
}
