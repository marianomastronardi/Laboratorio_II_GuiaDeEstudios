using System.Collections.Generic;
using System.Text;

namespace Formula1
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this() 
        {  
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Caantidad Competidores: " + this.cantidadCompetidores + "\n");
            sb.Append("Caantidad Vueltas: " + this.cantidadVueltas + "\n");
            foreach (AutoF1 a in this.competidores)
            {
                sb.Append("    " + a.MostrarDatos() + "\n");
            }

            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool canAdd = false;

            if (!(c is null))
            {
                if (!(c.competidores is null))
                {
                    if (c.competidores.Count < c.cantidadCompetidores)
                    {
                        if (!(c == a))
                        {
                            c.competidores.Add(a);
                            a.SetEnCompetencia(true);
                            a.SetVueltasRestantes(c.cantidadVueltas);
                            a.SetCantidadCombustible((short)new System.Random().Next(15, 100));
                            canAdd = !canAdd;
                        }
                    }
                }
            }

            return canAdd;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool canOut = false;

            if (!(c is null))
            {
                if (!(c.competidores is null))
                {
                    if (c.competidores.Contains(a))
                    {
                        c.competidores.Add(a);
                        canOut = !canOut;
                    }
                }
            }

            return canOut;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
            //return (c == null ? false : c.competidores == null ? false : a == null ? false : c.competidores.Contains(a));
        }

    public static bool operator !=(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
            //return (c == null ? false : c.competidores == null ? false : a == null ? false : c.competidores.Contains(a));
        }
    }
}
