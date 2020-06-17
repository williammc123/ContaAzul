using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DepesasAdicionais
{
    public class LazerDespesaAdicional : IDespesas
    {
        public decimal Viagem { get; set; }
        public decimal Cinema { get; set; }
        public decimal Teatro { get; set; }
        public decimal Restaurante { get; set; }
        public decimal Bar { get; set; }

    }
}
