namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal class CountAddVisitor : IVisitor<MineItemImpl>
    {
        public async Task<(MineItemImpl, bool)> Visit(MineItemImpl o) => o switch
        {
            MineItemImpl0 x => (await x.Make<MineItemImpl1>(), true),
            MineItemImpl1 x => (await x.Make<MineItemImpl2>(), true),
            MineItemImpl2 x => (await x.Make<MineItemImpl3>(), true),
            MineItemImpl3 x => (await x.Make<MineItemImpl4>(), true),
            _ => (null, false),
        };
    }
}
