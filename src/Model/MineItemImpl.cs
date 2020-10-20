namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal class MineItemImpl 
    {
        virtual public bool IsBomb => Inner?.IsBomb ?? false;
        virtual public bool IsCovered => Inner?.IsCovered ?? false;
        virtual public bool IsFlaged => Inner?.IsFlaged ?? false;
        protected MineItemImpl Inner { get; set; }
        public static MineItemImpl Make() => new MineItemImpl()
        {
            Inner = new MineItemImplCovered()
            {
                Inner = new MineItemImpl0()
            }
        };

        public async Task Accept(IVisitor<MineItemImpl> visitor) => await AcceptInner(visitor);
        public async Task<MineItemImpl> Make<T>() where T : MineItemImpl, new()
        {
            await Task.CompletedTask;

            return new T()
            {
                Inner = Inner
            };
        }
        public override string ToString() => Inner.ToString();

        protected async Task AcceptInner(IVisitor<MineItemImpl> visitor)
        {
            (var inner, var complete) = await visitor.Visit(Inner);

            Inner = inner ?? Inner;

            if (!complete)
            {
                if (Inner != null)
                {
                    await Inner.AcceptInner(visitor);
                }
            }
        }
    }
}
