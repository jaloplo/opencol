namespace OpenCol.Logic {
    
    public class WorldDataValue {
        public float Height { get; set; }
        public float Moisture { get; set; }
        public float Temperature { get; set; }

        public WorldDataValue(float height, float moisture, float temperature) {
            Height = height;
            Moisture = moisture;
            Temperature = temperature;
        }
    }
}