using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios{get; private set;}
        public string Nome{get; set;}
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;

            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionarios++;
        }

    public abstract void AumentarSalario();
   
    public abstract double GetBonificacao();
      
    }
}