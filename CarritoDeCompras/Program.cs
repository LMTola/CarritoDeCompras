using System;


namespace CarritoDeCompras
{
    class Program
    {
        //private int opcion;
        //private int Cantidad;
        private static CarritoCompra carrito;
        static void Main(string[] args)
        {

            carrito = new CarritoCompra();

            OpcionesDeMenu();




        }

        static void OpcionesDeMenu()
        {
            Console.WriteLine("SHOPPING ONLINE DE CAMISAS – Ventas minoristas y mayoristas.");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("MENÚ PRINCIPAL:");
            Console.WriteLine("1- Añadir camisas al carro de compras.");
            Console.WriteLine("2- Eliminar camisas del carro de compras."); 
            Console.WriteLine("3- Salir.");

            Console.WriteLine("Ingrese Opcion: ");


            int opcion = Convert.ToInt32(Console.ReadLine());
            Menu(opcion);

        }
        
        static void Menu(int opcion)
        {

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Se Agregara una Camisa a su Carritos de Compras: ");
   
                    carrito.AgregarCamisa();

                    MostrarCompra();
                    
                    OpcionesDeMenu();
                  
                    break;
                    
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Se Quitara una Camisa de su Carritos de Compras: ");
                    carrito.EliminarCamisa();
                    MostrarCompra();
                    
                    OpcionesDeMenu();
                    
                    break;
                   
                case 3:

                    char confirmar;
                    Console.WriteLine("* * * Seguro que desea salir? S/N");
                    
                    
                        confirmar = Convert.ToChar(Console.ReadLine()[0]);
                        confirmar = Char.ToUpper(confirmar);

                        if (confirmar == 'S')
                        {
                            Console.WriteLine("Saliendo...");
                            Environment.Exit(0);
                        }
                        else if (confirmar == 'N')
                        {
                        Console.Clear();
                        OpcionesDeMenu();
                        }
                        else
                        {
                            Console.WriteLine("--- No es una opcion Valida.---");
                        Console.Clear();
                        OpcionesDeMenu(); ;
                        }
                    
            

                    break;


                default:



                    break;

            }


        }

        static void MostrarCompra()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" Cantidad de camisas en el carro de compras: " + carrito.CantidadCamisas());
            Console.WriteLine("  Precio unitario: " + carrito.PrecioCamisa() );
            Console.WriteLine("  Precio total sin descuento: $" + carrito.PrecioTotal());
            Console.WriteLine("  Descuento del: " + carrito.Descuento()+ "% " );
            Console.WriteLine("  Precio final con descuento: $" + carrito.PrecioTotalConDescuento());
        }

    }
}