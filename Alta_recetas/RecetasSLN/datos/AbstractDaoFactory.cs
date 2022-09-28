using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    abstract class AbstractDaoFactory
    {
        public abstract IDao CrearRecetaDao();
    }
}
