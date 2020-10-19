using System.Threading.Tasks;

namespace SeungyongShim.Core
{
    public interface IClickable<T> : IGameObject
    {
        Task<T> Click();
    }
}
