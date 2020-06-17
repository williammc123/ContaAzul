using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasExtras
{
    public class SaudeDespesasExtra: IDespesasExtras
    {
        public decimal Medico { get; set; }
        public decimal Dentista { get; set; }
        public decimal Hospital { get; set; }
    }
}
