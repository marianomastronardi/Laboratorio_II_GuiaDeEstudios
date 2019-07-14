using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(IAvion))]
    public interface IAvion
    {
      EstadoVuelo Estado { get; }  
        void Despegar();
        void Estrellar();
    }
}
