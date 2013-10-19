using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace XNARPGFFFLibrary.Controls
{
    public class SelectableLabel : Control
    {
        #region Fields and Properties

        Color selectedColor = Color.Red;

        public Color SelectedColor
        {
            get { return selectedColor; }
            set { selectedColor = value; }
        }

        #endregion

        #region Constructor Region

        public SelectableLabel()
        {
            TabStop = true;
            hasFocus = false;
            Position = Vector2.Zero;
        }

        #endregion

        #region Various Methods

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (hasFocus)
            {
                spriteBatch.DrawString(SpriteFont, Text, Position, selectedColor);
            }
            else
            {
                spriteBatch.DrawString(SpriteFont, Text, Position, Color);
            }
        }

        #endregion
    }
}
