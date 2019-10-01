using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREGM1600338
{

    public class ItenPedido : Pedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        private int IncluirItem()
        {

        }

         private int ExcluirItem()
        {
            
        }
    }
}