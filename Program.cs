namespace sqlTest {
    class Program {
        static void Main(string[] args) {

            TestBank myConn = new TestBank();
            myConn.ConnectToBankDB();
            }
        }
    }
