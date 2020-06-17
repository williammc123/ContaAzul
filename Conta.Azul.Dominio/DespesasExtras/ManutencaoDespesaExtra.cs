using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasExtras
{
    public class ManutencaoDespesaExtra:Despesa
    {
        public string Carro { get; set; }
        public string Casa { get; set; }
    }
}
