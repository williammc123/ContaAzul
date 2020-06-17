using System;
using System.Collections.Generic;
using System.Text;
using Conta.Azul.Dominio.Pessoas;

namespace Conta.Azul.Dominio.Conta
{
    public class ContaCorrente : Contas
    {
        public override double Depositar(decimal valor)
        {
            throw new NotImplementedException();
        }

     

        public override double Pagar<T>(double valor)
        {
            throw new NotImplementedException();
        }

        public override double Sacar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override double Saldo()
        {
            throw new NotImplementedException();
        }

        public override double Transferir(decimal valor, Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
