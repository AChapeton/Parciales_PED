using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila almacen = new Pila();
            Pila almacen_aux = new Pila();

            int op = 0;
            int valor = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("---ALMACEN---");
                Console.WriteLine("1. Agregar contenedor a almacen");
                Console.WriteLine("2. Retirar contenedor de almacen");
                Console.WriteLine("3. Mirar estado de almacen (pila principal)");
                Console.WriteLine("4. Salir");
                Console.Write("Escoger una opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("Agregar contenedor (No más de 5 contenedores): ");
                        valor = int.Parse(Console.ReadLine());
                        almacen.Push(valor);
                        break;
                    case 2:
                        Console.Write("Retirar contenedor: ");
                        valor = int.Parse(Console.ReadLine());
                        almacen.PopValor(valor, almacen_aux, almacen);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("ALMACEN PRINCIPAL");
                        almacen.mostrar();
                        Console.ReadLine();
                        break;
                    default:
                        break;
                } 
            } while (op != 4);
        }
    }
}
