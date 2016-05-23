using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DataAccess
{
    public class PubDatabase
    {
        public static DataSet GetDataSet(string connectionString, string storedProcedureName, IEnumerable<SqlParameter> parameterCollection)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;
                    command.CommandTimeout = 600;
                    command.Parameters.Clear();
                    if (parameterCollection != null)
                    {
                        foreach (var parameter in parameterCollection)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }

                    using (var adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = command;

                        var ds = new DataSet { Locale = CultureInfo.InvariantCulture };
                        adapter.Fill(ds);
                        connection.Close();
                        return ds;
                    }
                }
            }
        }
    }
}
