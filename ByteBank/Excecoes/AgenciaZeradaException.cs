using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Excecoes
{
    internal class AgenciaZeradaException : Exception
    {
        public AgenciaZeradaException()
        {

        }
        public AgenciaZeradaException(string mensagem) : base(mensagem)
        {

        }
    }
}
