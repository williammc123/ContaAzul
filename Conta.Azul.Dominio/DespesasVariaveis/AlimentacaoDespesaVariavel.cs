using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasVariaveis
{
    public class AlimentacaoDespesaVariavel: IDespesasVariaveis
    {
        public decimal Supermercado { get; set; }
        public decimal Feira { get; set; }
        public decimal Padaria { get; set; }
        public decimal LojaBairro { get; set; }
    }
}
