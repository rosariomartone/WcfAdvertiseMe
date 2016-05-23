using System.Collections.Generic;

using Entities;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using Repository;

namespace Service
{
    public class PubService
    {
        public static List<IPub> GetPointsByGPSPosition(string connectionString, string storeProcName, string gpsPosition)
        {
            var sqlParams = new List<SqlParameter> { new SqlParameter("@GpsPosition", gpsPosition) };
            
            return DataTableHelper.MapDataTableToPubs(PubDatabase.GetDataSet(connectionString, storeProcName, sqlParams).Tables[0]);
        }
    }
}
