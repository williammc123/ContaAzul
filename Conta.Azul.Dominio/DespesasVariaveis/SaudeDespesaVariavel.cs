using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasVariaveis
{
    public class SaudeDespesaVariavel: IDespesasVariaveis
    {
        public decimal Medicamentos { get; set; }
    }
}
