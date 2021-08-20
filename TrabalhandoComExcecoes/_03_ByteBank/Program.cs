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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Não é possível divisao por 0!");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
        public static int Dividir(int numero, int divisor)
        {
            try
            {
                 return numero / divisor;
            }
            catch(Exception)
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor = " + divisor);
                throw;
            }
            
        }
    }
}

