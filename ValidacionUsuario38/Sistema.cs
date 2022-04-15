using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionUsuario38
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            int numeroUno = Validador.PedirInt("\n Ingrese un número");

            Console.Clear();
            Console.WriteLine("\n El número ingresado fue *" + numeroUno + "*.");

            int numeroDos = Validador.PedirIntComparar("\n Ingrese un número",numeroUno);

            Console.Clear();
            Console.WriteLine("\n El siguiente número ingresado fue *" + numeroDos + "*.");

            int numeroTres = Validador.PedirIntComparar("\n Ingrese un número", numeroDos);

            Console.Clear();
            Console.WriteLine("\n Los números ingresados en orden ascendente son: " + 
                              "\n Número *" + numeroUno + "* como primero" +
                              "\n Número *" + numeroDos + "* como segundo" +
                              "\n Número *" + numeroTres + "* como tercero");

            Validador.Despedida();

        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
