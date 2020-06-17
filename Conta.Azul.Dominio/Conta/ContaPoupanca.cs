using System;
using System.Collections.Generic;
using System.Text;
using Conta.Azul.Dominio.Contrato;
using Conta.Azul.Dominio.DespesasExtras;

using Conta.Azul.Dominio.Pessoas;

namespace Conta.Azul.Dominio.Conta
{
    public class ContaPoupanca : Contas
    {
        //private  IDespesas _despesas;

        public override double Depositar(decimal valor)
        {
           return Convert.ToDouble( this.Caixa += valor); 
        }

        public override double Pagar<T>(double valor)
        {
            var teste = new T();
            
           

            return valor;
        }

        public override double Sacar(decimal valor)
        {
            return Convert.ToDouble(this.Caixa -= valor);
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
