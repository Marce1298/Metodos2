using System;

namespace Metodos2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(sumaNumeros(7, 9));

            Console.WriteLine(divideNumeros(18,7));

        }

        static int sumaNumeros(int num1, int num2)
        {

            //Console.WriteLine($"La suma de los números es {num1 + num2}");
            return num1 + num2;

        }

        static double divideNumeros(double num1, int num2) => num1 / num2;
        /*cuando el metodo tiene unicamente una instrucion return (una linea de codigo)
        puede ser sustituido por ( => )*/
    

    }
}
