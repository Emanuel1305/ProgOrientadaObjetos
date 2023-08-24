using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class CartaoDeCredito
    {
        public string numeroCart;
        public string dtValidadeCart;
        public Cliente cliente;

        public CartaoDeCredito(string numeroCart)
        {
            this.numeroCart = numeroCart;
        }
    }
}
