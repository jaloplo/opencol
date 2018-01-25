namespace OpenCol.Logic {

    using SharpNoise;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Map<T> : IMap2D<T>
        where T : IDataMap2D {

        protected NoiseMap ParentMap { get; private set; }

        public Map(NoiseMap map) {
            ParentMap = map;
        }


        protected abstract T GetDataMapItem(int x, int y, float value);


        public T GetValue(int x, int y) {
            return GetDataMapItem(x, y, ParentMap.GetValue(x, y));
        }

        public void SetValue(int x, int y, float value) {
            ParentMap[x, y] = value;
        }
    }
}