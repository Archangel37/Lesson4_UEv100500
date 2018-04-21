using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using Lesson4.Shapes;

namespace Lesson4
{
    /// <summary>
    ///     Класс отрисовки
    /// </summary>
    internal class Render : IRender
    {
        /// <summary>
        ///     Канвас, на который переносим изображения
        /// </summary>
        public Graphics g { get; set; }
        /// <summary>
        ///     С виду пока бесполезный фрейм из примера
        /// </summary>
        public int Frame { get; private set; }

        /// <summary>
        ///     Метод постановки пикселя
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        public void SetPixel(int x, int y, Color color, Graphics g)
        {
            if (x < 0 || y < 0) return;

            g.FillRectangle(new SolidBrush(color), x, y, 1, 1);
        }

        /// <summary>
        ///     Метод отрисовки
        /// </summary>
        /// <param name="shapes"></param>
        /// <param name="g"></param>
        public void Draw(IEnumerable<IShape> shapes, Graphics g)
        {
            PrepareEnv(g);
            while (true)
            {
                foreach (var shape in shapes)
                {
                    if (shape is IMovable)
                    {
                        ((IMovable) shape).Move((Shape) shape);
                        shape.X = shape.X >= MainFormG.MaxX ? 0 : shape.X < 0 ? MainFormG.MaxX : shape.X;
                        shape.Y = shape.Y >= MainFormG.MaxY ? 0 : shape.Y < 0 ? MainFormG.MaxY : shape.Y;
                    }

                    shape.Draw(this);
                }

                Wait();
                Clear(g);
                //похоже, для такой реализации - бесполезная переменная Frame - да ещё и на длинной дистанции 
                //надо проверять не достигнуто ли 
                //максимальное значение
                Frame++;
            }
        }

        /// <summary>
        ///     Подготовка канваса
        /// </summary>
        /// <param name="g"></param>
        private void PrepareEnv(Graphics g)
        {
            g.Clear(Color.White);
        }

        /// <summary>
        ///     Задержка, ожидание
        /// </summary>
        private void Wait()
        {
            Thread.Sleep(100);
        }

        /// <summary>
        ///     Очистка канваса
        /// </summary>
        /// <param name="g"></param>
        private void Clear(Graphics g)
        {
            g.Clear(Color.White);
        }
    }
}