using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasFixas
{
    public class TransporteDespesaFixa : IDespesasFixas
    {
        public decimal PrestacaoCarro { get; set; }
        public decimal SeguroCarro { get; set; }
        public decimal Estacionamento { get; set; }
    }
}
