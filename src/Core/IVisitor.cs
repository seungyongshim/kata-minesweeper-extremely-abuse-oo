namespace SeungyongShim.Core
{
    using System.Threading.Tasks;

    public interface IVisitor<T>
    {
        Task<T> Visit(T obj);
    }
}
