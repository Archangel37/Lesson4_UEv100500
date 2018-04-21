using System.Collections.Generic;
using System.Drawing;
using Lesson4.Shapes;

namespace Lesson4
{
    /// <summary>
    ///     Интерфейс передвижения
    /// </summary>
    internal interface IMovable
    {
        /// <summary>
        ///     Возможность передвижения
        /// </summary>
        void Move(Shape sh);
    }
}