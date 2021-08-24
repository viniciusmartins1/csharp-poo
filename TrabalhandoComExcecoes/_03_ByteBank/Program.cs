using System;
using System.IO;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;

            try
            {
                leitor = new LeitorDeArquivo("conta.txt");


                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

            }
            catch(IOException)
            {
                
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");

            }
            finally
            {
                if(leitor != null)
                {
                    leitor.Fechar();
                }
                
            }
            
        }

        private static void TestaInnerException()
        {
             try
            {
                ContaCorrente conta1 = new ContaCorrente(2341, 3412341);
                ContaCorrente conta2 = new ContaCorrente(3432, 342422);

                //conta1.Transferir(100000, conta2);
                conta1.Sacar(100000);

            }
            catch(OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch(DivideByZeroException)
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

