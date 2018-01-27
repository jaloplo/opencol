namespace OpenCol.Logic {
    
    public class WorldData : IData2D<WorldDataValue> {

        public Coordinates2D Coordinates { get; private set; }
        public WorldDataValue Value { get; private set; }

        public WorldData(Coordinates2D coordinates, WorldDataValue value) {
            Coordinates = coordinates;
            Value = value;
        }
    }
}