namespace SeungyongShim.Core
{
    using System.Threading.Tasks;

    public interface IVisitable<T>
    {
        public Task Accept(IVisitor<T> visitor);
    }
}
