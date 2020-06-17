using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.DespesasVariaveis
{
    public class CuidadospessoaisDespesaVariavel : IDespesasVariaveis
    {
        public decimal Cabeleireiro { get; set; }
        public decimal Manicure { get; set; }
        public decimal Estetica { get; set; }
        public decimal Academia { get; set; }
        public decimal Clube { get; set; }
    }
}
