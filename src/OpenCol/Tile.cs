namespace OpenCol {

    using Microsoft.Xna.Framework;

    public class Tile : ITile {
        public float Height { get; private set; }
        public float Moisture { get; private set; }
        public float Temperature { get; private set; }

        public Vector2 Position { get; private set; }


        public Tile(Vector2 position, float height, float moisture, float temperature) {
            Height = height;
            Moisture = moisture;
            Temperature = temperature;
            
            Position = position;
        }
    }
}