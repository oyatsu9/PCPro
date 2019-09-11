using System.Data;
using System.Data.SqlClient;

namespace PCPRo商店.UI
{
    public class DBManager
    {
        private const string _connectionString = "※　接続文字列";

        public DataTable GetTable(string strSql, params SqlParameter[]  parameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }

                    command.CommandText = strSql;

                    var table = new DataTable();

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);

                        return table;
                    }
                }

            }
        }
    }
}
