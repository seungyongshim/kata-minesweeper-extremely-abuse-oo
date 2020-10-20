namespace SeungyongShim.Model
{
    using System.Threading.Tasks;

    internal class MineItemImplUncovered : MineItemImpl
    {
        public MineItemImplUncovered(MineItemImpl inner) : base(inner) { }

        public override string ToString() => Inner.ToString();
    }
}
