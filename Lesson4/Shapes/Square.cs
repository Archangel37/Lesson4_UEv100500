using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Shapes
{
    /// <summary>
    ///     Класс квадрата
    /// </summary>
    class Square: Shape
    {
        /// <summary>
        ///     Конструктор квадрата
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="h"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        public Square(int x, int y, int h, Color color, Graphics g) : base(x, y, h, color, g)
        {
            this.color = color;
        }
        /// <summary>
        ///     Отрисовка квадрата
        /// </summary>
        /// <param name="render"></param>
        public override void Draw(IRender render)
        {
            g.DrawRectangle(new Pen(color), new Rectangle(X-H,Y-H,2*H,2*H) );
        }
    }
}
