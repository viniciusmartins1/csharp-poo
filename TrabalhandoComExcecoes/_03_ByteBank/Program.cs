using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(667, 98887);
                ContaCorrente conta2 = new ContaCorrente(232, 32353);

                conta2.Transferir(-10, conta);
                conta.Depositar(50);

                Console.WriteLine(conta.Saldo);

                conta.Sacar(-500);

            }
            catch(ArgumentException ex)
            {
                if(ex.ParamName == "numero")
                {
                    
                }
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Excecao do tipo SaldoInsuficienteException");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Metodo();
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

