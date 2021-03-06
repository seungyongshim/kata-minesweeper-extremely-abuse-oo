namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal class ClickVisitor : IVisitor<MineItemImpl>
    {
        public async Task<(MineItemImpl, bool)> Visit(MineItemImpl o) => o switch
        {
            MineItemImplCovered x => (await x.Make<MineItemImplUncovered>(), true),
            _ => (null, false),
        };
    }
}
