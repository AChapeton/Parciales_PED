using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Pila
    {
        public nodo tope;

        public Pila()
        {
            tope = null;
        }

        public void Push(int valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            int contador = 0;
            

            if(tope == null)
            {
                tope = aux;
                aux.sgte = null;
            }
            else
            {
                contador = Contar();
                if(contador > 5)
                {
                    Console.WriteLine("No se pueden agregar más de 5 contenedores");
                    Console.ReadLine();
                }
                else
                {
                    aux.sgte = tope;
                    tope = aux;
                }
            }
        }

        public int Contar()
        {
            nodo puntero = new nodo();
            puntero = tope; ;
            int contador = 2;

            while(puntero.sgte != null)
            {
                contador++;
                puntero = puntero.sgte;
            }
            return contador;
        }

        public void PopValor(int valor, Pila pila_aux, Pila pila)
        {
            nodo aux; aux = tope;
            int var = 0;
            if(aux == null)
            {
                Console.WriteLine("Almacen vacío");
            }
            else
            {
                Console.WriteLine("Contenedor retirado");
                Console.ReadLine();
                while (aux.info != valor && aux.sgte != null)
                {
                    var = aux.info;
                    aux = aux.sgte;
                    pila_aux.Push(var);
                    pila.Pop();
                }
                if(aux.sgte == null)
                {
                    Console.WriteLine("El contenedor no existe");
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Console.WriteLine("Enter para continuar...");
            Console.ReadLine();
            pila.Pop();
            pila_aux.Retornar(pila_aux, pila);
        }

        public void Retornar(Pila pila_aux, Pila pila)
        {
            nodo aux; aux = tope;
            int var = 0;
            while(aux != null)
            {
                var = aux.info;
                aux = aux.sgte;
                pila.Push(var);
                pila_aux.Pop();
            }
        }

        public int Pop()
        {
            int valor = 0;
            if (tope == null)
                Console.WriteLine("Almacen vacío");
            else
            {
                valor = tope.info;
                tope = tope.sgte;
            }
            return valor;
        }

        public void mostrar()
        {
            nodo puntero; puntero = tope;
            if(puntero == null)
            {
                Console.WriteLine("Almacen vacío");
            }
            else
            {
                Console.WriteLine("{0}", puntero.info);
                while(puntero.sgte!= null)
                {
                    puntero = puntero.sgte;
                    Console.WriteLine("{0}", puntero.info);
                }
            }
        }


    }
}
