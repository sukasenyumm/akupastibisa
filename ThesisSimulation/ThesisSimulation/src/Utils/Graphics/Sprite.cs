﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ThesisSimulation.src.Utils.Graphics
{
    class Sprite
    {
        //The size of the Sprite
        public Rectangle Size;

        //Used to size the Sprite up or down from the original image
        public float Scale = 1.0f;

        //The current position of the Sprite
        public Vector2 Position = new Vector2(0,0);
        
        //The texture object used when drawing the sprite
        private Texture2D mSpriteTexture;

        //Load the texture for the sprite using the Content Pipeline
        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {
            mSpriteTexture = theContentManager.Load<Texture2D>(theAssetName);
            Size = new Rectangle(0, 0, (int)(mSpriteTexture.Width * Scale), (int)(mSpriteTexture.Height * Scale));
        }
        //Draw the sprite to the screen
        public void Draw(SpriteBatch theSpriteBatch)
        {

            theSpriteBatch.Draw(mSpriteTexture, Position,

                new Rectangle(0, 0, mSpriteTexture.Width, mSpriteTexture.Height), Color.White,

                0.0f, Vector2.Zero, Scale, SpriteEffects.None, 0);

        }
    }
}

