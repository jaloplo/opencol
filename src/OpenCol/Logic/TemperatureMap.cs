namespace OpenCol.Logic {
    
    using SharpNoise;

    public class TemperatureMap : Map<DataMap> {

        public TemperatureMap(NoiseMap map) 
            : base(map) {

        }

        protected override DataMap GetDataMapItem(int x, int y, float value) {
            return new DataMap(x, y, value);
        }
    }
}