using Npgsql;

namespace captcha
{
    internal class UserProvider
    {
        private NpgsqlConnection connection;

        public UserProvider(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public bool isValidUser(string username, string password)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select * from users where \"login\"=@username and \"password\"=@password", connection);
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                reader.Close();
                return true;
            }
            else
            {
                connection.Close();
                reader.Close();
                return false;
            }
        }

        public bool isValidReg(string login)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select * from users where login=@login", connection);
            command.Parameters.AddWithValue("login", login);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return false;
            }
            else
            {
                reader.Close();
                connection.Close();
                return true;
            }
        }

        public bool addUser(string login, string password)
        {
            if (isValidReg(login))
            {
                connection.Open();
                var command1 = new NpgsqlCommand("INSERT INTO users (id, login, password) VALUES (nextval('user_id_seq'), @login, @password)", connection);
                command1.Parameters.AddWithValue("login", login);
                command1.Parameters.AddWithValue("password", password);
                int rowsAffected = command1.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
