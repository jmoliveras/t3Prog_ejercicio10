using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3
{
    public partial class frmIntroducirCuadrado : Form
    {     
            private List<Figura> _listaFiguras;

            public frmIntroducirCuadrado(List<Figura> listaFiguras)
            {
                _listaFiguras = listaFiguras;
                InitializeComponent();
            }

            //subprograma para obtener datos del cuadrado
            void ObtenerCuadrado(out int posX, out int posY, out string color, out int lado)
            {
                posX = int.Parse(txtPosicionX.Text);
                posY = int.Parse(txtPosicionY.Text);
                color = txtColor.Text;               
                lado = int.Parse(txtLado.Text);
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void fIntroducirCuadrado_Load(object sender, EventArgs e)
            {

            }

            private void btnAgregarCuadrado_Click(object sender, EventArgs e)
            {
                int posX, posY, radio, lado;
                string color;

                //para obtener datos del cuadrado
                ObtenerCuadrado(out posX, out posY, out color, out lado);

                //nuevo objeto
                Cuadrado Cuadrado = new Cuadrado(posX, posY, color, lado);

                //añadir a la lista de FIGURAS
                _listaFiguras.Add(Cuadrado);
                DialogResult = DialogResult.OK;
            }       
    }
}
