using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.IO;

namespace Overactive
{
    /// <summary>
    /// working title: The boy with the green blanket
    /// This is the main type for your game
    /// wow
    /// </summary>
    public class Overactive : Microsoft.Xna.Framework.Game
    {
       private GraphicsDeviceManager graphics;
       private SpriteBatch spriteBatch;

       private Texture2D winOverlay;
       private Texture2D diedOverlay;
       private Texture2D loseOverlay;


       private int levelIndex = -1;
       private Level level;

       private KeyboardState keyboardState;
       
      

       private const int numberOfLevels = 29;


        public Overactive()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);


            // Load overlays here see lines 33-35 in example
           // LoadNextLevel();


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            HandleInput();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }


        private void HandleInput() { 
            //Keyboard input
            keyboardState = Keyboard.GetState();

            //exit game when esc is hit
            if (keyboardState.IsKeyDown(Keys.Escape)) {
                Exit();
            //will need to update this so that instead of just quitting it brings up a menu asking if you want to quit

            }

        
        
        
        }

        private void LoadNextLevel() { 
        //move on to the next level
            levelIndex = (levelIndex + 1) % numberOfLevels;

        //Unload current level
            if (level != null)
                level.Dispose();

        //Load next level content
        //Levels need to be labeled with numbers
            /* This needs to be uncommented when Level.cs is finished, to have a proper method with 3 input variables
             * */
          //  string levelPath = string.Format("Content/Levels/{0}.txt", levelIndex);
           // using (Stream fileStream = TitleContainer.OpenStream(levelPath))
             //   level = new Level(Services, fileStream, levelIndex);


        
        
        
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

    }
}
