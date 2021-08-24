using System;

namespace _03_ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
        }

        public OperacaoFinanceiraException(string messagem) : base(messagem)
        {
        }

        public OperacaoFinanceiraException(string messagem, Exception excecaoInterna) 
            : base(messagem, excecaoInterna)
        {
        }
    }
}