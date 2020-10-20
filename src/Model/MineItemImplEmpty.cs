namespace SeungyongShim.Model
{
    using System.Threading.Tasks;

    internal class MineItemImplEmpty : MineItemImpl
    {
        public MineItemImplEmpty() : base(null) { }

        public override string ToString() => "0";
    }
}
