using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasFixas

{
    public class EducacaoDespesaFixa: IDespesasFixas
    {
        public decimal Colegio { get; set; }
        public decimal Faculdade { get; set; }
        public decimal Curso { get; set; }
    }
}
