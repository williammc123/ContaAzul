using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.Despesas
{
    public class HabitacaoDespesasVariavel: IDespesasVariaveis
    {
        public decimal Energia { get; set; }
        public decimal Agua { get; set; }
        public decimal Telefone { get; set; }
        public decimal Gas { get; set; }
        public decimal Tv { get; set; }
        public decimal Netflix { get; set; }
        public decimal Spotfy { get; set; }
        public decimal Internet { get; set; }
    }
}
