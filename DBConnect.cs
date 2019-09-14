using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace RTL
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string datasource;
        private string port;
        private string database;
        private string uid;
        private string password;
        public string[] arr = new string[4];
        public object lstMiesiac;


        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            datasource = "sql7.freesqldatabase.com";
            port = "3306";
            database = "sql7302398";
            uid = "sql7302398";
            password = "HsDmvTJ3Ar";
            string connectionString;
            connectionString = "DATASOURCE=" + datasource + ";"+"PORT="+port+";"+ "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"+ "convert zero datetime=True";

            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        private bool OpenConnection()
        {
                try
                {
                    connection.Open();
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

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string aNazwaTabeli,string aPola,string  aValues)
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            string query = "INSERT INTO "+aNazwaTabeli+" ("+aPola+") VALUES("+aValues+")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void WyswietlMiesiac(int rok,int mie)
        {
            string query = "SELECT miesiac.data as data, miesiac.dzien as dzien,waga.waga as waga FROM miesiac LEFT JOIN waga on miesiac.waga_Id=waga.waga_Id";

             //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        arr[0]=dataReader["data"].ToString();
                        arr[1]=dataReader["dzien"].ToString();
                        arr[2]=dataReader["waga"].ToString();
                    }
                    //close Data Reader
                    dataReader.Close();

                    ListViewItem itm;
                    for (int i = 1; i <= 30; i++)
                    {
                        //DateTime dt = new DateTime(DateTime.Now.Year, miesiac, i);
                        //arr[0] = dt.ToShortDateString();
                        //arr[1] = dt.ToString("dddd");
                        //arr[2] = "";
                        //arr[3] = "";
                        itm = new ListViewItem(arr);
                        lstMiesiac.Item.Add(itm);
    
                    }

                    //close Connection
                    this.CloseConnection();
                }
                else
                {
                    this.InsertNowyMiesiac(rok, mie);
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
                

                //return list to be displayed
                //return arr;
            }
            else
            {
                //return list;
            }
        }
        //Insert statement
        public void InsertNowyMiesiac(int jakirok,int jakimie)
        {
            int daysInMounth = System.DateTime.DaysInMonth(jakirok, jakimie);
            string liczdata;
            string liczdzien;
            string ciag;

            ciag= "";

            //open connection
            if (this.OpenConnection() == true)
            {
                for (int licz = 1; licz <= daysInMounth; licz++)
                {
                    MySqlCommand cmd = new MySqlCommand(ciag, connection);
                    //ciag = ;
                    //create command and assign the query and connection from the constructor
                    cmd.CommandText = "INSERT INTO miesiac (data,dzien) VALUES(@wpiszData,@wpiszDzien)";
                    cmd.Prepare();

                    DateTime dt = new DateTime(jakirok, jakimie, licz);
                    liczdata = dt.ToShortDateString();
                    liczdzien = dt.ToString("dddd");

                    cmd.Parameters.AddWithValue("@wpiszData", liczdata);
                    cmd.Parameters.AddWithValue("@wpiszDzien", liczdzien);

                    cmd.ExecuteNonQuery();
                }


                //close connection
                this.CloseConnection();
            }
        }
        

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
