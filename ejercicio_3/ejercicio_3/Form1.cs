using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
        
        public List<Figura> listaFiguras = new List<Figura>();
        

        //subprograma para obtener posiciones y color
        //void ObtenerPosicionesyColor(out int posX, out int posY, out string color)
        //{
        //    posX = int.Parse(Interaction.InputBox("Introduzca la posición X"));
        //    posY = int.Parse(Interaction.InputBox("Introduzca la posición Y"));
        //    color = Interaction.InputBox("Introduzca el color");
        //}


        //función para mostrar los datos del círculo
        string MostrarDatosCirculos(List<Figura> listaFiguras)
        {
            string texto = "Datos de los círculos: \n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Circulo) //comprobar que la figura sea un CÍRCULO
                {
                    texto += $"Círculo número {contador}\n";
                    texto += $"{figura}\n";
                    texto += $"El área es: {figura.Area()}\n\n";

                    contador++;
                }
            }

            return texto;
        }

        //función para mostrar el perímetro de los cuadrados
        double SumaPerimetrosCuadrados(List<Figura> listaFiguras)
        {
            double suma = 0;

            foreach (Cuadrado cuadrado in listaFiguras.Where(f => f is Cuadrado))
            {               
                    //IMPORTANTE: hacer el casting a FIGURA para poder acceder al método Perímetro que es una clase perteneciente a CUADRADO pero no a las demás
                    suma += cuadrado.Perimetro();                
            }

            return suma;
        }

        //función pra mostrar cuadrados
        string MostrarDatosCuadrados(List<Figura> listaFiguras)
        {
            string texto = "Datos de los cuadrados: \n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras.Where(f => f is Cuadrado))
            {
                //if (figura is Cuadrado) //comprobar que la figura sea un CUADRADO
              //  {
                    texto += $"Cuadrado número {contador}\n";
                    texto += $"{figura}\n";
                    texto += $"El área es: {figura.Area()}\n\n";

                    contador++;
               // }
            }

            return texto;
        }

        private void btnIntroducirCirculo_Click(object sender, EventArgs e)
        {
            /* int posX, posY, radio;
            string color;

            //para obtener datos del círculo
          //  ObtenerPosicionesyColor(out posX, out posY, out color);
            radio = int.Parse(Interaction.InputBox("Introduzca el radio del círculo"));

            //nuevo objeto
            Circulo circulo = new Circulo(posX, posY, color, radio);

            //añadir a la lista de FIGURAS
            listaFiguras.Add(circulo); 
            */
            try
            {
                // Creamos un objeto del formulario de círculos
                frmIntroducirCirculo fCirculos = new frmIntroducirCirculo(listaFiguras);

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

            frmIntroducirCuadrado fCuadrados = new frmIntroducirCuadrado(listaFiguras);

            // Abrimos el formulario
            fCuadrados.ShowDialog();
            /* int posX, posY, lado;
               string color;

             //  ObtenerPosicionesyColor(out posX, out posY, out color);
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
                texto += $"{figura}\n";
                texto += $"Él área es:{figura.Area()}\n\n";

                MessageBox.Show(texto);

                contador++;
            } 
        }


        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{MostrarDatosCirculos(listaFiguras)}");
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{MostrarDatosCuadrados(listaFiguras)}");
            MessageBox.Show($"La suma de los perímetros es {SumaPerimetrosCuadrados(listaFiguras)}");
        }       
    }
}
