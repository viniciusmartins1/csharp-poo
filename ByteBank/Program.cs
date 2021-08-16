using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("242.324.564-12");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("455.546.233-45");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("562.574.534-56");
            igor.Nome = "Igor";

            Funcionario camila = new  GerenteDeConta("523.352.452-54");
            camila.Nome = "Camila";

            Funcionario vinicius = new Desenvolvedor("453.453.123-53");
            vinicius.Nome = "Vinicius";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(vinicius);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.GetTotalBonificacao());


        }
    }
}
