using System.Data.SqlClient;

namespace sqlTest {
    public class TestBank {

        public void ConnectToBankDB() {
            string conectionString = "Data Source=.;Initial Catalog=Console_Bank;Integrated Security=True;";

            SqlConnection connection = new SqlConnection(conectionString);
            string query = "INSERT INTO customer_table VALUE (@firstname, @lastname,@username, @password)";
        }
        }
    }
