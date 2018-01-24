namespace OpenCol {

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class RenderHandler {

        protected GraphicsDeviceManager Graphics { get; private set; }
        protected SpriteBatch Batch { get; private set; }


        public RenderHandler(GraphicsDeviceManager graphics) {
            Graphics = graphics;
        }


        public virtual void Initialize() {
            Batch = new SpriteBatch(Graphics.GraphicsDevice);
        }

        public virtual void Draw(GameTime gameTime) {
            Batch.Begin();
            Batch.End();
        }
    }
}