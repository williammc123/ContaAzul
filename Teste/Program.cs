using Conta.Azul.Dominio.Conta;
using Conta.Azul.Dominio.DespesasExtras;
using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor = 10;
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            var resposta = contaPoupanca.Pagar<ManutencaoDespesaExtra>(valor);
        }
    }
}
