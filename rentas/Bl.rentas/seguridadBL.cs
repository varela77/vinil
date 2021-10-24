using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.rentas
{
    public class seguridadBL
    {
        public bool autorizar(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "123")
            {
            return true;
         }
            else
            {
                if (usuario == "user" && contrasena == "456")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
