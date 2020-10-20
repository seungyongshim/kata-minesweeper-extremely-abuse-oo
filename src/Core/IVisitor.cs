namespace SeungyongShim.Core
{
    using System.Threading.Tasks;

    public interface IVisitor<T>
    {
        Task<(T, bool)> Visit(T obj);
    }
}
