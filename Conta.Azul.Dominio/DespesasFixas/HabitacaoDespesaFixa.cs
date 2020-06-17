using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasFixas
{
    public class HabitacaoDespesaFixa: IDespesasFixas
    {
        public decimal Aluguel { get; set; }
        public decimal Condominio { get; set; }
        public decimal PrestacaoCasa { get; set; }
        public decimal Seguro { get; set; }
        public decimal Diarista { get; set; }
        public decimal Mensalista { get; set; }
    }
}
