﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CirculosR
{
    class Circulo
    {
        public int radio { set; get; }
        public Point centro { set; get; }

        public Circulo(int r, Point c)
        {
            radio = r;
            centro = c;
        }

        public double area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

    }
}
