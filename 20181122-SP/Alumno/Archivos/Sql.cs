using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql :IArchivo<Queue<Patente>>
    {
    private SqlConnection conexion;
    private SqlCommand comando;

    public Sql()
    {
      conexion = new SqlConnection();
      comando = new SqlCommand();
    }

    public void Guardar(string tabla, Queue<Patente> datos)
    {
      conexion.Open();
      while(datos.Count() > 0)
      {
        Patente p = datos.Dequeue();
        comando.CommandText = "Insert into [dbo].Patentes Values ('" + p.CodigoPatente + "', '" + p.TipoCodigo.ToString() + "');";
        comando.ExecuteNonQuery();
      }
      conexion.Close();
    }

    public void Leer(string tabla, out Queue<Patente> datos)
    {
      datos = new Queue<Patente>();
      conexion.Open();
      comando.CommandText = "Select * From [dbo].Patentes";
      SqlDataReader oDR = comando.ExecuteReader();
      while(oDR.Read())
      {
        Patente p = new Patente(oDR["patente"].ToString(), oDR["tipo"].ToString() == Patente.Tipo.Mercosur.ToString() ? Patente.Tipo.Mercosur : Patente.Tipo.Vieja);
        datos.Enqueue(p);
      }

      conexion.Close();
    }
  }
}
