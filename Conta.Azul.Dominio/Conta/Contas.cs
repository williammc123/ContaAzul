using Conta.Azul.Dominio.Contrato;
using Conta.Azul.Dominio.DespesasExtras;
using Conta.Azul.Dominio.Pessoas;

namespace Conta.Azul.Dominio.Conta
{
    public abstract class Contas: ClasseBase
    {
        public string Instituicao { get; set; }
        public string Numero { get; set; }       
        public string Agencia { get; set; }
        public Pessoa Titular { get; set; }
        public decimal Caixa { get; set; }

        public abstract double Depositar(decimal valor);

        public abstract double Sacar(decimal valor);

        public abstract double Transferir(decimal valor, Pessoa pessoa);

        public abstract double Pagar<T>(double valor) where T : Despesa, new();

        public abstract double Saldo();

    }
}
