using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class ventanaPrincipal : Form
    {
        
        public ventanaPrincipal()
        {
            InitializeComponent();
        }
        private void btn_AgregarCompetidor_Click(object sender, EventArgs e)
        {
            ventanaInscripcion inscripcion = new ventanaInscripcion();
            inscripcion.Text = "Inscripcion del Competidor";
            string nombre;
            if (inscripcion.ShowDialog() == DialogResult.OK)
            {
                nombre = inscripcion.tbNombre.Text;
            }              
        }
        private void btn_CargarTiempo_Click(object sender, EventArgs e)
        {
            ventanaCargarTiempo cargar = new ventanaCargarTiempo();
            if(cargar.ShowDialog()==DialogResult.OK)
            {

            }

        }

        private void btn_VerResultado_Click(object sender, EventArgs e)
        {
            ventanaVerResultado resultados = new ventanaVerResultado();
            if (resultados.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
