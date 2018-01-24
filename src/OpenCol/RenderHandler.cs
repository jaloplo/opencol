namespace OpenCol {

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using System.Collections.Generic;

    public class RenderHandler {

        protected SpriteBatch Batch { get; private set; }
        protected IList<IControl> Controls { get; private set; }
        protected GraphicsDeviceManager Graphics { get; private set; }


        public RenderHandler(GraphicsDeviceManager graphics) {
            Controls = new List<IControl>();
            Graphics = graphics;
        }


        public virtual void Initialize() {
            Batch = new SpriteBatch(Graphics.GraphicsDevice);
        }

        public virtual void Draw(GameTime gameTime) {
            Batch.Begin(SpriteSortMode.BackToFront, null, null, null, null, null, null);

            foreach(IControl control in Controls) {
                control.Draw(Batch, gameTime);
            }
            
            Batch.End();
        }

        public virtual void Register(IControl control) {
            Controls.Add(control);
        }
    }
}