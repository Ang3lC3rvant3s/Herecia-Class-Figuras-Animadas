﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CirculosR
{
    class Rectangulo
    {
        public Point P1 { set; get; }
        public Point P2 { set; get; }

        public Rectangulo(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public int ancho()
        {
            return Math.Abs(P2.X - P1.X);
        }

        public int alto()
        {
            return Math.Abs(P1.Y - P2.Y);
        }
        public int area()
        {
            return ancho() * alto();
        } 
    }
}
