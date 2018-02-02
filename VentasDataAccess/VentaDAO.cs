using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using VentasModel;

namespace VentasDataAccess
{
    public class VentaDAO
    {
        private const string Config = "ConnectionStringNameInWeb.ConfigFile";

        public List<VentaModel> GetAllVenta()
        {
            Database db = DatabaseFactory.CreateDatabase(Config);
            DbCommand dbCommand = db.GetStoredProcCommand("spGetVentaAll");

            List<VentaModel> list = new List<VentaModel>();

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader.Read())
                {

                    VentaModel obj = new VentaModel();

                    if (dataReader["IdVenta"] != DBNull.Value) { obj.IdVenta = (int)dataReader["IdVenta"]; }
                    if (dataReader["IdProducto"] != DBNull.Value) { obj.IdProducto = (int)dataReader["IdProducto"]; }
                    if (dataReader["IdCliente"] != DBNull.Value) { obj.IdCliente = (int)dataReader["IdCliente"]; }
                    if (dataReader["Cantidad"] != DBNull.Value) { obj.Cantidad = (float)dataReader["Cantidad"]; }

                    list.Add(obj);

                }

            }

            return list;

        }

        public bool InsertVenta(long IdVenta, long IdProducto, long IdCliente, double Cantidad)
        {
            Database db = DatabaseFactory.CreateDatabase(Config);
            DbCommand dbCommand = db.GetStoredProcCommand("spInsertVenta");

            db.AddInParameter(dbCommand, "IdVenta", DbType.Int64, IdVenta);
            db.AddInParameter(dbCommand, "IdProducto", DbType.Int64, IdProducto);
            db.AddInParameter(dbCommand, "IdCliente", DbType.Int64, IdCliente);
            db.AddInParameter(dbCommand, "Cantidad", DbType.Double, Cantidad);

            return (db.ExecuteNonQuery(dbCommand) == 1);
        }



        public bool UpdateVenta(long IdVenta, long IdProducto, long IdCliente, double Cantidad)
        {
            Database db = DatabaseFactory.CreateDatabase(Config);
            DbCommand dbCommand = db.GetStoredProcCommand("spUpdateVenta");

            db.AddInParameter(dbCommand, "IdVenta", DbType.Int64, IdVenta);
            db.AddInParameter(dbCommand, "IdProducto", DbType.Int64, IdProducto);
            db.AddInParameter(dbCommand, "IdCliente", DbType.Int64, IdCliente);
            db.AddInParameter(dbCommand, "Cantidad", DbType.Double, Cantidad);

            return (db.ExecuteNonQuery(dbCommand) == 1);
        }
    }
}
