using System.Drawing;

namespace Lesson4.Shapes
{
    /// <summary>
    ///     Окружность
    /// </summary>
    internal class Circle : Shape
    {
        /// <summary>
        ///     Конструктор окружности
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="h"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        public Circle(int x, int y, int h, Color color, Graphics g) : base(x, y, h, color, g)
        {
            this.color = color;
        }

        /// <summary>
        ///     Отрисовка окружности
        /// </summary>
        /// <param name="render"></param>
        public override void Draw(IRender render)
        {
            g.DrawArc(new Pen(color), new Rectangle(X - H, Y - H, 2 * H, 2 * H), 0, 360);
        }
    }
}