namespace OpenCol {

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyboardHandler {

        // Events
        public Action<IList<Keys>> KeyDown;
        public Action<IList<Keys>> KeyUp;

        // Properties
        protected Keys[] LastKeysPressed { get; set; }


        public KeyboardHandler() {
            LastKeysPressed = new Keys[0];
        }


        public virtual void Update(GameTime gameTime) {
            
            var state = Keyboard.GetState();
            var currentKeysPressed = state.GetPressedKeys();


            // KeyDown process
            var newKeysPressed = currentKeysPressed.Where(k => !LastKeysPressed.Contains(k)).ToList();

            if(null != KeyDown)
                KeyDown(newKeysPressed);


            // KeyUp process
            var oldKeysPressed = LastKeysPressed.Where(k => !currentKeysPressed.Contains(k)).ToList();

            if(null != KeyUp)
                KeyUp(oldKeysPressed);


            LastKeysPressed = currentKeysPressed;
        }
    }
}