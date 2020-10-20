namespace SeungyongShim.Model
{
    using System.Threading.Tasks;

    internal class MineItemImplBomb : MineItemImpl
    {
        public override bool IsBomb => true;
        public override string ToString() => "*";
    }
}
