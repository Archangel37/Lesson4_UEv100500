using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Shapes
{
    internal interface IRender
    {
        /// <summary>
        ///     Обозначен метод отрисовки в интерфейсе
        /// </summary>
        /// <param name="shapes"></param>
        /// <param name="g"></param>
        void Draw(IEnumerable<IShape> shapes, Graphics g);

        /// <summary>
        ///     Поставить пиксель (на самом деле лишний тут вроде)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        void SetPixel(int x, int y, Color color, Graphics g);

        /// <summary>
        ///     Подсчёт фреймов (тоже пока лишнее, да ещё на длинной дистанции может переполниться при == int.Max+1)
        /// </summary>
        int Frame { get; }
    }
}
