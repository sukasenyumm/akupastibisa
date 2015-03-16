using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThesisSimulation.src.UIStates.Interfaces;
using ThesisSimulation.src.Utils.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace ThesisSimulation.src.UIStates.States
{
    public class BeginState:IStateBase
    {
        private Game1 manager;
        private Texture2D titleTex;
        private Texture2D getdataTex;
        private Texture2D recognizeTex;
        private Texture2D trainTex;
        private Texture2D creditsTex;
        private Texture2D exitTex;
        private GameObject lblTitle;
        private GameObject btnGetdata;
        private GameObject btnTrain;
        private GameObject btnRecognize;
        private GameObject btnCredits;
        private GameObject btnExit;
        public BeginState( Game1 managerRef)
        {
            manager = managerRef;
            LoadContent();
        }
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content only for this state.
        /// </summary>
        public void LoadContent()
        {
            // TODO: use this.Content to load your game content here
            titleTex = manager.Content.Load<Texture2D>("title");
            getdataTex = manager.Content.Load<Texture2D>("getdata");
            trainTex = manager.Content.Load<Texture2D>("train");
            recognizeTex = manager.Content.Load<Texture2D>("recognize");
            creditsTex = manager.Content.Load<Texture2D>("credits");
            exitTex = manager.Content.Load<Texture2D>("exit");
            lblTitle = new GameObject(titleTex, Vector2.Zero);
            btnGetdata = new GameObject(getdataTex, Vector2.Zero);
            btnTrain = new GameObject(trainTex, Vector2.Zero);
            btnRecognize = new GameObject(recognizeTex, Vector2.Zero);
            btnCredits = new GameObject(creditsTex, Vector2.Zero);
            btnExit = new GameObject(exitTex, Vector2.Zero);
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                manager.Exit();

            // TODO: Add your update logic here

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            manager.spriteBatch.Begin();
            lblTitle.Draw(manager.spriteBatch, 1f);
            btnGetdata.Draw(manager.spriteBatch, 1f);
            btnTrain.Draw(manager.spriteBatch, 1f);
            btnRecognize.Draw(manager.spriteBatch, 1f);
            btnCredits.Draw(manager.spriteBatch, 1f);
            btnExit.Draw(manager.spriteBatch, 1f);

            lblTitle.ValPosition = new Vector2(manager.graphics.PreferredBackBufferWidth / 2 - lblTitle.getTexture().Width / 2,
            manager.graphics.PreferredBackBufferHeight / 8);
            btnGetdata.ValPosition = new Vector2(manager.graphics.PreferredBackBufferWidth / 2 - btnGetdata.getTexture().Width / 2,
            lblTitle.Position.Y + lblTitle.getTexture().Height + 60);
            btnTrain.ValPosition = new Vector2(manager.graphics.PreferredBackBufferWidth / 2 - btnTrain.getTexture().Width / 2,
            btnGetdata.Position.Y + btnGetdata.getTexture().Height + 20);
            btnRecognize.ValPosition = new Vector2(manager.graphics.PreferredBackBufferWidth / 2 - btnRecognize.getTexture().Width / 2,
            btnTrain.Position.Y + btnTrain.getTexture().Height + 20);
            btnCredits.ValPosition = new Vector2(manager.graphics.PreferredBackBufferWidth / 2 - btnCredits.getTexture().Width / 2,
            btnRecognize.Position.Y + btnRecognize.getTexture().Height + 20);
            btnExit.ValPosition = new Vector2(manager.graphics.PreferredBackBufferWidth - btnExit.getTexture().Width,0);

            manager.spriteBatch.End();
        }
        /// <summary>
        /// Destroy all object child on manager
        public void Destroy()
        {
            manager.spriteBatch.Dispose();
        }

    }
}
