using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoICG
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        int m = 0;
        int xFinal = 0;
        int b = 0;
        int yFinal = 0;
        bool verifica = false; 

        public Form1()
        {
            InitializeComponent();
        }
        public void DesenharLinha(PaintEventArgs e)
        {
            Color cor = new Color();
            cor = Color.FromArgb(0, 0, 0);
            Pen caneta = new Pen(cor, 2);
            e.Graphics.DrawLine(caneta, 0, 540, 1920, 540);
            e.Graphics.DrawLine(caneta, 960, 0, 960, 1080);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DesenharLinha(e);
            if (verifica)
            {
                DesenharLinhaUsuario(e, y, yFinal, x, xFinal);
            }
            verifica = false;
            
        }

        public void DesenharLinhaUsuario(PaintEventArgs e, int yInicial, int yFinal, int xInicial, int xFinal)
        {
            Color cor = new Color();
            cor = Color.FromArgb(0, 0, 0);
            Pen caneta = new Pen(cor, 2);
            e.Graphics.DrawLine(caneta, xInicial+960,yInicial+540,xFinal+960,yFinal+540);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verifica = true;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            m = int.Parse(textBox3.Text);
            xFinal = int.Parse(textBox4.Text);
            b = int.Parse(textBox5.Text);
            yFinal = m * xFinal + b;

            y *= -1;
            yFinal *= -1;
            label6.Text = "yFinal = " + m + "*" + x + " + " + b;
            Invalidate();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
