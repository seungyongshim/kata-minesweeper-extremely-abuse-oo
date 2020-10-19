namespace SeungyongShim.Model
{
    using System.Threading.Tasks;
    using SeungyongShim.Core;

    internal abstract class MineItemImpl : IClickable<MineItemImpl>
    {
        protected MineItemImpl Inner { get; set; }

        public abstract Task<MineItemImpl> Click();
    }
}
