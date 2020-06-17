using Conta.Azul.Dominio.Conta;
using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasExtras
{
    public class EducacaDespesaExtra: IDespesas
    {
        public decimal MaterialEscolar { get; set; }
        public decimal Uniforme { get; set; }

       
        public void Teste()
        {
            var valor = 10;
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Pagar<ManutencaoDespesaExtra>(valor);
        }
    }
}
