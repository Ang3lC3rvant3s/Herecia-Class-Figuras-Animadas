using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirculosR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            if(cbAnimacion.Checked)
            {
                Random aleatorio = new Random();
                int r = aleatorio.Next(15, 50);
                int x, y;
                x = aleatorio.Next(0,panel1.Width - r);
                y = aleatorio.Next(0, panel1.Height - r);

                Point punto = new Point(y,x);
                Circulo circulo = new Circulo(r,punto);
                Task tarea = new Task(() => AnimarCirculo(circulo, new Vista(panel1)));
                tarea.Start();
            }

        }

        private void AnimarCirculo(Circulo circulo, Vista vista) 
        {
            vista.colorLapiz = Color.DarkRed;
            vista.mostrar_Circulo(circulo);
            bool sentido = true;
            while(true)
            {
              while(cbAnimacion.Checked)
              {
                  Thread.Sleep(500);
                  vista.colorLapiz = Color.LightSteelBlue;
                  vista.mostrar_Circulo(circulo);
                  if (sentido)
                  {
                      if (circulo.centro.X <= panel1.Width - 2 * circulo.radio)
                          circulo.centro = new Point(circulo.centro.X + circulo.radio, circulo.centro.Y);
                      else
                          sentido = false;

                  }
                  else 
                  {
                      if (circulo.centro.X > circulo.radio)
                          circulo.centro = new Point(circulo.centro.X - circulo.radio, circulo.centro.Y);
                      else
                          sentido = true;

                  }

                  vista.colorLapiz = Color.DarkRed;
                  vista.mostrar_Circulo(circulo);
              }
            
            }

        }
    }
}
