using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio
{
    public class Despesa: IDespesas
    {
        public decimal Valor { get; set; }
    }
}
