using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    //La cantidad de camisas se obtiene de la cantidad de camisas agregadas en la lista camisas.
    //Por lo que los metodos agregar y quitar corresponden tenerlo en CarritoCompra.
    //Los descuentos los tengo en Camisa como estatico y los accedo desde CarritoCompra. 
    //Los Calculos de descuentos los dejo como Static para poder trabajarlos con la cantidad de camisas.

    class CarritoCompra
    {

        private List<Camisa> Camisas = new List<Camisa>();

 

        public void AgregarCamisa()
        {
            Camisas.Add(new Camisa());

        }

        public void EliminarCamisa()
        {
            if (Camisas.Count > 0)
                Camisas.RemoveAt(Camisas.Count - 1);

        }
        public int CantidadCamisas()
        {
            var cantidad = Camisas.Count();
            return cantidad;
        }

        public double PrecioCamisa()
        {
            
            if (CantidadCamisas() > 0)
                return Camisa.Precio ;
            return 0.0;
        }

        public  double Descuento()
        {
            int cantidad = CantidadCamisas();
            return Camisa.Descuento(cantidad); 
        }
        public double PrecioTotal()
        {
            int cantidad = CantidadCamisas();
            return Camisa.PrecioTotal(cantidad);
        }
        public double PrecioTotalConDescuento()
        {
            int cantidad = CantidadCamisas();
            return Camisa.PrecioTotalConDescuento(cantidad);
        }


    }

}
