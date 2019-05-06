using System.Data;
using System.Data.SqlClient;

namespace smcs.backend.data.access
{
    internal class SqlProvider
    {
        internal static DataTable ExecuteDataTable(string QueryString)
        {
            using (var con = new SqlConnection(ConStrProvider.GetEndUserConStr()))
            {
                con.Open();

                DataTable DataTable = new DataTable();
                SqlDataAdapter sd = new SqlDataAdapter(QueryString, con);
                sd.Fill(DataTable);
                return DataTable;
            }
        }

        internal static DataSet ExecuteDataSet(string QueryString)
        {
            using (var con = new SqlConnection(ConStrProvider.GetEndUserConStr()))
            {
                con.Open();

                DataSet dataSet = new DataSet();
                SqlDataAdapter sd = new SqlDataAdapter(QueryString, con);
                sd.Fill(dataSet);
                return dataSet;
            }
        }

        internal static void ExecuteNonQuery(string QueryString)
        {
            using (var con = new SqlConnection(ConStrProvider.GetEndUserConStr()))
            {
                con.Open();

                var command = new SqlCommand(QueryString, con);
                command.ExecuteNonQuery();
            }
        }

        internal static string ExecuteScalar(string QueryString)
        {
            using (var con = new SqlConnection(ConStrProvider.GetEndUserConStr()))
            {
                con.Open();

                var command = new SqlCommand(QueryString, con);
                return command.ExecuteScalar().ToString();
            }
        }
    }
}
