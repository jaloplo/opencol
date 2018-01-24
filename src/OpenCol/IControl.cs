namespace OpenCol {

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IControl {
        
        void Draw(SpriteBatch batch, GameTime gameTime);
    }
}