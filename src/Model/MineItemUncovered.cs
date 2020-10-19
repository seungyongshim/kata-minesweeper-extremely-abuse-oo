using System.Threading.Tasks;

namespace SeungyongShim.Model
{
    internal class MineItemUncovered : MineItemImpl
    {
        public MineItemUncovered(MineItemImpl inner) => Inner = inner;

        public override async Task<MineItemImpl> Click() => await Inner.Click();
    }
}
