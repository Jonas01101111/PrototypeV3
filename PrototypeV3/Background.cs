using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace PrototypeV3
{

    internal class Background : Sprite
    {
        int origemx = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width/2;
        int origemy = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height/2;

        public Background(Texture2D texture,Vector2 pos):base(texture,pos) 
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

           /* int mx=Mouse.GetState().X;
            int my=Mouse.GetState().Y;
            Debug.WriteLine(mx);
           */
        }

    }
}
