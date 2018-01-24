namespace OpenCol.Client {

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class OpenColGame : Game {

        public GraphicsDeviceManager Graphics { get; private set; }

        protected KeyboardHandler Keyboard { get; private set; }

        protected RenderHandler Renderer { get; private set; }

        public OpenColGame() {
            Window.Title = "OpenCol Game";
            Window.Position = new Point(100, 100);

            Content.RootDirectory = "content";

            Graphics = new GraphicsDeviceManager(this);

            Graphics.ApplyChanges();


            // 
            Renderer = new RenderHandler(Graphics);


            // User interaction
            Keyboard = new KeyboardHandler();
        }

        protected override void Initialize() {
            base.Initialize();

            Renderer.Initialize();
        }

        protected override void LoadContent() {
            base.LoadContent();

            // TODO: Load all tipes of tiles that will be drawn in the screen.
        }

        protected override void Draw(GameTime gameTime) {
            Graphics.GraphicsDevice.Clear(Color.Bisque);

            Renderer.Draw(gameTime);

            base.Draw(gameTime);
        }

        protected override void Update(GameTime gameTime) {
            Keyboard.Update(gameTime);

            base.Update(gameTime);
        }
    }
}