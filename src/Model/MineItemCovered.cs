namespace SeungyongShim.Model
{
    using System.Threading.Tasks;

    internal class MineItemCovered : MineItemImpl
    {
        public override async Task<MineItemImpl> Click() => await Task.FromResult(new MineItemUncovered(Inner));

        public override string ToString() => ".";
    }
}
