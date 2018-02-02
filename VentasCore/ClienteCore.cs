using System;
using System.Collections.Generic;
using System.Text;
using VentasModel;
using System.Data;
using VentasDataAccess;


namespace VentasCore
{
    public class ClienteCore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        public DataTable GetCliente(int IdCliente) {

            try
            {
                DataTable tabla = VentasDataAccess.ClienteDAO.GetCliente(IdCliente);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NroIdentificacion"></param>
        /// <returns></returns>
        public DataTable GetClientebyNroIdentificacion(string NroIdentificacion) {

            try
            {
                DataTable tabla = VentasDataAccess.ClienteDAO.GetClientebyNroIdentificacion(NroIdentificacion);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NroIdentificacionCliente"></param>
        /// <param name="NombreCliente"></param>
        /// <param name="ApellidoCliente"></param>
        /// <param name="TelefonoCliente"></param>
        public void ModifyCliente(ClienteModel model) {

            try
            {
                VentasDataAccess.ClienteDAO.ModifyCliente(model);
            }
            catch (Exception)
            {

                throw;
            }



        }

        public void AddCliente(ClienteModel model)
        {
            try
            {
                VentasDataAccess.ClienteDAO.AddCliente(model);
            }
            catch (Exception)
            {

                throw;
            }


        }

    }//FIN CLASE
}
