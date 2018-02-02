using System;
using System.Collections.Generic;
using System.Text;

namespace VentasModel
{
    public class VentaModel
    {
        private int _IdVenta;

        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }
        private int _IdProducto;

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }
        private int _IdCliente;

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private float _Cantidad;

        public float Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }


    }
}
