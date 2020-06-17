using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasFixas
{
    public class SaudeDespesaFixa: IDespesasFixas
    {
        public decimal SeguroVida { get; set; }
        public decimal PlanoSaude { get; set; }
    }
}
