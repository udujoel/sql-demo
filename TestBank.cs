using System;
using System.Data.SqlClient;

namespace sqlTest {
    public class TestBank {

        public void ConnectToBankDB() {
            string conectionString = "Data Source=.;Initial Catalog=Console_Bank;Integrated Security=True";

            SqlConnection connection = new SqlConnection(conectionString);
            //            string InsertQuery = "INSERT INTO customer_table VALUES(@firstname, @lastname,@username, @password)";
            string SelectQuery = "SELECT * FROM customer_table";
            //            SqlCommand sqlInsertCommand = new SqlCommand(InsertQuery , connection);
            SqlCommand sqlSelectCommand = new SqlCommand(SelectQuery , connection);

            string firstname = "";
            string lastname = "";
            string username = "";
            string password = "";
            int id;
            //
            //            Console.WriteLine("\n\n\n");
            //
            //            Console.WriteLine("Firstname: ");
            //            firstname = Console.ReadLine();
            //
            //            Console.WriteLine("Lastname: ");
            //            lastname = Console.ReadLine();
            //
            //            Console.WriteLine("Username: ");
            //            username = Console.ReadLine();
            //
            //            Console.WriteLine("Password: ");
            //            password = Console.ReadLine();
            //
            //            Console.WriteLine("Press enter to insert to DB");
            //            Console.ReadKey();
            //
            //
            //
            //            sqlInsertCommand.Parameters.AddWithValue("@firstname" , firstname);
            //            sqlInsertCommand.Parameters.AddWithValue("@lastname" , lastname);
            //            sqlInsertCommand.Parameters.AddWithValue("@username" , username);
            //            sqlInsertCommand.Parameters.AddWithValue("@password" , password);

            try {
                connection.Open();
                Console.WriteLine("Connection opened");
                //                int value = sqlInsertCommand.ExecuteNonQuery();
                SqlDataReader reader = sqlSelectCommand.ExecuteReader();

                while (reader.Read()) {
                    id = reader.GetInt32(0);
                    firstname = reader.GetString(1);
                    lastname = reader.GetString(2);
                    username = reader.GetString(3);
                    password = reader.GetString(4);

                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine($"Firstname: {firstname}");
                    Console.WriteLine($"Lastname: {lastname}");
                    Console.WriteLine($"Username: {username}");
                    Console.WriteLine($"Password: {password}");
                    }

                Console.ReadKey();


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
