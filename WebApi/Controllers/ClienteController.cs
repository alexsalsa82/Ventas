using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VentasModel;

namespace WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        VentasCore.ClienteCore core = new VentasCore.ClienteCore();
        ClienteModel cli = new ClienteModel();
        // GET: api/Cliente
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NroIdentificacion"></param>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetClientebyNroidentificacion(string NroIdentificacion)
        {
            try
            {
                var lista = core.GetClientebyNroIdentificacion(NroIdentificacion);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Cliente/5
        [HttpGet]
        public DataTable Get(int id)
        {

            try
            {
                var lista = core.GetCliente(id);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Cliente
        public void Post(ClienteModel model)
        {
            int IdCliente;
            if (model.IdCliente > 0)
            {
                //llamar el core para actualizar 

                IdCliente = model.IdCliente;
                core.ModifyCliente(model);

            }
            else
            {
                //llamar el core para añadir
                core.AddCliente(model);
            }





        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {





        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
