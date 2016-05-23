using Entities;
using FactoryEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Repository
{
    public static class DataTableHelper
    {
        public static int? GetIntFromDataRow(DataRow dataRow, string columnName)
        {
            if (!ColumnNameExistsInDataRow(dataRow, columnName))
                return 0;

            return !String.IsNullOrEmpty(dataRow[columnName].ToString()) ? Convert.ToInt32(dataRow[columnName]) : (int?)null;
        }

        public static string GetStringFromDataRow(DataRow dataRow, string columnName)
        {
            if (!ColumnNameExistsInDataRow(dataRow, columnName))
                return null;

            return !String.IsNullOrEmpty(dataRow[columnName].ToString()) ? dataRow[columnName].ToString().Trim() : null;
        }

        public static bool ColumnNameExistsInDataRow(DataRow dataRow, string columnName)
        {
            return dataRow.Table.Columns.Contains(columnName);
        }

        public static bool IsDataTableNullOrEmpty(DataTable dataTable)
        {
            return (dataTable == null || dataTable.Rows.Count == 0);
        }

        public static List<IPub> MapDataTableToPubs(DataTable data)
        {
            var pubs = new List<IPub>();

            if (DataTableHelper.IsDataTableNullOrEmpty(data))
                return pubs;

            foreach (DataRow row in data.Rows)
            {
                pubs.Add(MapDataRowToPub(row));
            }

            return pubs;
        }

        public static IPub MapDataRowToPub(DataRow row)
        {
            IPub obj = FactoryPub.CreateInstance();
            obj.Name = DataTableHelper.GetStringFromDataRow(row, "Name");
            obj.Url = DataTableHelper.GetStringFromDataRow(row, "Url");
            obj.Address = DataTableHelper.GetStringFromDataRow(row, "Address");
            obj.Username = Thread.CurrentPrincipal.Identity.Name;

            return obj;
        }

    }
}
