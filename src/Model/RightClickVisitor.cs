namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal class RightClickVisitor : IVisitor<MineItemImpl>
    {
        public async Task<(MineItemImpl, bool)> Visit(MineItemImpl o) => o switch
        {
            MineItemImplCovered x => (await x.Make<MineItemImplFlaged>(), true),
            MineItemImplFlaged x => (await x.Make<MineItemImplCovered>(), true),
            _ => (null, false),
        };
    }
}
