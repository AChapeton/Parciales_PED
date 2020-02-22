using System;

namespace Ejercicio_1_lista
{
    class Program
    {
        static void Main(string[] args)

        {
            int opc;
            bool ComprobadorMenu;
            string caracter;
            lista listoidea=new lista();
            do
            {
                ComprobadorMenu = false;
                caracter = "";
                Console.WriteLine("*****************Lista de caracteres*****************");
                Console.WriteLine("*                                                   *");
                Console.WriteLine("*    1-insertar valor                               *");
                Console.WriteLine("*    2-Eliminar valor                               *");
                Console.WriteLine("*    3-Ver lista                                    *");
                Console.WriteLine("*    4-Total de elementos                           *");
                Console.WriteLine("*    5-Salir                                        *");
                Console.WriteLine("*                                                   *");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("\nIngrese la accion a realizar: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("ingrese el nuevo valor:");
                        caracter = Console.ReadLine();
                        listoidea.insercion(caracter);
                        Console.WriteLine("\nCaracter insertado");
                        Console.WriteLine("...\nPresione cualquier tecla para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        ComprobadorMenu = true;

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("ingrese dato a eliminar:");
                        caracter = Console.ReadLine();
                        listoidea.eliminardato(caracter);
                        Console.WriteLine("...\nPresione cualquier tecla para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        ComprobadorMenu = true;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("LISTOIDEA: ");
                        listoidea.mostrar();
                        Console.WriteLine("\nPresione cualquier tecla para volver al menu");
                        Console.ReadKey();
                        ComprobadorMenu = true;
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        listoidea.contar();
                        Console.WriteLine("...\nPresione cualquier tecla para volver al menu");
                        Console.ReadKey();
                        ComprobadorMenu = true;
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Gracias!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ingrese un dato valido");
                        Console.ReadKey();
                        Console.Clear();
                        ComprobadorMenu = true;
                        break;
                }
            } while (ComprobadorMenu);

        }
        class nodo
        {
            public string dato;
            public nodo siguiente;
        }

        class lista
        {
            public nodo cabeza;
            public lista()
            {
                cabeza = null;
            }
            public void insercion(string nuevodato)
            {
                nodo aux = new nodo();
                aux.dato = nuevodato;
                aux.siguiente = null;
                if (cabeza == null)
                {
                    cabeza = aux;
                }
                else
                {
                    nodo puntero;
                    puntero = cabeza;
                    cabeza = aux;
                    cabeza.siguiente = puntero;
                }
                    

            }
            public void mostrar()
            {
                if (cabeza == null)
                {
                    Console.WriteLine("No hay na\'");
                }
                else
                {
                    nodo puntero;
                    puntero = cabeza;
                    Console.WriteLine(" - "+puntero.dato);
                    while (puntero.siguiente != null)
                    {
                        puntero = puntero.siguiente;
                        Console.WriteLine(" - " + puntero.dato);
                    }
                }
            }
            public void contar()
            {
                int contador = 0;
                if (cabeza == null)
                {
                    Console.WriteLine("No hay na\'");
                }
                else
                {
                    nodo puntero;
                    puntero = cabeza;
                    contador = 1;
                    while (puntero.siguiente != null)
                    {
                        puntero = puntero.siguiente;
                        contador++;
                    }
                    Console.WriteLine("total de elementoideos: " + contador);
                }
            }
            public void eliminardato(string eliminante)
            {
                if(cabeza==null)
                {
                    Console.WriteLine("No hay na\' en la lista para eliminar");
                }
                else {
                    nodo aux = new nodo();
                    aux.siguiente = cabeza;
                    nodo recorredor = aux;
                    while (recorredor.siguiente != null)
                    {
                        if (recorredor.siguiente.dato == eliminante)
                        {
                            recorredor.siguiente = recorredor.siguiente.siguiente;
                        }
                        else
                        {
                            recorredor = recorredor.siguiente;
                        }
                    }
                    cabeza = aux.siguiente;
                }
            }
        }
        

    }
}
