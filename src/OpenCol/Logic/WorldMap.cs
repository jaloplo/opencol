namespace OpenCol.Logic {

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WorldMap : IMap2D<WorldData> {

        protected IList<WorldData> Data { get; private set; }

        public int Height { get; private set; }
        public int Width { get; private set; }


        public WorldMap(int width, int height) {
            Data = new List<WorldData>(width * height);

            Height = height;
            Width = width;
        }

        public WorldData GetValue(int x, int y) {
            return Data.FirstOrDefault(d => d.Coordinates.X == x && d.Coordinates.Y == y);
        }

        public void SetValue(int x, int y, WorldDataValue value) {
            var item = Data.FirstOrDefault(d => d.Coordinates.X == x && d.Coordinates.Y == y);
            if(null != item) {
                Data.Remove(item);
            }

            Data.Add(new WorldData(new Coordinates2D(x, y), value));
        }
        
        public void SetValue(int x, int y, float height, float moisture, float temperature) {
            var item = Data.FirstOrDefault(d => d.Coordinates.X == x && d.Coordinates.Y == y);
            if(null != item) {
                Data.Remove(item);
            }

            Data.Add(new WorldData(new Coordinates2D(x, y), new WorldDataValue(height, moisture, temperature)));
        }
    }
}