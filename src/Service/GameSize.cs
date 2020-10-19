namespace SeungyongShim.Service
{
    public class GameSize
    {
        public GameSize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; }
    }
}
