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


namespace XNARPGFFFLibrary
{
    public class InputManager : Microsoft.Xna.Framework.GameComponent
    {
        #region Keyboard Field Region

        static KeyboardState keyboardState;
        static KeyboardState lastKeyboardState;

        #endregion

        #region Keyboard Property Region

        public static KeyboardState KeyboardState
        {
            get { return keyboardState; }
        }

        public static KeyboardState LastKeyboardState
        {
            get { return lastKeyboardState; }
        }

        #endregion

        #region Constructor Region
        
        public InputManager(Game game)
            : base(game)
        {
            keyboardState = Keyboard.GetState();
        }

        #endregion

        #region XNA Methods

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            lastKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();
            base.Update(gameTime);
        }

        #endregion

        #region General Method Region

        public static void AntiStateSpillOver()
        {
            lastKeyboardState = keyboardState;
        }

        #endregion

        #region Keyboard Region

        public static bool KeyReleased(Keys key)
        {
            return (keyboardState.IsKeyUp(key) && lastKeyboardState.IsKeyDown(key));
        }

        public static bool KeyPressed(Keys key)
        {
            return (keyboardState.IsKeyDown(key) && lastKeyboardState.IsKeyUp(key));
        }

        public static bool KeyDown(Keys key)
        {
            return keyboardState.IsKeyDown(key);
        }

        #endregion
    }
}