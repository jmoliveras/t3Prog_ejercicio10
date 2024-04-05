using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
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
    public partial class frmIntroducirCirculo : Form
    {
        private List<Figura> _listaFiguras;

        public frmIntroducirCirculo(List<Figura> listaFiguras)
        {
            _listaFiguras = listaFiguras;
            InitializeComponent();
        }

        //subprograma para obtener datos del círculo
        void obtenerCirulo(out int posX, out int posY, out string color, out int radio)
        {
            posX = int.Parse(txtPosicionX.Text);
            posY = int.Parse(txtPosicionY.Text);
            color = txtColor.Text;
            radio = int.Parse(txtRadio.Text);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fIntroducirCirculo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCirculo_Click(object sender, EventArgs e)
        {
            int posX, posY, radio;
            string color;

            //para obtener datos del círculo
            obtenerCirulo(out posX, out posY, out color, out radio);

            //nuevo objeto
            Circulo circulo = new Circulo(posX, posY, color, radio);

            //añadir a la lista de FIGURAS
            _listaFiguras.Add(circulo);
            DialogResult = DialogResult.OK;
        }
    }
}
