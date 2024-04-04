using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    public class Circulo : Figura //como el extends de Java
    {
        private int mRadio; // solo pertence a esta clase hija

        public int Radio
        {
            get { return mRadio; }
            set { mRadio = value; }
        }

        //constructor de esta clase llama al de la clase padre, para además de inicializar los mimbros de esta clase, también los de la clase padre
        public Circulo(int x, int y, string color, int radio) : base (x, y, color)
        {
            mRadio = radio;
        }

        /*new public string QuienSoy() //new para redefinir este método de la clase padre
        {
            return "Soy un círculo";
        }*/ //no es la forma correcta del todo, mejor virutal y override

        public override string QuienSoy()
        {
            return "Soy un círculo";
        }

        public override string ToString()
        {
            string texto = base.ToString(); //llamada al del padre
            texto += $"\nRadio: {mRadio}";

            return texto;
        }

        public override double Area()
        {
            return Math.PI * mRadio * mRadio;
        }

        //mostrar círculo en listado
        public string MostrarCirculo()
        {
            string texto = "";

            texto += $"\n Posición X: ";
            texto += $"\n Posición Y: ";
            texto += $"\n Color: ";
            texto += $"\n Radio: ";

            return texto;
        }
    }
}
