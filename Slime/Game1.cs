using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoGameLibrary;

namespace Slime
{
	public class Game1 : Core
	{
		private Texture2D _logo;

		public Game1() : base("Dungeon slime", 1920, 1080, false)
		{
			//_graphics = new GraphicsDeviceManager(this);
			//Content.RootDirectory = "Content";
			//IsMouseVisible = true;
		}

		/*protected override void Initialize()
			{
		// TODO: Add your initialization logic here

		base.Initialize();
		}*/

		protected override void LoadContent()
		{
			base.LoadContent();
			// TODO: use this.Content to load your game content here
			_logo = Content.Load<Texture2D>("images/logo");
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

			SpriteBatch.Begin();

			SpriteBatch.Draw(_logo, new Vector2(Window.ClientBounds.Width, Window.ClientBounds.Height), Color.White);

			SpriteBatch.End();
			base.Draw(gameTime);
		}
	}
}
