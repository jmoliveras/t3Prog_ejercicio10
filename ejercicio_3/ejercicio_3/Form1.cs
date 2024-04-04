using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //lista de firguas (no discrimina, de igual que sea círculo, cuadrado...)
        List<Figura> listaFiguras = new List<Figura>();
        

        /*//subprograma para obtener posiciones y color
        void obtenerPosicionesyColor(out int posX, out int posY, out string color)
        {
            posX = int.Parse(Interaction.InputBox("Introduzca la posición X"));
            posY = int.Parse(Interaction.InputBox("Introduzca la posición Y"));
            color = Interaction.InputBox("Introduzca el color");

        }*/



        //función para mostrar los datos del círculo
        string mostrarDatosCirculos(List<Figura> listaFiguras)
        {
            string texto = "Datos de los círculos: \n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Circulo)) //comprobar que la figura sea un CÍRCULO
                {
                    texto += $"Círculo número {contador}\n";
                    texto += $"{figura.ToString()}\n";
                    texto += $"El área es: {figura.Area()}\n\n";

                    contador++;
                }
            }

            return texto;
        }

        //función para mostrar el perímetro de los cuadrados
        double sumaPerimetrosCuadrados(List<Figura> listaFiguras)
        {
            double suma = 0;

            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Cuadrado))
                {
                    //IMPORTANTE: hacer el casting a FIGURA para poder acceder al método Perímetro que es una clase perteneciente a CUADRADO pero no a las demás
                    suma += ((Cuadrado)figura).Perimetro();
                }
            }

            return suma;
        }

        //función pra mostrar cuadrados
        string mostrarDatosCuadrados(List<Figura> listaFiguras)
        {
            string texto = "Datos de los cuadrados: \n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Cuadrado)) //comprobar que la figura sea un CUADRADO
                {
                    texto += $"Cuadrado número {contador}\n";
                    texto += $"{figura.ToString()}\n";
                    texto += $"El área es: {figura.Area()}\n\n";

                    contador++;
                }
            }

            return texto;
        }

        private void btnIntroducirCirculo_Click(object sender, EventArgs e)
        {
            /* int posX, posY, radio;
            string color;

            //para obtener datos del círculo
            obtenerPosicionesyColor(out posX, out posY, out color);
            radio = int.Parse(Interaction.InputBox("Introduzca el radio del círculo"));

            //nuevo objeto
            Circulo circulo = new Circulo(posX, posY, color, radio);

            //añadir a la lista de FIGURAS
            listaFiguras.Add(circulo); */

            try
            {
                // Creamos un objeto del formulario de círculos
                frmIntroducirCirculo fCirculos = new frmIntroducirCirculo();

                // Abrimos el formulario
                fCirculos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIntroducirCuadrado_Click(object sender, EventArgs e)
        {
            /* int posX, posY, lado;
            string color;

            obtenerPosicionesyColor(out posX, out posY, out color);
            lado = int.Parse(Interaction.InputBox("Introduzca el lado del cuadrado"));

            //nuevo objeto
            Cuadrado cuadrado = new Cuadrado(posX, posY, color, lado);

            //añadirlo a la lista de FIGURAS
            listaFiguras.Add(cuadrado); */

        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            //recorrer toda la lista
            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                string texto;

                texto = $"Figura número {contador}\n";
                texto += $"{figura.QuienSoy()}\n";
                texto += $"{figura.ToString()}\n";
                texto += $"Él área es:{figura.Area()}\n\n";

                MessageBox.Show(texto);

                contador++;
            } 
        }


        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            /* Pruebas
            Circulo circulo = new Circulo(4, 5, "Azul", 6);

            circulo.Color = "Rojo";
            circulo.Radio = 10;

            MessageBox.Show(circulo.QuienSoy());
            MessageBox.Show($"El área del círculo es: {circulo.Area()}");
            */



        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{mostrarDatosCuadrados(listaFiguras)}");
            MessageBox.Show($"La suma de los perímetros es {sumaPerimetrosCuadrados(listaFiguras)}");
        }
    }
}
