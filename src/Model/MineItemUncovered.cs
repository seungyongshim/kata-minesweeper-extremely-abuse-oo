namespace SeungyongShim.Model
{
    using System.Threading.Tasks;

    internal class MineItemUncovered : MineItemImpl
    {
        public MineItemUncovered(MineItemImpl inner)
        {
            Inner = inner;
        }

        public override async Task<MineItemImpl> Click() => await Inner.Click();
    }
}
