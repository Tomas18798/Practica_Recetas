using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class DetalleReceta
    {
        public  Ingrediente Ingredientes { get; set; }

        public int Cantidad { get; set; }

        public DetalleReceta(Ingrediente I, int cant)
        {
            Ingredientes = I;
            Cantidad = cant;
        }

        //public double CalcularSubTotal()
        //{
        //    return Ingredientes * Cantidad;
        //}
    }
}
