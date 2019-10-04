using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public int LicznikRekordow(string mie,string ro)
        {
            string like = "'___" + mie + "." + ro + "'";
            string query = "SELECT COUNT(*) FROM sql7302398.miesiac WHERE data like " + like;
            int suma = 0;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
 
                //Create a data reader and Execute the command
                suma= int.Parse(cmd.ExecuteScalar().ToString());

            }
            this.CloseConnection();
            return suma;
        }


        public int WagaLicznikRekordow(string mie, string ro)
        {
            string like = "'___" + mie + "." + ro + "'";
            string query = "SELECT COUNT(*) FROM sql7302398.waga LEFT JOIN miesiac on miesiac.miesiac_Id=waga.miesiac_id  WHERE miesiac.data like " + like;
            int suma = 0;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                suma = int.Parse(cmd.ExecuteScalar().ToString());

            }
            this.CloseConnection();
            return suma;
        }

        public string[,] PobierzMiesiac(int wiersze,int kolumny,string mie, string ro )
        {

            string like = "'___" + mie + "." + ro + "'";
            string query = "SELECT miesiac.data as data, miesiac.dzien as dzien,waga.waga as waga, trening.dystans as dystans FROM miesiac LEFT JOIN waga on miesiac.miesiac_Id=waga.miesiac_id LEFT JOIN trening on miesiac.miesiac_Id = trening.miesiac_id WHERE miesiac.data like " + like ;
            //
            string[,] tablica = new string[wiersze, kolumny];

            //Open connection
            if (this.OpenConnection() == true)
            {
 
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "miesiac");

                int w = 0;
                int k = 0;

                

                foreach (DataTable myTable in ds.Tables)
                {
                    foreach (DataRow myRow in myTable.Rows)
                    {
                        foreach (DataColumn myColumn in myTable.Columns)
                        {
                            tablica[w, k] = myRow[myColumn].ToString();
                            k++;
                        }
                        k = 0;
                        w++;
                    }
                }

 
                connection.Close();
                
                //close Connection
                this.CloseConnection();
             }

            return tablica;
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

        public void InsertWaga(string dat)
        {
            string ciag;
            ciag = "";

            //open connection
            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(ciag, connection);
                //ciag = ;
                //create command and assign the query and connection from the constructor
                cmd.CommandText = "INSERT INTO waga (miesiac_id) SELECT miesiac.miesiac_Id FROM miesiac LEFT JOIN waga ON waga.miesiac_id=miesiac.miesiac_Id WHERE miesiac.data=@jakaData";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@jakaData", dat);
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void InsertDystans(string dat)
        {
            string ciag;
            ciag = "";

            //open connection
            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(ciag, connection);
                //ciag = ;
                //create command and assign the query and connection from the constructor
                cmd.CommandText = "INSERT INTO trening (miesiac_id) SELECT miesiac.miesiac_Id FROM miesiac LEFT JOIN trening ON trening.miesiac_id=miesiac.miesiac_Id WHERE miesiac.data=@jakaData";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@jakaData", dat);
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement

        public void UpdateWaga(string dat,double wag)
        {
            string ciag;
            ciag = "";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(ciag, connection);
                //ciag = ;
                //create command and assign the query and connection from the constructor
                cmd.CommandText = "UPDATE waga LEFT JOIN miesiac on waga.miesiac_id=miesiac.miesiac_Id SET waga.waga=@jakaWaga WHERE miesiac.data=@jakaData";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@jakaData", dat);
                cmd.Parameters.AddWithValue("@jakaWaga", wag);

                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void UpdateDystans(string dat, double dys)
        {
            string ciag;
            ciag = "";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(ciag, connection);
                //ciag = ;
                //create command and assign the query and connection from the constructor
                cmd.CommandText = "UPDATE trening LEFT JOIN miesiac on trening.miesiac_id=miesiac.miesiac_Id SET trening.dystans=@jakiDystans WHERE miesiac.data=@jakaData";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@jakaData", dat);
                cmd.Parameters.AddWithValue("@jakiDystans", dys);

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
        public double DystansCalkowity(string mies,string ro)
        {

            string like = "'___"+mies+"_"+ ro + "'";
            string query = "SELECT SUM(dystans) FROM trening LEFT JOIN miesiac ON miesiac.miesiac_id=trening.miesiac_id WHERE miesiac.data LIKE "+like;
            double Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                if (cmd.ExecuteScalar()!=DBNull.Value)
                {
                    Count = double.Parse(cmd.ExecuteScalar() + "");
                }
 
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }


        }

        public double Srednia(string mies, string ro)
        {

            string like = "'___" + mies + "_" + ro + "'";
            string query = "SELECT AVG(dystans) FROM trening LEFT JOIN miesiac ON miesiac.miesiac_id=trening.miesiac_id WHERE miesiac.data LIKE " + like;
            double Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    Count = double.Parse(cmd.ExecuteScalar() + "");
                }

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public double WagaMinimum(string mies, string ro)
        {

            string like = "'___" + mies + "_" + ro + "'";
            string query = "SELECT MIN(waga) FROM waga LEFT JOIN miesiac ON miesiac.miesiac_id=waga.miesiac_id WHERE miesiac.data LIKE " + like;
            double Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    Count = double.Parse(cmd.ExecuteScalar() + "");
                }

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public double WagaMax(string mies, string ro)
        {

            string like = "'___" + mies + "_" + ro + "'";
            string query = "SELECT MAX(waga) FROM waga LEFT JOIN miesiac ON miesiac.miesiac_id=waga.miesiac_id WHERE miesiac.data LIKE " + like;
            double Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    Count = double.Parse(cmd.ExecuteScalar() + "");
                }

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public double WagaSrednia(string mies, string ro)
        {

            string like = "'___" + mies + "_" + ro + "'";
            string query = "SELECT MAX(waga) FROM waga LEFT JOIN miesiac ON miesiac.miesiac_id=waga.miesiac_id WHERE miesiac.data LIKE " + like;
            double Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    Count = double.Parse(cmd.ExecuteScalar() + "");
                }

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
