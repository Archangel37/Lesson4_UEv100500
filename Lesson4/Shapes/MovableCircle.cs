using System.Drawing;

namespace Lesson4.Shapes
{
    /// <summary>
    ///     Движущаяся окружность - она и окружность, и движущаяся (с) Кэп
    /// </summary>
    internal class MovableCircle : Circle, IMovable
    {
        /// <summary>
        ///     Конструктор движущейся окружности
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="h"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public MovableCircle(int x, int y, int h, Color color, Graphics g, int deltaX, int deltaY) : base(x, y, h,
            color, g)
        {
            X = x;
            Y = y;
            H = h;
            this.color = color;
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
        ///     Подвинуть окружность
        /// </summary>
        /// <param name="sh"></param>
        public void Move(Shape sh)
        {
            sh.X += deltaX;
            sh.Y += deltaY;
        }
    }
}