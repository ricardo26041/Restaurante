using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public  class cls_facturaspedidos
    {
        private int int_ultima;
        public void fnt_pedido(string id_cliente, int valor)
        {
            Datos.cls_facturacion obj_pedido = new Datos. cls_facturacion();
            obj_pedido.fnt_Registrar_Enc_pedidos( id_cliente,  valor);
            this.int_ultima = obj_pedido.getUltimopedido();
        }
        public void fnt_pedidos1(int pedido, double valor, int cantidad, int codigo)
        {
            Datos.cls_facturacion obj_Det_producto = new Datos.cls_facturacion();
            obj_Det_producto.fnt_Det_pedidos( pedido, valor, cantidad, codigo);
        }
        public int getUltimaFactura() { return int_ultima; }
    }
}
