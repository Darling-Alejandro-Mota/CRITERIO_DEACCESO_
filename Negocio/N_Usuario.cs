using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class N_Usuario
    {
        D_Usuario objd = new D_Usuario();

        public DataTable N_usuarios(E_Usuario obje)
        {
            return objd.D_usuario(obje);
        }
    }
}
