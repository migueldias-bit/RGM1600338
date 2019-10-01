using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREGM1600338

{
    class Pessoa : Cliente
    {
        public string Nome {get; set;}
        public DateTime DataNasc {get; set;}

        private int CalculaIdade()
        {
            
        }
    }
}