namespace OpenCol.Client {

    using OpenCol.Logic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OpenColGame : Game {

        public GraphicsDeviceManager Graphics { get; private set; }

        protected KeyboardHandler Keyboard { get; private set; }

        protected RenderHandler HeightRenderer { get; private set; }
        protected RenderHandler MoistureRenderer { get; private set; }
        protected RenderHandler TemperatureRenderer { get; private set; }


        /// 0 - Height
        /// 1 - Temperature
        /// 2 - Moisture
        protected int MapToRender { get; private set; }


        public OpenColGame() {
            Window.Title = "OpenCol Game";
            Window.Position = new Point(100, 100);

            Content.RootDirectory = "content";

            Graphics = new GraphicsDeviceManager(this);
            Graphics.PreferredBackBufferHeight = 800;
            Graphics.PreferredBackBufferWidth = 900;

            Graphics.ApplyChanges();


            // 
            HeightRenderer = new RenderHandler(Graphics);
            TemperatureRenderer = new RenderHandler(Graphics);
            MoistureRenderer = new RenderHandler(Graphics);
            MapToRender = 2;

            // User interaction
            Keyboard = new KeyboardHandler();
            Keyboard.KeyDown += (keys) => {
                
                if(keys.Contains(Keys.Q)) {
                    MapToRender = 0;
                    System.Console.WriteLine("Change to height view.");
                }
                if(keys.Contains(Keys.W)) {
                    MapToRender = 1;
                    System.Console.WriteLine("Change to temperature view.");
                }
                if(keys.Contains(Keys.E)) {
                    MapToRender = 2;   
                    System.Console.WriteLine("Change to moisture view.");
                }

            };
        }

        protected override void Initialize() {
            base.Initialize();

            HeightRenderer.Initialize();
            TemperatureRenderer.Initialize();
            MoistureRenderer.Initialize();
        }

        protected override void LoadContent() {
            base.LoadContent();

            var worldBuilder = new WorldBuilder();
            var world = worldBuilder.Build(new WorldDefinition(56, 70));
            for(var x = 0; x < world.Size.Width; x++) {
                for(var y = 0; y < world.Size.Height; y++) {
                    var data = world.Get(x, y);
                    var heightColor = Color.Lerp(Color.White, Color.Black, data.Height);
                    var temperatureColor = Color.Lerp(Color.Blue, Color.Red, data.Temperature);
                    var moistureColor = Color.Lerp(Color.Yellow, Color.Green, data.Moisture);
                    
                    HeightRenderer.Register(new TileControl(new Vector2(x * 8, y * 8), heightColor));
                    TemperatureRenderer.Register(new TileControl(new Vector2(x * 8, y * 8), temperatureColor));
                    MoistureRenderer.Register(new TileControl(new Vector2(x * 8, y * 8), moistureColor));
                }
            }
        }

        protected override void Draw(GameTime gameTime) {
            Graphics.GraphicsDevice.Clear(Color.Black);

            if(MapToRender == 0)
                HeightRenderer.Draw(gameTime);
            else if(MapToRender == 1)
                TemperatureRenderer.Draw(gameTime);
            else if(MapToRender == 2)
                MoistureRenderer.Draw(gameTime);

            base.Draw(gameTime);
        }

        protected override void Update(GameTime gameTime) {
            Keyboard.Update(gameTime);

            base.Update(gameTime);
        }
    }
}