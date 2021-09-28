using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Menu
    {

        int opcion;
        public void OpcionesDeMenu(Camisa Micamisa, CarritoCompra Micarrito)


        {

            do
            {
       
              Console.WriteLine("MENÚ PRINCIPAL:");
              Console.WriteLine("1- Añadir camisas al carro de compras.");
              Console.WriteLine("2- Eliminar camisas del carro de compras.");
              Console.WriteLine("3- Salir.");

              if (Micarrito.CantidadCamisas() > 0)
              {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" Cantidad de camisas en el carro de compras: " + Micarrito.CantidadCamisas());
                Console.WriteLine("  Precio unitario: " + Micarrito.PrecioCamisa());
                Console.WriteLine("  Precio total sin descuento: $" + Micarrito.PrecioTotal());
                Console.WriteLine("  Descuento del: " + Micarrito.Descuento() + "% ");
                Console.WriteLine("  Precio final con descuento: $" + Micarrito.PrecioTotalConDescuento());
               }


               Console.WriteLine("Ingrese Opcion: ");


              opcion = Convert.ToInt32(Console.ReadLine());
              

                 switch (opcion)
                  {
                    case 1:
                            Console.Clear();
                            Console.WriteLine("Se Agregara una Camisa a su Carritos de Compras: ");

                            Micarrito.AgregarCamisa();
                            Console.Clear();
                    break;

                    case 2:
                           Console.Clear();
                           Console.WriteLine(" Se Quitara una Camisa de su Carritos de Compras: ");
                           Micarrito.EliminarCamisa();
                           Console.Clear();
                    break;

                    case 3:
                           Console.Clear();

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

                           }
                           else
                           {
                             Console.WriteLine("--- No es una opcion Valida.---");
                             Console.Clear();

                           }



                    break;


                    default:
                           Console.WriteLine(" Error: Debe ingresar un numero positivo ");

                    break;

                 }


            } while (opcion != 3);

        }


    }

      


}





