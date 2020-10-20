namespace SeungyongShim.Model
{
    using System.Threading.Tasks;

    internal class MineItemImplCovered : MineItemImpl
    {
        public MineItemImplCovered(MineItemImpl impl) : base(impl) { }

        public override string ToString() => ".";
    }
}
