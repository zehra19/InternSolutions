using System.Data;
using System.Data.SqlClient;

namespace SosyalYardimApi.Operations
{

    public class DbOperations
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        SqlConnection _conn;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        private void ConnectDb()
        {
            string connectionString = "Server=localhost; Database=SosyalYardim; Integrated Security=True";

            _conn = new SqlConnection(connectionString);
            _conn.Open();
        }

        private void DisconnectDb()
        {
            if (_conn.State == ConnectionState.Open)
                _conn.Close();
        }

        public DataTable GetData(string spName, List<SqlParameter> parameters)
        {
            DataTable dtResult = new();

            try
            {
                ConnectDb();

                using SqlCommand cmd = new(spName, _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (var item in parameters)
                {
                    cmd.Parameters.Add(item);
                }

                var da = new SqlDataAdapter(cmd);
                da.Fill(dtResult);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DisconnectDb();
            }


            return dtResult;
        }

        internal void ExecuteNonQuery(string spName, List<SqlParameter> parameters)
        {
            try
            {
                ConnectDb();

                SqlCommand cmd = new(spName, _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (var item in parameters)
                {
                    SqlParameter sqlParameter = cmd.Parameters.Add(item);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DisconnectDb();
            }
        }

    }

}
