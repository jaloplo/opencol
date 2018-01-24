namespace OpenCol.Client {

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class OpenColGame : Game {

        public GraphicsDeviceManager Graphics { get; private set; }
        protected SpriteBatch SpriteBatch { get; set; }        

        public OpenColGame() {
            Window.Title = "OpenCol Game";
            Window.Position = new Point(100, 100);

            Content.RootDirectory = "content";

            Graphics = new GraphicsDeviceManager(this);

            Graphics.ApplyChanges();
        }

        protected override void Initialize() {
            base.Initialize();

            SpriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void LoadContent() {
            base.LoadContent();
        }

        protected override void Draw(GameTime gameTime) {
            Graphics.GraphicsDevice.Clear(Color.Bisque);

            SpriteBatch.Begin();
            SpriteBatch.End();

            base.Draw(gameTime);
        }

        protected override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }
    }
}