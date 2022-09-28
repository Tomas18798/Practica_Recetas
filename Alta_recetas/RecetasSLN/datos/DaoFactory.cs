using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class DaoFactory : AbstractDaoFactory
    {
        public override IDao CrearRecetaDao()
        {
            return new RecetaDao();
        }
    }
}
