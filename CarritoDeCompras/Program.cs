using System;


namespace CarritoDeCompras
{
    class Program
    {
        
        private static CarritoCompra carrito;
        static void Main(string[] args)
        {
            Menu Menu1 = new Menu();
            Camisa Micamisa = new Camisa();
            CarritoCompra Micarrito = new CarritoCompra();

            Console.WriteLine("SHOPPING ONLINE DE CAMISAS – Ventas minoristas y mayoristas.");
            Console.WriteLine("------------------------------------------------------------");
            Menu1.OpcionesDeMenu(Micamisa, Micarrito);

        }

        


    }
}