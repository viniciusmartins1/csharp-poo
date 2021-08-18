using ByteBank.Funcionarios;

namespace ByteBank.Sistema
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);

    }
}