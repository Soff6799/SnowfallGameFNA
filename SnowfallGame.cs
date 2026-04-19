using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using SnowfallGameFNA.Constants;
using SnowfallGameFNA.Models;

namespace SnowfallGameFNA;

/// <summary>
/// Основной класс игры, управляющий всей логикой и отрисовкой симуляции снегопада.
/// Наследует функциональность от базового класса Game фреймворка FNA.
/// </summary>
    public class SnowfallGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D backgroundTexture;
        private Texture2D snowflakeTexture;
        private SnowFlakeModels[] snowflakes;
        private Random random = new();

        /// <summary>
        /// Инициализирует новый экземпляр класса SnowfallGame.
        /// Настраивает графическое устройство, устанавливает размеры экрана и корневую директорию для контента.
        /// </summary>
        public SnowfallGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = SnowfallGameConstants.ScreenWidth;
            graphics.PreferredBackBufferHeight = SnowfallGameConstants.ScreenHeight;
            graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            snowflakes = new SnowFlakeModels[SnowfallGameConstants.SnowflakeCount];
            for (var i = 0; i < SnowfallGameConstants.SnowflakeCount; i++)
            {
                var x = random.Next(0, graphics.PreferredBackBufferWidth);
                var y = random.Next(0, SnowfallGameConstants.ScreenHeight);
                var size = random.Next(SnowfallGameConstants.MinSize, SnowfallGameConstants.MaxSize);
                var speed = size / SnowfallGameConstants.SpeedDivisor;
                snowflakes[i] = new SnowFlakeModels(x, y, size, speed);
            }
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundTexture = Content.Load<Texture2D>("villageSNOW");
            snowflakeTexture = Content.Load<Texture2D>("icon-snowflake");
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().GetPressedKeys().Length > 0)
            {
                Exit();
            }
            var screenHeight = SnowfallGameConstants.ScreenHeight;
            var screenWidth = SnowfallGameConstants.ScreenWidth;
            for (var i = 0; i < snowflakes.Length; i++)
            {
                snowflakes[i].Y += snowflakes[i].Speed;
                if (snowflakes[i].Y > screenHeight)
                {
                    var newSize = random.Next(SnowfallGameConstants.MinSize, SnowfallGameConstants.MaxSize);
                    snowflakes[i].Y = -newSize;
                    snowflakes[i].X = random.Next(0, screenWidth);
                    snowflakes[i].Size = newSize;
                    snowflakes[i].Speed = newSize / SnowfallGameConstants.SpeedDivisor;
                }
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundTexture, GraphicsDevice.Viewport.Bounds, Color.White);
            foreach (var flake in snowflakes)
            {
                Rectangle destRect = new Rectangle((int)flake.X, (int)flake.Y, flake.Size, flake.Size);
                spriteBatch.Draw(snowflakeTexture, destRect, Color.White);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
