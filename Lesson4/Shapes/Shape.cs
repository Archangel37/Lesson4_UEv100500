using System.Drawing;

namespace Lesson4.Shapes
{
    /// <summary>
    ///     Абстрактный класс фигуры
    /// </summary>
    internal abstract class Shape : IShape
    {
        /// <summary>
        ///     Конструктор класса фигур
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="h"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        internal Shape(int x, int y, int h, Color color, Graphics g)
        {
            X = x;
            Y = y;
            H = h;
            this.g = g;
            this.color = color;
        }

        /// <summary>
        ///     Цвет фигуры
        /// </summary>
        public Color color { get; set; }

        /// <summary>
        ///     Абсцисса
        /// </summary>
        public int X { get; set; }

        /// <summary>
        ///     Ордината
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        ///     Высота от центра (полувысота/радиус)
        /// </summary>
        public int H { get; set; }

        /// <summary>
        ///     На чём рисуем
        /// </summary>
        public Graphics g { get; set; }

        /// <summary>
        ///     С помощью чего рисуем
        /// </summary>
        /// <param name="render">интерфейс рендера</param>
        public abstract void Draw(IRender render);
    }
}