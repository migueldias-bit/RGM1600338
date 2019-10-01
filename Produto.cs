using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREGM1600338
{
    class Produto : ItenPedido
    {
        public string NomeProduto {get; set;}
        public int Peso {get; set;}
        public int QtdeDisponivel {get; set;}

        private Produto ConsultarProduto()
        {
            
        }
    }
}