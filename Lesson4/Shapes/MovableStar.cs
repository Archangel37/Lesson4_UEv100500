using System.Drawing;

namespace Lesson4.Shapes
{
    /// <summary>
    ///     Движущаяся звезда
    /// </summary>
    internal class MovableStar : Star, IMovable
    {
        /// <summary>
        ///     Конструктор двигающейся звезды
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="h"></param>
        /// <param name="tails"></param>
        /// <param name="innerRadius"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public MovableStar(int x, int y, int h, int tails, int innerRadius, Color color, Graphics g, int deltaX,
            int deltaY) : base(x, y, h, tails, innerRadius, color, g)
        {
            X = x;
            Y = y;
            H = h;
            this.g = g;
            this.color = color;
            this.tails = tails;
            this.innerRadius = innerRadius;
            this.deltaX = deltaX;
            this.deltaY = deltaY;
            Move(this);
        }

        /// <summary>
        ///     Изменение по оси абсцисс
        /// </summary>
        public int deltaX { get; set; }

        /// <summary>
        ///     Изменение по оси ординат
        /// </summary>
        public int deltaY { get; set; }

        /// <summary>
        ///     Движение звезды
        /// </summary>
        /// <param name="sh"></param>
        public void Move(Shape sh)
        {
            sh.X += deltaX;
            sh.Y += deltaY;
        }
    }
}