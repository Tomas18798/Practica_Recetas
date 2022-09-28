using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Ingrediente
    {
        public int IngredienteId { get; set; }

        public string Nombre { get; set; }

        public string Unidad { get; set; }

        public List<DetalleReceta> Detalles { get; set; }

        public Ingrediente()
        {
            Detalles = new List<DetalleReceta>();
        }

        public void AgregarDetalle(DetalleReceta detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }
    }
}

