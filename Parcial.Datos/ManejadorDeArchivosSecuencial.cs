using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Datos
{
    public class ManejadorDeArchivosSecuencial
    {
        private static string archivo = "Ortoedros.txt";
        public static void GuardarEnArchivosSecuencial(List<Ortoedro> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var ortoedro in lista)
                {
                    string linea = ConstruirLinea(ortoedro);
                    escritor.WriteLine(linea);
                }
            }
        }

        private static string ConstruirLinea(Ortoedro edro)
        {
            return $"{edro.AristaA}|{edro.AristaB}|{edro.AristaC}";
        }
        public static List<Ortoedro> LeerArchivoSecuencial()
        {
            List<Ortoedro> lista = new List<Ortoedro>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Ortoedro edro = ConstuirRectangulo(linea);
                        lista.Add(edro);
                    }
                }

            }
            return lista;
        }

        private static Ortoedro ConstuirRectangulo(string linea)
        {
            var campos = linea.Split('|');
            Ortoedro edro = new Ortoedro()
            {
                AristaA = int.Parse(campos[0]),
                AristaB = int.Parse(campos[1]),
                AristaC=int.Parse(campos[2])

            };
            return edro;

        }
    }
}
