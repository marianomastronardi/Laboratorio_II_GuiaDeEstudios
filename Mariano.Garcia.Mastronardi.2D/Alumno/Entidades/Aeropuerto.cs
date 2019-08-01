using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeropuerto<T> where T : IAvion
    {
        private List<T> vuelos;

        public List<T> Vuelos { get => this.vuelos; }

        public Aeropuerto()
        {
            this.vuelos = new List<T>();
        }

        public void FinalizarVuelos()
        {
            foreach( IAvion avion in this.vuelos)
            {
                avion.Estrellar();
            }
        }

        public static explicit operator string(Aeropuerto<T> a)
        {
            int cantVuelos = 0;

            foreach(T vuelo in a.vuelos)
            {
                if (((IAvion)vuelo).Estado == EstadoVuelo.Volando)
                    cantVuelos++;
            }
            return string.Format("El aeropuerto cuenta con {0} vuelos en estado Volando", cantVuelos);
        }

        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);
            return a.vuelos.Count * 50;
        }

    }
}
