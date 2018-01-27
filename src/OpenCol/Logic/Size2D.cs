namespace OpenCol.Logic {
    
    public class Size2D {

        public int Height { get; private set; }
        public int Width { get; private set; }

        public Size2D(int width, int height) {
            Height = height;
            Width = width;
        }
    }
}