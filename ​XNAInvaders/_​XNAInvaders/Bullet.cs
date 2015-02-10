using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XNAInvaders
{
    class Bullet
    {
        public Boolean isFired = false;
        public Vector2 position;
        public Vector2 velocity;
        public Texture2D texture;
        public float speed;

        public Bullet()
        {
            texture = Global.content.Load<Texture2D>("bullet");
            position = new Vector2();
            velocity = new Vector2();
            Init();
        }

        public void Init()
        {
            position.X = -1000;
            speed = -5;
            isFired = false;
        }

        public void Update()
        {
            if (isFired)
            {
                velocity.Y = speed;
            }

            position.Y += velocity.Y;

            if (position.Y < 0)
            {
                isFired = false;
            }
        }

        public void Draw()
        {
            Global.spriteBatch.Draw(texture, position, Color.White);
        }

//        public Boolean OverlapsInvader(Invader anInvader)
//        {
//        }

    }
}
