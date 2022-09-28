using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    interface IDao
    {
        List<Ingrediente> mostrarIngredientes();
        
    }
}
