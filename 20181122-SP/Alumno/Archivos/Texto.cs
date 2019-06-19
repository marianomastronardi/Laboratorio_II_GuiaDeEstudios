using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
    public void Guardar(string archivo, Queue<Patente> datos)
    {
      StreamWriter sw = new StreamWriter(archivo);
      while(datos.Count() > 0)
      {
        Patente p = datos.Dequeue();
        sw.WriteLine(p.ToString());
      }
    }

    public void Leer(string archivo, out Queue<Patente> datos)
    {
      datos = new Queue<Patente>();
      StreamReader sr = new StreamReader(archivo);
      Patente p = new Patente(sr.ReadLine(), Patente.Tipo.Mercosur);
      while (p.ToString().Length > 0)
        datos.Enqueue(p);
    }
  }
}
