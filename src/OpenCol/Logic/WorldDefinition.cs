namespace OpenCol.Logic {
    
    public class WorldDefinition : IWorldDefinition {
        public Size2D Size { get; set; }

        public WorldDefinition(int width, int height) {
            Size = new Size2D(width, height);
        }
    }
}