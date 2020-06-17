using Conta.Azul.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio
{
    //public class TipoDespesa<T> : ITipoDespesa<T> where T : class
    //{

    //    public T GetT(T classe)
    //    {
    //        return classe;
    //    }
    //}

    public class TipoDespesa <T> : ITipoDespesa<T>  where T : class, new()
    {

        public T GetT(T classe)
        {
            return classe;
        }
    }
}
