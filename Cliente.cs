using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREGM1600338

{
    public class Cliente : Pedido
    {
         public double LimiteCredito { get; set; }
        public int CartaoCredito { get; set; }
        public string Contato { get; set; }
        public Boolean Status { get; set; }


        private string VerificaCredito()
        {

        }

        private string ValidaCartao()
        {

        }
    }

}