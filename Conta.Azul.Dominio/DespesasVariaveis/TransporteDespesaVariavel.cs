using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.Despesas
{
    public class TransporteDespesaVariavel: IDespesasVariaveis
    {
        public decimal Metro { get; set; }
        public decimal Onibus { get; set; }
        public decimal Combustivel { get; set; }
        public decimal Estacionamento { get; set; }
    }
}
