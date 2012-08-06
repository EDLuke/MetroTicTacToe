using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TicTacToe
{
    // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // Class Player - manages and displays the player name and score
    // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    
    class Player
    {
        private string _name;
        private Vector2 _position;
        private int _score;
        int _viewportWidth;
        int _viewportHeight;
        private SpriteFont _font;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public void Initialize(ContentManager content, string name, float posX, float posY, int viewportWidth, int viewportHeight)
        {
            _score = 0;
            _font = content.Load<SpriteFont>("TicTacToeBuxtonSketch");
            _name = name;
            _position.X = posX;
            _position.Y = posY;
            _viewportWidth = viewportWidth;
            _viewportHeight = viewportHeight;
        }

        public void Update(int viewportWidth, int viewportHeight)
        {
            _viewportWidth = viewportWidth;
            _viewportHeight = viewportHeight;
        }

        public void Draw(SpriteBatch spriteBatch, double adjust)
        {
            _position.X = ((float)(adjust * _viewportWidth));
            _position.Y = ((float)(0.05 * _viewportHeight));

            // draw the player name and score
            spriteBatch.DrawString(_font, _name, new Vector2(_position.X, _position.Y), Color.Black);
            spriteBatch.DrawString(_font, _score.ToString(), new Vector2(_position.X, _position.Y + 30), Color.Black);
        }
    }
}
