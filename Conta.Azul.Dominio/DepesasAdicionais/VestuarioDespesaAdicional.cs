using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DepesasAdicionais
{
    public class VestuarioDespesaAdicional: IDespesasAdicionais
    {
        public decimal Roupa { get; set; }
        public decimal Calcados { get; set; }
        public decimal Acessorios { get; set; }
        public decimal Presentes { get; set; }
    }
}
