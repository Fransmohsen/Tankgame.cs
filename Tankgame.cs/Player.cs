using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankgame.cs
{
    class Player
    {

        protected Texture2D texture;
        protected Vector2 vector;
        protected Vector2 speed;
        protected float angle = 0;
        protected const float acc = 7f;
        protected const float maxSpeed = 1;
        protected bool accelerate;
       

        public Player(Texture2D texture, float X, float Y, float speedX, float speedY)
        {
            this.texture = texture;
            this.vector.X = X;
            this.vector.Y = Y;
            this.speed.X = speedX;
            this.speed.Y = speedY;

        }

        public void Update(GameWindow window)
        {

            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.D))
            {
                angle -= 0.1f;
            }
            if (keyboardState.IsKeyDown(Keys.A))
            {
                angle += 0.1f;
            }
            var direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(0) - angle), -(float)Math.Sin(MathHelper.ToRadians(0) - angle));

            if (keyboardState.IsKeyDown(Keys.W))
            {

                vector += direction * speed;

                //speed.X += maxSpeed * (float)Math.Cos(angle);
                // speed.Y += maxSpeed * (float)Math.Sin(angle);
                //if (speed.Length() > maxSpeed)
                // {
                //speed.Normalize();
                // speed *= speed;
                // }

                // vector += speed;

            }
        
          




            if (vector.X < 0)
                vector.X = 0;

            if (vector.X > window.ClientBounds.Width - texture.Width)
                vector.X = window.ClientBounds.Width - texture.Width;

            if (vector.Y < 0)
                vector.Y = 0;

            if (vector.Y > window.ClientBounds.Height - texture.Height)
                vector.Y = window.ClientBounds.Height - texture.Height;

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, null, Color.White, angle + (float)Math.PI / 2,
        new Vector2(texture.Width / 2, texture.Height / 2), 1.0f, SpriteEffects.None, 0);



        }
    }

    class Player1 : Player
    {

        public Player1(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y, speedX, speedY)
        {

        }

        public void Update(GameWindow window)
        {


            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.A))
            {
                angle -= 0.1f;
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                angle += 0.1f;
            }
            var direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(0) - angle), -(float)Math.Sin(MathHelper.ToRadians(0) - angle));
            if (keyboardState.IsKeyDown(Keys.W))
            {

                vector += direction * speed;
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {

                vector -= direction * speed;

                //speed.X += maxSpeed * (float)Math.Cos(angle);
                // speed.Y += maxSpeed * (float)Math.Sin(angle);
                //if (speed.Length() > maxSpeed)
                // {
                //speed.Normalize();
                // speed *= speed;
                // }

                // vector += speed;

            }
          

        }
    }


    class Player2 : Player
    {
        
        public Player2(Texture2D texture, float X, float Y, float speedX, float speedY):base(texture, X, Y, speedX, speedY)
        {

        }

        public void Update(GameWindow window)
        {


            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                angle -= 0.1f;
            }
            if (keyboardState.IsKeyDown(Keys.Right))
            {
                angle += 0.1f;
            }
            var direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(0) - angle), -(float)Math.Sin(MathHelper.ToRadians(0) - angle));
            if (keyboardState.IsKeyDown(Keys.Up))
            {

                vector += direction * speed;
            }
            if (keyboardState.IsKeyDown(Keys.Down))
            {

                vector -= direction * speed;
            }
            

        }
    }
    


}


