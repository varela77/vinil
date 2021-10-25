using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.rentas
{
    public class productosBL
    {


        public BindingList<producto> listaproductos { get; set; }
        public productosBL()
        {
            listaproductos = new BindingList<producto>();

            var producto1 = new producto();
            producto1.id = 1;
            producto1.descripcion = "vinil metallica";
            producto1.precio = 1000;
            producto1.existencia = 22;
            producto1.activo = true;

            listaproductos.Add(producto1);

            var producto2 = new producto();
            producto2.id = 2;
            producto2.descripcion = "vinil pink floyd";
            producto2.precio = 1200;
            producto2.existencia = 12;
            producto2.activo = true;

            listaproductos.Add(producto2);

            var producto3 = new producto();
            producto3.id = 3;
            producto3.descripcion = "vinil led zepellin";
            producto3.precio = 1300;
            producto3.existencia = 25;
            producto3.activo = true;

            listaproductos.Add(producto3);
        }

        public BindingList<producto> obtenerproductos()
        {

            return listaproductos;
        }
    }

    public class producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double precio{ get; set; }
        public int existencia { get; set; }
        public bool activo { get; set; }

    }
}
