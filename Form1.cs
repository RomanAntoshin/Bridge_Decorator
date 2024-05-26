using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IMatrix m;
        IDrawer drawer;
        IDrawer drawer1;
        RenumberingDecorator decor;
        private void button_ordinary_Click(object sender, EventArgs e)
        {
            m = new Ordinary_Matrix(3, 3);
            decor = new RenumberingDecorator(m);
            Preparation();
            Initiator.Fill_Matrix(m, 6, 10);
            if (checkBox1.Checked)
                m.WithBorder = true;
            else
                m.WithBorder = false;
            m.SetDrawer(drawer);
            m.Draw();
            m.SetDrawer(drawer1);
            m.Draw();
        }

        private void Sparse_Click(object sender, EventArgs e)
        {
            m = new Sparse_Matrix(3, 3);
            decor = new RenumberingDecorator(m);
            Preparation();
            Initiator.Fill_Matrix(m, 6, 10);
            if (checkBox1.Checked)
                m.WithBorder = true;
            else
                m.WithBorder = false;
            m.SetDrawer(drawer);
            m.Draw();
            m.SetDrawer(drawer1);
            m.Draw();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Preparation();
            if (m == null)
                return;
            IDrawer drawer = new DrawOnPanel(panel1);
            IDrawer drawer1 = new DrawOnConsole(richTextBox1, 3, 3);
            if (checkBox1.Checked)
            {
                m.WithBorder = true;
                m.SetDrawer(drawer);
                decor.Draw();
                m.SetDrawer(drawer1);
                decor.Draw();
            }
            else
            {
                m.WithBorder = false;
                m.SetDrawer(drawer);
                decor.Draw();
                m.SetDrawer(drawer1);
                decor.Draw();
            }
        }

        private void Renume_Click(object sender, EventArgs e)
        {
            Preparation();
            //RenumberingDecorator decor = new RenumberingDecorator(m);
            decor.RenumRow();
            decor.RenumColumn();
            m.SetDrawer(drawer);
            decor.Draw();
            m.SetDrawer(drawer1);
            decor.Draw();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            Preparation();
            IDrawer drawer = new DrawOnPanel(panel1);
            IDrawer drawer1 = new DrawOnConsole(richTextBox1, 3, 3);
            m.SetDrawer(drawer);
            m.Draw();
            m.SetDrawer(drawer1);
            m.Draw();
        }
        private void Preparation()
        {
            if(m!=null)
            {
                Renume.Enabled = true;
                Restore.Enabled = true;
                //decor = new RenumberingDecorator(m);
            }
            drawer = new DrawOnPanel(panel1);
            drawer1 = new DrawOnConsole(richTextBox1, m.Row, m.Column);
            panel1.Invalidate();
            panel1.Update();
            richTextBox1.Clear();

        }
    }
}
