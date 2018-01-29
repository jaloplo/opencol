namespace OpenCol {

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class TileControl : IControl {

        protected Color Color { get; private set; }
        public Vector2 Position { get; private set; }
        protected Texture2D Texture { get; private set; }

        public TileControl(Vector2 position, Color color) {
            Color = color;
            Position = position;
        }

        protected void GenerateTexture(GraphicsDevice device) {
            Texture = new Texture2D(device, 7, 7);
            var pixels = new Color[7*7];
            for(var i = 0; i < pixels.Length; i++) {
                pixels[i] = Color;
            }
            Texture.SetData(pixels);
        }

        public virtual void Draw(SpriteBatch batch, GameTime gameTime) {
            if(null == Texture)
                GenerateTexture(batch.GraphicsDevice);

            batch.Draw(Texture, new Vector2(Position.X + 1, Position.Y + 1));
        }
    }
}