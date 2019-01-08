using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Funcoes
    {
        public static string toString(object valor)
        {
            if (valor.ToString() == "" || valor == null)
            {
                return "";
            }
            return valor.ToString();
        }
    }
}
