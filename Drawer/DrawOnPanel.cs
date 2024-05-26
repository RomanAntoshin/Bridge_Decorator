using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class DrawOnPanel: IDrawer
    {
        private Panel panel;
        private Graphics g;
        public DrawOnPanel(Panel panel)
        {
            this.panel = panel;
            g = panel.CreateGraphics();
        }
        public void DrawCell(int row, int column, int step=0)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(30 + 60 * (j+step), 30 + 60 * (i), 60, 60));
                }
            }
        }
        public void DrawCellBody(double data, int i, int j)
        {
            g.DrawString(data.ToString(), new Font("Arial", 14, FontStyle.Regular), new SolidBrush(Color.Black), 30 + 60 * (j), 30 + 60 * (i));
        }
        public void Draw(IMatrix matrix)
        {
            if (matrix.WithBorder == true)
                DrawCell(matrix.Row, matrix.Column);
            for (int i = 0; i < matrix.Row; i++)
                for (int j = 0; j < matrix.Column; j++)
                    if (matrix.NecessaryDraw(i, j))
                    {
                        DrawCellBody(matrix.GetElement(i, j), i, j);
                    }
        }
    }
}
