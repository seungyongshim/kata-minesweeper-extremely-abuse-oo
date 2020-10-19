using System.Collections.Generic;
using System.Collections.ObjectModel;
using SeungyongShim.Core;
using SeungyongShim.Model;

namespace SeungyongShim.Service
{
    public class GameService
    {
        public GameService(int width, int height)
        {
            Width = width;
            Height = height;

            MineItems = new Collection<MineItem>();


        }

        private ICollection<MineItem> MineItems { get; }

        public int Width { get; }
        public int Height { get; }

        public void Render(IRenderer consoleRenderer)
        {

        }
    }
}
