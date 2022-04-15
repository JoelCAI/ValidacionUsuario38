using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionUsuario38
{
    public class Validador
    {
        public static int PedirInt(string mensaje)
        {
            /* la salida de esta funcion estará en la variable int valor */
            string mensError = "\n\n Por favor ingrese el valor solicitado" +
                               "\n Debe ingresar un valor que no sea vacio y que ese valor sea un número. ";

            int valor;
            Console.WriteLine(mensaje);

            if (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Clear();
                Console.WriteLine(mensError);
                return PedirInt(mensaje);
            }
            else
                return valor;
        }

        public static int PedirIntComparar(string mensaje, int numeroAnterior)
        {
            /* la salida de esta funcion estará en la variable int valor */
            string mensError = "\n\n Por favor ingrese el valor solicitado" +
                               "\n Debe ingresar un valor que no sea vacio y que ese valor sea mayor al número anterior " +
                               "ingresado. ";

            
            int valor;
            string cadena;
            Console.WriteLine(mensaje);
            Console.WriteLine(" El número anterior que ingreso es: " + numeroAnterior);
            cadena = Console.ReadLine();

            if (!int.TryParse(cadena, out valor))
            {
                Console.Clear();
                Console.WriteLine(mensError);
                return PedirIntComparar(mensaje,numeroAnterior);
            }

            int numero; 
            bool ok = int.TryParse(cadena, out numero);
            if (numeroAnterior >= numero )
            {
                Console.Clear();
                Console.WriteLine(mensError);
                return PedirIntComparar(mensaje, numeroAnterior);
            }
            else
                return valor;
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }
    }
}
