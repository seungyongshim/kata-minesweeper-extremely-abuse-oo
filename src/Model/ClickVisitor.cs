namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal class ClickVisitor : IVisitor<MineItemImpl>
    {
        public ClickVisitor()
        {
        }

        public async Task<MineItemImpl> Visit(MineItemImpl obj) => obj switch
        {
            MineItemImplCovered x => new MineItemImplUncovered(x),
            _ => await Task.FromResult<MineItemImpl>(null),
        };
    }
}
