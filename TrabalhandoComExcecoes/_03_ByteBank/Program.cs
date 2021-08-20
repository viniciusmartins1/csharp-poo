using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException execao)
            {
                Console.WriteLine(execao.Message);
                //Console.WriteLine(execao.StackTrace);

                Console.WriteLine("Exceção tratada.");
            }
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch(NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
            }
            
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;

            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}

