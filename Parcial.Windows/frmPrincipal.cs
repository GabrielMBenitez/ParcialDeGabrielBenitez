using Parcial.AgregarNuevoOrtoedro;
using Parcial.Datos;
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

namespace Parcial.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public int contador = 0;
        Ortoedro edro = new Ortoedro();
        Repositorio repo = new Repositorio();
        List<Ortoedro> lista = new List<Ortoedro>();
        private void AgregartoolStripButton_Click(object sender, EventArgs e)
        {
            contador++;
    
            frmAgregar frm = new frmAgregar();
            DialogResult dr = frm.ShowDialog(this);
            edro = frm.GetEdro();
            repo.AgregarLista(edro);
            lista = repo.GetLista();
            MostrarLista(lista);
            contadottextBox.Text = repo.GetCantidad().ToString();

        }

        private void MostrarLista(List<Ortoedro> lista)
        {
            OrtoedrosdataGridView.Rows.Clear();

            foreach (var edro in lista)
            {
                var r = ConstruirFila();
                LlenarDatosFilar(r, edro);
                AgregarFila(r);

            }
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(OrtoedrosdataGridView);
            return r;
        }
        private void LlenarDatosFilar(DataGridViewRow r, Ortoedro edro)
        {
            r.Cells[colAristaA.Index].Value = edro.AristaA;
            r.Cells[colAristaB.Index].Value = edro.AristaB;
            r.Cells[colAristaC.Index].Value = edro.AristaC;
            r.Cells[colArea.Index].Value = edro.GetArea();
            r.Cells[colVolumen.Index].Value = edro.GetVolumen();
            r.Cells[colColor.Index].Value = edro.Colorines;
        }
        private void AgregarFila(DataGridViewRow r)
        {
            OrtoedrosdataGridView.Rows.Add(r);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            contadottextBox.Text = repo.GetCantidad().ToString();
            ManejadorDeArchivosSecuencial.LeerArchivoSecuencial();
            lista = ManejadorDeArchivosSecuencial.LeerArchivoSecuencial();
            MostrarLista(lista);
         
        }

       

        private void GuardartoolStripButton_Click(object sender, EventArgs e)
        {
            ManejadorDeArchivosSecuencial.GuardarEnArchivosSecuencial(lista);
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            Ortoedro edroBorrar = new Ortoedro();
            var r = OrtoedrosdataGridView.SelectedRows[0];
            OrtoedrosdataGridView.Rows.Remove(r);
            edroBorrar = edro;
            contador = repo.GetCantidad();
          
               
  
                           
       
        }

       
    }
}
