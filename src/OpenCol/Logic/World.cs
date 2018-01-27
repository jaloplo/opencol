namespace OpenCol.Logic {
    
    public class World : IWorld {
        
        protected WorldMap Map { get; private set; }
        public Size2D Size { get; private set; }


        public World(Size2D size) {
            Size = size;
        }

        public World(int width, int height)
            : this(new Size2D(width, height)) {
        }

        public World(WorldMap map) 
            : this(map.Width, map.Height) {
            Map = map;
        }


        public virtual WorldDataValue Get(int x, int y) {
            return Map.GetValue(x, y).Value;
        }
    }
}