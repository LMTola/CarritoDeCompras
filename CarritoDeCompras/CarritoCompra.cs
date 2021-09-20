using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class CarritoCompra
    {
        private List<Camisa> Camisas = new List<Camisa>();
        private double DescuentoMedio 
        {
            get { return 10.0; }
        }

        private double DescuentoMayor
        {
            get { return 20.0; }
        }

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
            if(Camisas.Count()>0)
            return Camisas.First().GetPrecio();
            return 0.0;
        }
         
        public double PrecioTotal()
        {
          double Total = 0.0;

          foreach (Camisa c in Camisas)
            {
                Total += c.GetPrecio();
            }
            return Total;
            

        }

        public double Descuento()
        {
            if (Camisas.Count >= 3 && Camisas.Count <= 5)
                return DescuentoMedio;
            else if (Camisas.Count >= 5)
                return DescuentoMayor;

            return 0.0;

        }

        public double PrecioTotalConDescuento()
        {

            return (PrecioTotal() * (100- Descuento()))/100;
        }

    }

}
