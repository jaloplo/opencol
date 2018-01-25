namespace OpenCol.Logic {
    
    using SharpNoise;

    public class TemperatureMap : Map<TemperatureDataMap> {

        public TemperatureMap(NoiseMap map) 
            : base(map) {

        }

        protected override TemperatureDataMap GetDataMapItem(int x, int y, float value) {
            return new TemperatureDataMap(x, y, value);
        }
    }
}