namespace OpenCol.Logic {
    
    using SharpNoise;

    public class Map : GenericMap<DataMap> {

        public Map(NoiseMap map) 
            : base(map) {

        }

        protected override DataMap GetDataMapItem(int x, int y, float value) {
            return new DataMap(x, y, value);
        }
    }
}