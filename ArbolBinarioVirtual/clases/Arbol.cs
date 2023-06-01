using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioVirtual.clases
{
    internal class Arbol
    {
        public decimal tamaño { get; set; }
        public string nombre_archivo { get; set; }
        public List<Sector> sectores { get; set; }

        public Arbol izquierdo { get; set; }
        public Arbol derecha { get; set; }
    }
}
