using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class MetodoExtension
    {
        public static void AgregarVuelo(this Aeropuerto<IAvion> a)
        {
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Aeropuerto.txt");
            writer.WriteLine(DateTime.Now + " " + ((Avion)(IAvion)a.Vuelos.LastOrDefault()).HorasDeVuelo);
            writer.Close();
        }
    }
}
