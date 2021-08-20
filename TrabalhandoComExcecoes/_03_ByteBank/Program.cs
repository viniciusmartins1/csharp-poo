using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 838973979);

            //Console.WriteLine(conta.Agencia);
            //Console.WriteLine(conta.Numero);


            string nome = "vinicius";

            for(int i = nome.Length - 1; i >= 0; i--)
            {
                //Console.Write(nome[i]);
            }

            int num1=0, num2=1, aux;

            for (int i = 0; i​​​​​​​ < 10; i++)
            {
                aux=num1;
                num1 = num2;
                num2 = num1 + aux;
                Console.WriteLine("{0}", num2);

            }
        }
    }
}
