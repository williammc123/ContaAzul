using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.Pessoas
{
    public class Pessoa : ClasseBase
    {
        public Pessoa(string nome, string cPF)
        {
            Validacao.Validation.AssertArgumentNotEmpty(nome, "Por favor digite um nome");
            Validacao.Validation.AssertArgumentNotNull(cPF, "Por favor digite um CPF");

            Nome = nome;
            CPF = cPF;
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

    }
}
