using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XNAInvaders
{
    class Mothership
    {
        public Vector2 position;
        public Vector2 velocity;

        public Texture2D texture;

        public Mothership()
        {
            texture = Global.content.Load<Texture2D>("enemy_ship");
            position = new Vector2();
            velocity = new Vector2();
        }

        public void Init()
        {
            position.X = 0;
            position.Y = texture.Height / 2;
            velocity.X = 5;
        }

        public void Update()
        {
            if (position.X + texture.Width > Global.width || position.X < 0)
            {
                velocity.X = -velocity.X;
            }

            position.X += velocity.X;
        }

        public void Draw()
        {
            Global.spriteBatch.Draw(texture, position, Color.White);
        }
    }
}