namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal class BombCreateVisitor : IVisitor<MineItemImpl>
    {
        public async Task<(MineItemImpl, bool)> Visit(MineItemImpl o) => o switch
        {
            MineItemImpl0 x => (await x.Make<MineItemImplBomb>(), true),
            _ => (null, false),
        };
    }
}
