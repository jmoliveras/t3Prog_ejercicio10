using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    public class Cuadrado : Figura
    {

        private double mLado;

        public double Lado {
            
            get { return mLado; }
            set { mLado = value; }
        
        }

        public Cuadrado(int x, int y, string color, double lado) : base(x, y , color)
        {
            mLado = lado;
        }

        public override string QuienSoy()
        {
            return "Soy un cuadrado";
        }

        public override double Area()
        {
            return Lado * Lado;
            
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += $"\nLado: {mLado}";

            return texto;
        }

        public double Perimetro()
        {
            return mLado * 4;
        }
    }
}
