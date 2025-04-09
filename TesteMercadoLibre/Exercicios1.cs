using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMercadoLibre
{
    public class Exercicios1
    {
        public void ExercicioParImpar(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{n} - Par");
                }
                else
                {
                    Console.WriteLine($"{n} - Impar");
                }
            }
        }

        public void Multiplos(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 4 == 0) && (i % 6 == 0))
                {
                    Console.WriteLine("QuadHex");
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine("Quad");
                }
                else if (i % 6 == 0)
                {
                    Console.WriteLine("Hex");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void RepetirPalavra(int n, string p)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(p);
            }
        }

        public void ContagemRegressiva(int n)
        {
            for (int i = n; i >= 0; i--)
            {
                if (i % 10==0)
                {
                    Console.WriteLine("Boom!");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void SomaPares(int n)
        {
            List<int> numeros = new List<int>();

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    numeros.Add(i);
                }
            }

            //OU

            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma dos pares de 1 a {n} é: {numeros.Sum()}");
        }

        private void DadosUsadosProgram()
        {
            Exercicios1 exercicios = new Exercicios1();

            //Console.WriteLine("Escreva a palavra: ");
            //var palavra = Console.ReadLine();

            Console.WriteLine("Escreva o numero: ");
            var numero = Convert.ToInt32(Console.ReadLine());
            //exercicios.ExercicioParImpar(numero);
            //exercicios.Multiplos(numero);
            //exercicios.RepetirPalavra(numero, palavra);
            //exercicios.ContagemRegressiva(numero);
            //exercicios.SomaPares(numero);
        }
    }
}
