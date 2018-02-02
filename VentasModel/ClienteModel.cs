using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace VentasModel
{
    public class ClienteModel
    {
        private int _IdCliente;

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }



        private string _NroIdentificacionCliente;

        public string NroIdentificacionCliente
        {
            get { return _NroIdentificacionCliente; }
            set { _NroIdentificacionCliente = value; }
        }

        private string _NombreCliente;

        public string NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }

        private string _ApellidoCliente;

        public string ApellidoCliente
        {
            get { return _ApellidoCliente; }
            set { _ApellidoCliente = value; }
        }

        private string _TelefonoCliente;

        public string TelefonoCliente
        {
            get { return _TelefonoCliente; }
            set { _TelefonoCliente = value; }
        }

       
    }//
}
