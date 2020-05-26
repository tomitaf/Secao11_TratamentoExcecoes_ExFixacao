using System;
using System.Collections.Generic;
using System.Text;

namespace Secao11_TratamentoExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem)
        {
        }
    }
}
