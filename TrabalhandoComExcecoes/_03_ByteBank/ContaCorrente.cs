using System;


namespace _03_ByteBank
{
   public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular{ get; set; }
        public static int TotalDeContasCriadas{get; private set;}
        public int Agencia {get;}
        public int Numero{get;}
        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        public ContaCorrente(int agencia, int numero)
        {

            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento Agencia não é maior que 0", nameof(agencia));
            }

            if(numero <= 0)
            {
                throw new ArgumentException("O argumento Número não é maior que 0", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        public bool Sacar(double valor)
        {
            if(_saldo < valor)
            {
                return false;
            } 
           
            _saldo -= valor;
            return true;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(_saldo < valor){
                return false;
            }
         
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
            
        }
    }
 
}
    