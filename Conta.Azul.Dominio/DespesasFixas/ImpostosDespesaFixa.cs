using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasFixas
{
    public class ImpostosDespesaFixa: IDespesasFixas
    {
        public decimal IPTU { get; set; }
        public decimal IPVA { get; set; }    
    }
}
