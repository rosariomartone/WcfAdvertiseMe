using System.Collections.Generic;

using Entities;
using DataAccess;
using System.Data.SqlClient;
using Repository;
using log4net;
using System.Reflection;
using System;
using System.Data;

namespace Service
{
    public class PubService
    {
        readonly static ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static List<IPub> GetPointsByGPSPosition(string connectionString, string storeProcName, string gpsPosition)
        {
            List<SqlParameter> sqlParams = null;
            DataSet ds = null;

            try
            {
                sqlParams = new List<SqlParameter> { new SqlParameter("@GpsPosition", gpsPosition) };
                ds = PubDatabase.GetDataSet(connectionString, storeProcName, sqlParams);
            }
            catch(Exception ex)
            {
                Utilities.LogManager.LogError(ex, "Service", "PubService", "GetPointsByGPSPosition", ex.Message);
            }

            if (ds != null)
                return DataTableHelper.MapDataTableToPubs(ds.Tables[0]);
            else
                return null;
        }
    }
}
