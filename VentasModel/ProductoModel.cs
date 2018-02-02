using System;
using System.Collections.Generic;
using System.Text;

namespace VentasModel
{
    public class ProductoModel
    {

        private int _IdProducto;

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        private string _CodigoProducto;

        public string CodigoProducto
        {
            get { return _CodigoProducto; }
            set { _CodigoProducto = value; }
        }


        private string _NombreProducto;

        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }

        private float _ValorProducto;

        public float ValorProducto
        {
            get { return _ValorProducto; }
            set { _ValorProducto = value; }
        }

    }//
}
