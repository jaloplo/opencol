namespace OpenCol.Logic {

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HeightMap : IMap2D {

        protected IList<IDataMap2D> Data { get; private set; } 

        public HeightMap() {
            Data = new List<IDataMap2D>();
        }


        public IDataMap2D GetValue(int x, int y) {
            return Data.FirstOrDefault(d => d.Coordinates.X == x && d.Coordinates.Y == y);
        }

        public void SetValue(int x, int y, float value) {
            var item = Data.FirstOrDefault(d => d.Coordinates.X == x && d.Coordinates.Y == y);
            if(null != item)
                Data.Remove(item);
                
            Data.Add(new HeightDataMap(x, y, value));
        }
    }
}