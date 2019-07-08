using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriandoVariavel
{
    class Program
    {
        static void Main(string[]args)
        {
          Console.WriteLine("Executando Projeto, criação de variavel");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            double salario = 500.50;
            Console.WriteLine(salario);

            long contacorrente = 1321332165498516849851321519870;
            //variavel de 64bits
            Console.WriteLine(contacorrente);

            short qntpro = 15000;
            //variavel de 16bits
            Console.WriteLine(qntpro);

            float alt = 1.80f;
            Console.WriteLine(alt);

            char UmaLetra = 'q';
            Console.WriteLine(UmaLetra);
            UmaLetra = (char)65;
            Console.WriteLine(UmaLetra);

            string texto = "test";
            Console.WriteLine(texto);
            string linha = @"- .Net
- Java
C++";
            Console.WriteLine(linha);

            if (idade >= 33)
            {
                Console.WriteLine("Ele ta velho");
            }
            else
            {
                Console.WriteLine("Ta novo ainda");
            }


          Console.WriteLine("Execução Finalizada, tecle enter");
          Console.ReadLine();
        }
    }
}
