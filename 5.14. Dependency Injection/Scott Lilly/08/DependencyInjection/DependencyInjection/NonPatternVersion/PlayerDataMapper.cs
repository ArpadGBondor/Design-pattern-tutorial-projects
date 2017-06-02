using System;
using System.Data;
using System.Data.SqlClient;

namespace DependencyInjection.NonPatternVersion
{
    public  class PlayerDataMapper
    {
        private readonly string _connectionString =
            "Sata Source = (local);Initial Catalog=MyGame;Integrated Security=True";
        public bool PlayerNameExistInDatabase(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand playersWithThisName = connection.CreateCommand())
                {
                    playersWithThisName.CommandType = CommandType.Text;
                    playersWithThisName.CommandText = "SELECT count(*) FROM Player WHERE 'Name' = @Name";

                    playersWithThisName.Parameters.AddWithValue("@Name", name);

                    // Get the number of players with this name
                    var existingRowCount = (int)playersWithThisName.ExecuteScalar();

                    // Result is a 0, if no player exists, or 1, if a player already exists
                    return existingRowCount > 0;

                }
            }
        }

        public void InsertNewPlayerIntoDatabase(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand playersWithThisName = connection.CreateCommand())
                {
                    playersWithThisName.CommandType = CommandType.Text;
                    playersWithThisName.CommandText = "INSERT INTO Player ([Name]) VALUES (@Name)";

                    playersWithThisName.Parameters.AddWithValue("@Name", name);

                    playersWithThisName.ExecuteNonQuery();
                }
            }
        }
    }
}