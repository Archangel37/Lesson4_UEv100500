using System.Drawing;

namespace Lesson4.Shapes
{
    internal interface IShape
    {
        /// <summary>
        ///     Абсцисса фигуры
        /// </summary>
        int X { get; set; }
        /// <summary>
        ///     Ордината фигуры
        /// </summary>
        int Y { get; set; }

        /// <summary>
        ///     Высота от центра фигуры!!! для окружности будет радиусом
        /// </summary>
        int H { get; set; }
        /// <summary>
        ///     Используемый канвас
        /// </summary>
        Graphics g { get; set; }
        /// <summary>
        ///     Ссылка на необходимость метода рисования
        /// </summary>
        /// <param name="render"></param>
        void Draw(IRender render);
    }
}