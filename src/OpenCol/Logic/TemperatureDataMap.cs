namespace OpenCol.Logic {
    
    public class TemperatureDataMap : IDataMap2D {

        public Coordinates2D Coordinates { get; private set; }
        public float Value { get; private set; }


        public TemperatureDataMap(Coordinates2D coordinates, float value) {
            Coordinates = coordinates;
            Value = value;
        }

        public TemperatureDataMap(int x, int y, float value) 
            : this(new Coordinates2D(x, y), value) {
        }
    }
}