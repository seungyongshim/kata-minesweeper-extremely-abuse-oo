namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal abstract class MineItemImpl : IVisitable<MineItemImpl>
    {
        protected MineItemImpl Inner { get; set; }

        public async Task Accept(IVisitor<MineItemImpl> visitor) => await AcceptInner(visitor);
        public override string ToString() => Inner.ToString();

        protected async Task<MineItemImpl> AcceptInner(IVisitor<MineItemImpl> visitor)
        {
            return Inner = await visitor.Visit(this) ??
                           await NextVisit();

            async Task<MineItemImpl> NextVisit() => await Inner.AcceptInner(visitor);
        }
        public MineItemImpl Make<T>() where T : MineItemImpl, new()
        {
            return new T()
            {
                Inner = Inner
            };
        }
    }
}
