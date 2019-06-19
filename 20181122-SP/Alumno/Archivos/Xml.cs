using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entidades;
namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
    public void Guardar(string archivo, T datos)
    {
      XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.ASCII);
      XmlSerializer ser = new XmlSerializer(typeof(T));
      ser.Serialize(writer, datos);
      writer.Close();
    }

    public void Leer(string archivo, out T datos)
    {
      XmlTextReader reader = new XmlTextReader(archivo);
      XmlSerializer ser = new XmlSerializer(typeof(T));
      datos = (T)ser.Deserialize(reader);
      reader.Close();
    }
  }
}
