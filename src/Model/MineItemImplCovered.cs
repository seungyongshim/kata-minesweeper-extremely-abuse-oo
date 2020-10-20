namespace SeungyongShim.Model
{
    using System;
    using System.Threading.Tasks;

    internal class MineItemImplCovered : MineItemImpl
    {
        public override bool IsCovered => true;
        public override string ToString() => ".";
    }
}
