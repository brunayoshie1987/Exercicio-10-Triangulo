using System;

namespace Exercicio_10__Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Digite um valor para A");

                var a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite um valor para B");

                var b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite um valor para C");

                var c = Convert.ToDouble(Console.ReadLine());

                var resultado = VerificarSeEhTriangulo(a, b, c);

                Console.WriteLine(resultado);

                Console.ReadKey();
            }

            static string VerificarSeEhTriangulo(double a, double b, double c)
            {
                //https://pt.calcprofi.com/calculadora-triangle.html
                if ((a < (b + c) && b < (a + c) && c < (a + b)))
                {
                    return "É um triângulo";
                }
                else
                {
                    return "NÃO é um triângulo";
                }
            }
        }
    }
}
