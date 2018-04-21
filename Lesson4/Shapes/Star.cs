using System;
using System.Drawing;

namespace Lesson4.Shapes
{
    /// <summary>
    ///     Класс звёзд
    /// </summary>
    internal class Star : Shape
    {
        /// <summary>
        ///     Конструктор звезды с N-конечностями
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="h"></param>
        /// <param name="tails"></param>
        /// <param name="innerRadius"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        public Star(int x, int y, int h, int tails, int innerRadius, Color color, Graphics g) : base(x, y, h, color, g)
        {
            this.color = color;
            if (innerRadius < H)
                this.innerRadius = innerRadius;
            else this.innerRadius = H / 2;

            this.tails = tails;
        }

        /// <summary>
        ///     "Хвосты" - количество вершин
        /// </summary>
        public int tails { get; set; }

        /// <summary>
        ///     внутренний радиус
        /// </summary>
        public int innerRadius { get; set; }

        /// <summary>
        ///     Отрисовка N-конечной звезды
        /// </summary>
        /// <param name="render"></param>
        public override void Draw(IRender render)
        {
            double alpha = 0; // поворот

            PointF[] points = new PointF[2 * tails + 1];
            double a = alpha, da = Math.PI / tails;
            for (int k = 0; k < 2 * tails + 1; k++)
            {
                var l = k % 2 == 0 ? innerRadius : H;
                points[k] = new PointF((float) (X + l * Math.Cos(a)), (float) (Y + l * Math.Sin(a)));
                a += da;
            }

            g.DrawLines(new Pen(color), points);
        }
    }
}