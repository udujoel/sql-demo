using System;
using System.Data.SqlClient;

namespace sqlTest {
    public class TestBank {

        public void ConnectToBankDB() {
            string conectionString = "Data Source=.;Initial Catalog=Console_Bank;Integrated Security=True";

            SqlConnection connection = new SqlConnection(conectionString);
            string query = "INSERT INTO customer_table VALUES(@firstname, @lastname,@username, @password)";
            SqlCommand command = new SqlCommand(query , connection);

            var firstname = "James";
            var lastname = "Bond";
            var username = "jamesbond";
            var password = "007";

            command.Parameters.AddWithValue("@firstname" , firstname);
            command.Parameters.AddWithValue("@lastname" , lastname);
            command.Parameters.AddWithValue("@username" , username);
            command.Parameters.AddWithValue("@password" , password);

            try {
                connection.Open();
                Console.WriteLine("Connection opened");
                int value = command.ExecuteNonQuery();

                }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
                //                throw;
                }
            finally {
                connection.Close();
                Console.WriteLine("Connection Closed");
                }
            }

        }
    }
