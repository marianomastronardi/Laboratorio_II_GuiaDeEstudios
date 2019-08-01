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
        public static void AgregarVuelo<T>(this Aeropuerto<T> a) where T : IAvion
        {
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Aeropuerto.txt");
            writer.WriteLine(DateTime.Now + " " + ((Avion)(IAvion)a.Vuelos.LastOrDefault()).HorasDeVuelo);
            writer.Close();
        }
    }
}
