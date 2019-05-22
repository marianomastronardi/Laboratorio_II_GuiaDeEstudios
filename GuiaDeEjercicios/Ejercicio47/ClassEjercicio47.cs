using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Competencia;

namespace Ejercicio47
{
  class ClassEjercicio47
  {
    static void Main(string[] args)
    {
      EquipoDeFutbol Boca = new EquipoDeFutbol("Boca", new DateTime(1903, 4, 3));
      EquipoDeFutbol River = new EquipoDeFutbol("River", new DateTime(1905, 5, 25));
      EquipoDeFutbol Racing = new EquipoDeFutbol("Racing", new DateTime(1901, 3, 25));

      EquipoDeBasquet Nacional = new EquipoDeBasquet("Nacional", new DateTime(1903, 4, 3));
      EquipoDeBasquet VillaMitre = new EquipoDeBasquet("VillaMitre", new DateTime(1905, 5, 25));
      EquipoDeBasquet Quilmes = new EquipoDeBasquet("Quilmes", new DateTime(1901, 3, 25));

      Torneo<Equipo> superLiga = new Torneo<Equipo>();
      Torneo<Equipo> ligaNacional = new Torneo<Equipo>();

      superLiga = superLiga + Boca;
      superLiga = superLiga + River;
      superLiga = superLiga + Racing;

      ligaNacional = ligaNacional + Nacional;
      ligaNacional = ligaNacional + VillaMitre;
      ligaNacional = ligaNacional + Quilmes;

      //Muestro los equipos
      Console.WriteLine(superLiga.Mostrar());

      //Muestro el resultado de un partido de Futbol
      Console.WriteLine(superLiga.JugarPartido());

      //Muestro el resultado de un partido de Basquet
      Console.WriteLine(ligaNacional.JugarPartido());

      Console.Read();
    }
  }
}
