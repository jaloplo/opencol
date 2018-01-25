namespace OpenCol.Logic {
    
    using SharpNoise;

    public class HeightMap : Map<HeightDataMap> {

        public HeightMap(NoiseMap map) 
            : base(map) {

        }

        protected override HeightDataMap GetDataMapItem(int x, int y, float value) {
            return new HeightDataMap(x, y, value);
        }
    }
}