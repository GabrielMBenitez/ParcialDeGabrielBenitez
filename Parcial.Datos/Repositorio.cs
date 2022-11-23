using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Datos
{
    public class Repositorio
    {
        public Repositorio()
        {
            ListaEdros = ManejadorDeArchivosSecuencial.LeerArchivoSecuencial();
        }

        private List<Ortoedro> ListaEdros = new List<Ortoedro>();
       
        public void AgregarLista(Ortoedro edro)
        {
            ListaEdros.Add(edro);
        }
        public List<Ortoedro> GetLista()
        {
            return ListaEdros;
        }
        public int GetCantidad()
        {
            return ListaEdros.Count;

        }
  
    }
}
