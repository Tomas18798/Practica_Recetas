using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class RecetaDao : IDao
    {
        public List<Ingrediente> mostrarIngredientes()
        {
            List<Ingrediente> lista = new List<Ingrediente>();
            DataTable tabla = HelperDao.obtenerInstancia().consultaSQL("SP_CONSULTAR_INGREDIENTES");

            foreach (DataRow row in tabla.Rows)
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.IngredienteId = Convert.ToInt32(row["id_ingrediente"].ToString());
                ingrediente.Nombre = row["n_ingrediente"].ToString();
                ingrediente.Unidad = row["unidad_medida"].ToString();

                lista.Add(ingrediente);
            }
            return lista;
        }
    }
}
