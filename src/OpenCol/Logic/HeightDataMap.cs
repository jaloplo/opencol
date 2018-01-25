namespace OpenCol.Logic {
    
    public class HeightDataMap : IDataMap2D {

        public Coordinates2D Coordinates { get; private set; }
        public float Value { get; private set; }


        public HeightDataMap(Coordinates2D coordinates, float value) {
            Coordinates = coordinates;
            Value = NormalizeValue(value);
        }

        public HeightDataMap(int x, int y, float value) 
            : this(new Coordinates2D(x, y), value) {
        }


        protected virtual float NormalizeValue(float value) {
            value = (value + 1) / 2;

            if(value > 1)
                value = 1;
            if(value < 0)
                value = 0;
            
            return value;
        }
    }
}