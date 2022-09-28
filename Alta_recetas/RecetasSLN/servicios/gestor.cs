using RecetasSLN.datos;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios
{
    class gestor
    {
        private IDao DAO;

        public gestor(AbstractDaoFactory factory)
        {
            DAO = factory.CrearRecetaDao();
        }

        public List<Ingrediente> obtenerIngredientes()
        {
            return DAO.mostrarIngredientes();
        }
    }
}
