using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using VentasModel;


namespace VentasDataAccess
{
    public class ClienteDAO
    {

        private const string config = "Server=E00093004;Database=Ventas;User ID = sa; Password=Alex1026138391;Trusted_Connection=False;Encrypt=False;Min Pool Size=0; Max Pool Size=400";
        private const string spGetCliente = "spGetCliente";
        private const string spGetClientebyNroIdentificacion = "spGetClientebyNroIdentificacion";
        private const string spUpdateCliente = "spUpdateCliente";
        private const string spInsertCliente = "spInsertCliente";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        public static DataTable GetCliente(int IdCliente)
        {

            Database db = new SqlDatabase(config);
            using (var dbCommand = db.GetStoredProcCommand(spGetCliente))
            {
                db.AddInParameter(dbCommand, "@IdCliente", DbType.Int32, IdCliente);
                using (var result = db.ExecuteDataSet(dbCommand).Tables[0])
                {
                    return result;
                }
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NroIdentificacion"></param>
        /// <returns></returns>
        public static DataTable GetClientebyNroIdentificacion(string NroIdentificacion)
        {


            Database db = new SqlDatabase(config);
            using (var dbCommand = db.GetStoredProcCommand(spGetClientebyNroIdentificacion))
            {
                db.AddInParameter(dbCommand, "@NroIdentificacion", DbType.String, NroIdentificacion);
                using (var result = db.ExecuteDataSet(dbCommand).Tables[0])
                {
                    return result;
                }
            }




        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NroIdentificacionCliente"></param>
        /// <param name="NombreCliente"></param>
        /// <param name="ApellidoCliente"></param>
        /// <param name="TelefonoCliente"></param>
        public static void ModifyCliente(ClienteModel model)
        {
            Database db = new SqlDatabase(config);
            using (var dbCommand = db.GetStoredProcCommand(spUpdateCliente))
            {
                db.AddInParameter(dbCommand, "@NroIdentificacionCliente", DbType.String, model.NroIdentificacionCliente);
                db.AddInParameter(dbCommand, "@NombreCliente", DbType.String, model.NombreCliente);
                db.AddInParameter(dbCommand, "@ApellidoCliente", DbType.String, model.ApellidoCliente);
                db.AddInParameter(dbCommand, "@TelefonoCliente", DbType.String, model.TelefonoCliente);
                db.ExecuteNonQuery(dbCommand);
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelocli"></param>
        public static void AddCliente(ClienteModel model) {
            Database db = new SqlDatabase(config);
            using (var dbCommand = db.GetStoredProcCommand(spInsertCliente))
            {
                db.AddInParameter(dbCommand, "@NroIdentificacionCliente", DbType.String, model.NroIdentificacionCliente);
                db.AddInParameter(dbCommand, "@NombreCliente", DbType.String, model.NombreCliente);
                db.AddInParameter(dbCommand, "@ApellidoCliente", DbType.String, model.ApellidoCliente);
                db.AddInParameter(dbCommand, "@TelefonoCliente", DbType.String, model.TelefonoCliente);
                db.ExecuteNonQuery(dbCommand);
            }


        }


    }
}



