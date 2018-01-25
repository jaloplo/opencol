namespace OpenCol.Logic {

    using SharpNoise;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HeightMap : IMap2D {

        protected NoiseMap ParentMap { get; private set; }

        public HeightMap(NoiseMap map) {
            ParentMap = map;
        }


        public IDataMap2D GetValue(int x, int y) {
            return new HeightDataMap(x, y, ParentMap.GetValue(x, y));
        }

        public void SetValue(int x, int y, float value) {
            ParentMap[x, y] = value;
        }
    }
}