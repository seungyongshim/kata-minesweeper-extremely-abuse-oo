namespace SeungyongShim.Core
{
    using System.Threading.Tasks;

    public interface IRenderer
    {
        Task Render(string value);
    }
}
