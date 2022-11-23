using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial.AgregarNuevoOrtoedro
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        Ortoedro edro = new Ortoedro();
        private void button1_Click(object sender, EventArgs e)
        {
         
          
            if (ValidarDatos()==true)
            {
                edro.AristaA = Convert.ToInt32(aristaAtextBox.Text);
                edro.AristaB = Convert.ToInt32(aristaBtextBox.Text);
                edro.AristaC = Convert.ToInt32(aristaCtextBox.Text);
                
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool validar = true;
            errorProvider1.Clear();
            if (!int.TryParse(aristaAtextBox.Text, out int nA)) 
            {
                validar = false;
                errorProvider1.SetError(aristaAtextBox, "Debe ingresar un número");
            }
            else if (!int.TryParse(aristaBtextBox.Text, out int nB))
            {
                validar = false;
                errorProvider1.SetError(aristaBtextBox, "Debe ingresar un número");

            }
            else if (!int.TryParse(aristaCtextBox.Text, out int nC))
            {
                validar = false;
                errorProvider1.SetError(aristaCtextBox, "Debe ingresar un número");
            }
            return validar;
        }

        public Ortoedro GetEdro()
        {
            return edro;
        }

        private void colorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CargarDatosComboLocalidades();
        }
        private void CargarDatosComboLocalidades()
        {
           
            var lista = Enum.GetValues(typeof(Colorines)).Cast<Colorines>().ToList();

            colorcomboBox.DataSource = lista;
            colorcomboBox.SelectedIndex = 0;
            edro.Colorines = colorcomboBox.Text;
        }
    }
}
