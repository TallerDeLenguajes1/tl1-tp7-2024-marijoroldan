// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq.Expressions;
using EspacioCalculadora;

Calculadora MiCalculadora = new Calculadora();
int operacion;
double termino;

do
{
    Console.WriteLine("Ingrese la operación que desea realizar: \n1. Suma\n 2. Resta\n 3. Multiplicar\n 4. Dividir\n 6. Limpiar\n");
    int.TryParse(Console.ReadLine(), out operacion);



    switch (operacion)
    {

        case 1:
            Console.WriteLine("Ingrese el termino: \n");
            double.TryParse(Console.ReadLine(), out termino);
            MiCalculadora.Sumar(termino);
            break;
        case 2:
            Console.WriteLine("Ingrese el termino: \n");
            double.TryParse(Console.ReadLine(), out termino);
            MiCalculadora.Restar(termino);
            break;
        case 3:
            Console.WriteLine("Ingrese el termino: \n");
            double.TryParse(Console.ReadLine(), out termino);
            MiCalculadora.Multiplicar(termino);
            break;
        case 4:
            Console.WriteLine("Ingrese el termino: \n");
            double.TryParse(Console.ReadLine(), out termino);
            MiCalculadora.Dividir(termino);
            break;
        default:
            Console.WriteLine("Ingrese una operación correcta: \n1. Suma\n 2. Resta\n 3. Multiplicar\n 4. Dividir\n 6. Limpiar\n");
            int.TryParse(Console.ReadLine(), out operacion);
            break;
    }
    Console.WriteLine("---------------------- Resultado: " +MiCalculadora.Resultado, "-----------------------\n");
    Console.WriteLine("----------------------------------------------------------\n");


} while (operacion != 6);