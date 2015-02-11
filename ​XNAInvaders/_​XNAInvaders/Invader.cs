using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XNAInvaders
{
    class Invader
    {
        Vector2 position;
        Vector2 velocity;
        Texture2D texture;

        public Invader theInvader;

        public Invader() {
            texture = Global.content.Load<Texture2D>("red_invader");

            Init();
        }

        void Init()
        { 
        
        }

        void update()
        { }
        void Draw() {
            Global.spriteBatch.Draw(texture, position, Color.White);
            theInvader.Draw();
        }
    }
}
