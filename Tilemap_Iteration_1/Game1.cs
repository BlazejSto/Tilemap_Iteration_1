using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1.Effects;
using TileMap_Prototype.Tilemap;

namespace Tilemap_Iteration_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Map map;

        private Tile[,] tileArray = new Tile[10, 10];
        private char[,] tileValuesArray;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.PreferredBackBufferWidth = 1200;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            map = new Map();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Tiles.Content = Content;
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            map.Generate(new int[,] {

            { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            { 3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            { 3,2,0,0,0,0,0,0,0,0,0,0,2,2,2,0,0,0},
            { 3,3,2,2,2,0,0,0,0,2,2,2,3,3,3,2,0,0},
            { 3,3,0,0,0,0,0,0,2,3,3,3,3,3,3,3,2,0},
            { 3,0,0,0,2,2,2,2,3,3,3,3,3,3,3,3,3,2},
            { 3,2,2,2,3,3,3,3,3,3,3,3,3,3,3,3,3,3},
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
        }, 64);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            map.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}