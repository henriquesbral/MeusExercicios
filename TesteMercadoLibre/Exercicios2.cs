using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMercadoLibre
{
    public class Exercicios2
    {
        public void ContarVogais(string a)
        {
            var vogais = "aeiouAEIOU";
            int somaVogais = 0;

            for (int i = 0; i < a.Length; i++)
            {
                var letra = a[i].ToString();

                if (vogais.Contains(letra))
                {
                    somaVogais += 1;
                }
            }

            //OU

            for (int i = 0; i < a.Length; i++)
            {
                if (vogais.Contains(a[i]))
                {
                    somaVogais += 1;
                }
            }

            Console.WriteLine($"A palavra {a} possui {somaVogais} vogais.");
        }

        public void VerificarParImpar(int n)
        {
            if (n % 2 ==0)
            {
                Console.WriteLine($"O número {n} é par");
            }
            else
            {
                Console.WriteLine($"O número {n} é impar");
            }

            //OU

            string RetornaParImpar(int n)
            {
                return n % 2 == 0 ? "Par" : "Impar";
            }

        }

        public void SomarNumero(int n)
        {
            int soma = 0;

            if (n <= 0)
            {
                Console.WriteLine("Por favor, insira um número maior que zero");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma de 1 a {n} é: {soma}");
        }

        public void ImprimirNumeros()
        {
            var contador = 0;
            var somaPares = 0;
            Console.WriteLine($"Os 10 primeiros números pares são: ");

            while (somaPares < 10)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine($"- {contador}");
                    somaPares++;
                }
                contador++;
            }
        }

        public void ContagemRegressiva(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Digite um número maior ou igual a zero");
                return;
            }

            Console.WriteLine($"Contagem regressiva de {n} até 0: ");
            do
            {
                Console.WriteLine(n);
                n--;
            } 
            while (n >= 0);
        }

        public void InverterString(string palavra)
        {
            string palavraInvertida = "";
            for (int i = palavra.Length-1; i>=0;i--)
            {
                palavraInvertida += palavra[i];
            }
            //OU
            string RetornaStringInvertida(string palavra)
            {
                var sb = new StringBuilder();
                var retorno = "";
                for (int i = palavra.Length - 1; i >= 0; i--)
                {
                    sb.Append(palavra[i]);
                }
                retorno = $"String invertida: {sb}";

                return retorno;
            }

            Console.WriteLine($"String invertida: {palavraInvertida}");
        }

        public void MediaNotas()
        {
            int contador = 1;
            List<int> notas = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Informe a {contador}° nota");
                var numeroDaNota = Convert.ToInt32(Console.ReadLine());
                notas.Add(numeroDaNota);
                contador++;
            }
            Console.WriteLine($"A médias das notas informadas é: {(notas.Sum() / 5)}");
            //OU
            void MediaNotas2()
            {
                int contador = 1;
                List<int> notas = new List<int>();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Informe a {contador}ª nota:");
                    var numeroDaNota = Convert.ToInt32(Console.ReadLine());
                    notas.Add(numeroDaNota);
                    contador++;
                }

                double media = notas.Sum() / 5.0;
                Console.WriteLine($"A média das notas informadas é: {media:F2}");
            }
        }

        public void MaiorMenorArray()
        {
            /*Minha correção, bug na entrada de valores com mais de 1 casa, por exemplo 10, 23*/
            Console.WriteLine("Insira os 10 números separando eles por vírgula: ");
            var numeros = Console.ReadLine();
            int contador = 0;

            int[] arrayNumeros = new int[10];

            for (int i = 0; i< numeros.Length; i++)
            {
                if (numeros[i] != ',' && contador < 10)
                {
                    arrayNumeros[contador] = Convert.ToInt32(numeros[i].ToString());
                    contador++;
                }
            }

            Console.WriteLine($"Esse é o maior número: {arrayNumeros.Max()} \nEsse é o menor número: {arrayNumeros.Min()}");

            /*Correção apontada pelo ChatGPT*/

            string[] nums = numeros.Split(',');

            if (nums.Length != 10)
            {
                Console.WriteLine("Você deve digitar exatamente 10 números");
                return;
            }

            for (int i =0; i < nums.Length; i++)
            {
                arrayNumeros[i] = Convert.ToInt32(nums[i].Trim());
            }
        }

        public void SepararNumerosParImpar()
        {
            Console.WriteLine("Insira os 10 números separando eles por vírgula: ");
            var numeros = Console.ReadLine();

            string[] nums = numeros.Split(',');

            if (nums.Length != 10)
            {
                Console.WriteLine("Você precisa inserir exatamente 10 números !");
                return;
            }

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int numero = Convert.ToInt32(nums[i].Trim());//sugestão do chatgpt para melhorar o código

                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
                else
                    impares.Add(numero);
            }

            Console.WriteLine($"Essa é a lista de números Pares: ");
            foreach (int i in pares)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine($"Essa é a lista de números Impares: ");
            foreach (int i in impares)
            {
                Console.WriteLine(i);
            }
        }

        public void ContarPalavras()
        {
            Console.WriteLine("Escreva uma frase abaixo: ");
            var frase = Console.ReadLine();

            string[] palavras = frase.Split(' ');
            string[] palavrasAlternativo = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries); //nesse caso estou usando o RemoveEmptyEntries para casos onde o usuario coloca vários espaços

            Console.WriteLine($"A frase informada possui {palavras.Count()} palavras.");
        }

        private static void ChamandoClasseNaProgram()
        {
            //exercicios.ContarVogais(palavra);
            //exercicios.VerificarParImpar(numero);
            //exercicios.SomarNumero(numero);
            //exercicios.ImprimirNumeros();
            //exercicios.ContagemRegressiva(numero);
            //exercicios.InverterString(palavra);
            //exercicios.MediaNotas();
            //exercicios.MaiorMenorArray();
            //exercicios.SepararNumerosParImpar();
            //exercicios.ContarPalavras();
        }
    }
}
