using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Receta
    {
        public int RecetaNro { get; set; }

        public string Nombre { get; set; }

        public int TipoReceta { get; set; }

        public string Chef { get; set; }

        public List<DetalleReceta> detalles { get; set; }

        public Receta()
        {
            detalles = new List<DetalleReceta>();
        }

        public void agregarDetalle(DetalleReceta detalenuevo)
        {
            detalles.Add(detalenuevo);
        }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
