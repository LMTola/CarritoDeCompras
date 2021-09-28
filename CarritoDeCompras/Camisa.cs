using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Camisa
    {
        public static double DescuentoMedio
        {
            get { return 10.0; }
        }
        public static double Precio
        {
            get { return 1000.0; }
        }

        public static double DescuentoMayor
        {
            get { return 20.0; }
        }

        public static double Descuento(int cantidad)
        {
            if (cantidad >= 3 && cantidad <= 5)
                return Camisa.DescuentoMedio;
            else if (cantidad >= 5)
                return Camisa.DescuentoMayor;

            return 0.0;

        }


        public static double PrecioTotal(int cantidad)
        {
            return cantidad*Precio;
        }

        public static double PrecioTotalConDescuento(int cantidad)
        {
            return ((Precio * (100 - Descuento(cantidad))) / 100)*cantidad;
        }



    }
}
