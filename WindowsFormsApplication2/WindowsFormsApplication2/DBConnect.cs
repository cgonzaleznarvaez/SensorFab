using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;
        private static int isEditor = 0;
        private static string loggedUser;
        public string state;

        public DBConnect()
        {
            server = "localhost";
            database = "sensorfab";
            uid = "root";
            password = "work4SEN";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connect(connectionString);
        }


        public string getConnection()
        {
            return connection.State.ToString();
        }

        public void connect(String connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public void insert()
        {
            string query = "INSERT INTO family (family_name) VALUES('volvo')";

            //open connection
            if (this.openConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.closeConnection();
            }
        }

        public void insert(String query)
        {
            //string query = "INSERT INTO family (family_name) VALUES('volvo')";

            //open connection
            if (this.openConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success?");
                //close connection
                this.closeConnection();
            }
        }

        public List<string>[] select()
        {
            string query = "SELECT * FROM family";

            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["family_id"] + "");
                    list[1].Add(dataReader["family_name"] + "");
                }
                dataReader.Close();

                this.closeConnection();

                return list;
            }
            else
                return list;
        }

        public List<string>[] selectEmployee(String user, String pass)
        {

            String query = "SELECT * FROM employee WHERE employee_id=1 AND password=1234";
            List<string>[] list = new List<string>[4];

            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //MessageBox.Show(query);
                //el read es como un pop cada que se usa
                while (dataReader.Read())
                {
                    //estas listas se manejan como vectores de 2 dimensiones
                    list[0].Add(dataReader["employee_id"] + "");
                    list[1].Add(dataReader["employee_name"] + "");
                    list[2].Add(dataReader["password"] + "");
                    list[3].Add(dataReader["editor"] + "");

                    if (dataReader["editor"].ToString() == "True")
                    {
                        loggedUser = dataReader["employee_name"].ToString();
                        isEditor = 1;
                    }
                    else
                        isEditor = 0;

                }
                
                dataReader.Close();

                this.closeConnection();
                return list;
            }
            return list;
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Open Connection");
                return true;
            }
            catch (MySqlException ex)
            {

                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                MessageBox.Show("Closed Connection");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static int getIsEditor()
        {
            return isEditor;
        }

        public static String getUserName()
        {
            return loggedUser;
        }

        public static void closeSession()
        {
            isEditor = 0;
        }
    }
}