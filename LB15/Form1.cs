using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool flag = false;

        private void MyDraw(Graphics g, int N, int x, int y)
        {
            if (N == 0)
                return;
            else
            {
                // Отрисовка прямоугольника
                g.DrawEllipse(new Pen(Brushes.Blue, 7), x, y, 70, 70);
                // Увеличение x и y на 50
                x += 70;
                y += 70;
                N--;
                // Рекурсивный вызов с новыми параметрами
                MyDraw(g, N, x, y);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Первый вызов метода и вход в рекурсию
            MyDraw(g, 7, 50, 50);
            //// Включаем таймер
            //timer1.Enabled = true;
            //// Устанавливаем flag в значение true
            //flag = true;
            //// Организуем бесконечный цикл
            //while (flag) ;
            //// Выключаем таймер после выхода из цикла
            //timer1.Enabled = false;
        }

        // Обработчик тика таймера
        private void timer1_Tick_1(object sender,
        EventArgs e)
        {
            // Сбрасываем flag в значение false
            flag = false;
        }
    }
}
