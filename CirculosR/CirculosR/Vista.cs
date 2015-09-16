using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace CirculosR
{
    class Vista
    {
        
            private Graphics g;
           public Color colorLapiz { set; get; }
            private int anchura, altura;
            private Pen lapiz;
            public Vista(Panel areaDibujo)
            {
                g = areaDibujo.CreateGraphics();
                
                anchura = areaDibujo.Width;
                altura = areaDibujo.Height;
            }
            public void mostrar_Rectangulo(Rectangulo r)
            {
                lapiz = new Pen(colorLapiz, 3);
                g.DrawRectangle(lapiz, r.P1.X, r.P1.Y, r.ancho(), r.alto());
            }
            public void mostrar_Circulo(Circulo c)
            {
                lapiz = new Pen(colorLapiz, 3);
                g.DrawEllipse(lapiz, c.centro.X, c.centro.X, c.radio, c.radio);
            }
            public void borrar()
            {
                SolidBrush fondo = new SolidBrush(Color.LightSteelBlue);
                Rectangle rect = new Rectangle(0, 0, anchura, altura);
                g.FillRectangle(fondo, rect);
            }
        
    }
}
