namespace SeungyongShim.Model
{
    using System.Threading.Tasks;

    internal class MineItemImplUncovered : MineItemImpl
    {
        public override string ToString() => Inner.ToString();
    }
}
