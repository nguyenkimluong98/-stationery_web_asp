using System.Data;
using System.Data.SqlClient;

namespace BTL_ASP
{
    public class DAL
    {
        private string connectionStr = @"Data Source=LUONGNGUYEN;Initial Catalog=VPP;Integrated Security=True";

        private static DAL instance;

        public static DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL();
                return instance;
            }
        }

        private DAL() { }

        public DataTable ExercuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }

        public int ExercuteNonQuery(string query)
        {
            int success = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                success = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return success;
        }

        public object ExercuteScalar(string query)
        {
            object success = null;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                success = cmd.ExecuteScalar();
                connection.Close();
            }
            return success;
        }
    }
}