using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREGM1600338
{
    public class Pedido
    {
        
         public int ID { get { return ID; } set { ID = value; } }
        public DateTime DataPedido { get; set; }
        public string Vendedor { get; set; }
        public Boolean Status { get; set; }
        public string Observacoes { get; set; }

        public void EncerrarPedido()
        {

        }

        public void CancelarPedido()
        {

        }

        public void CriarPedido()
        {

        }
    }

}