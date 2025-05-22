using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PrototypeV3
{
    internal class Sprite
    {
        public Texture2D texture;
        public Vector2 pos;

        public Rectangle Rect
        {
            get
            {
                return new Rectangle(
                    (int)pos.X,
                    (int)pos.Y,
                    texture.Width,
                    texture.Height
                    );
            }
        }

        public Sprite( Texture2D texture,Vector2 pos)
        {
            this.texture = texture;
            this.pos = pos;
        }

        public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(SpriteBatch spriteBatch) 
        {
            spriteBatch.Draw(texture, Rect, Color.White);
        }
    }
}
