﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XNARPGFFFLibrary.Controls
{
    public class Label : Control
    {
        #region Constructor Region

        public Label()
        {
            tabStop = false;
        }

        #endregion

        #region Various Methods

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(SpriteFont, Text, Position, Color);
        }

        #endregion
    }
}
