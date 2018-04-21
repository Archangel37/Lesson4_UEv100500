using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson4.Shapes;

namespace Lesson4
{
    public partial class MainFormG : Form
    {
        public MainFormG()
        {
            InitializeComponent();
            MaxX = pictureBox.Size.Width;
            MaxY = pictureBox.Size.Height;
        }

        /// <summary>
        ///     Ширина канваса
        /// </summary>
        public static int MaxX;
        /// <summary>
        ///     Высота канваса
        /// </summary>
        public static int MaxY;


        private async void Draw_btn_Click(object sender, EventArgs e)
        {
            // чтобы пользователь не нажимал, пока выполняется команда
            Draw_btn.Enabled = false;

            try
            {
                // запускаем в отдельном потоке
                await Task.Run(new Action(DoCommand));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Draw_btn.Enabled = true; // кнопка снова будет доступна как доработаю
            }
        }


        private void DoCommand()
        {
            //чую, что формы можно упростить и делать без 'g', но пока не понимаю как..
            var shapes = new List<IShape>();
            Graphics g = pictureBox.CreateGraphics();
            shapes.Add(new Circle(10, 10, 10, Color.Aqua, g));
            //shapes.Add(new Circle(34, 10, 5, Color.Green, g));
            //shapes.Add(new Circle(340, 200, 50, Color.Red, g));
            shapes.Add(new Circle(0, 0, 300, Color.Chartreuse, g));
            shapes.Add(new Square(200, 200, 80, Color.BlueViolet, g));
            shapes.Add(new Star(200, 200, 100, 5, 50, Color.DarkGoldenrod, g));
            shapes.Add(new MovableStar(200, 200, 100, 20, 50, Color.DeepPink, g, 10, 10));
            shapes.Add(new MovableCircle(500,500,30,Color.Cyan, g,0,-10));
            shapes.Add(new MovableStar(400, 200, 40, 40, 10, Color.GreenYellow, g, 0, 10));
            shapes.Add(new MovableSqare(450,450,50,Color.Crimson,g, 5,0));


            var engine = new Render();
            engine.Draw(shapes, g);
            g.Dispose();
        }
    }
}