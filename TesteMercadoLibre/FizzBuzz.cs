using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMercadoLibre
{
    public class FizzBuzz
    {
        public string RetornaDados(int i)
        {
            string retorno = "";

            if (i % 3 == 0 && i % 5 == 0)
            {
                retorno = "FizzBuzz";
            }
            else if (i % 3 == 0 && !(i % 5 == 0))
            {
                retorno = "Fizz";
            }
            else if (i % 5 == 0 && !(i % 3 == 0))
            {
                retorno = "Buzz";
            }
            else
            {
                retorno = i.ToString();
            }

            return retorno;
        }

        public void Resultado()
        {
            Console.WriteLine("Insira o numero: ");
            var entrada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
            {
                var retorno = RetornaDados(i);
                Console.WriteLine(retorno);
            }
        }
    }
}
