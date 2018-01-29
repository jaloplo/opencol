namespace OpenCol {
    
    using Microsoft.Xna.Framework;

    public interface ITile {
        float Height { get; }
        float Moisture { get; }
        float Temperature { get; }

        Vector2 Position { get; }
    }
}