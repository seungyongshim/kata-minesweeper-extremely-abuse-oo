using System.Threading.Tasks;

namespace SeungyongShim.Core
{
    public interface IClickable : IGameObject
    {
        Task Click();
    }
}
