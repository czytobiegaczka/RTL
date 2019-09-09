using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace RTL
{
    public partial class frmRTL : Form
    {
        public int ileWag;
        public double wmin;

        public frmRTL()
        {
            InitializeComponent();
        }

        MySqlConnection connection;
        private void Form1_Load(object sender, EventArgs e)
        {
            // ustawia rok i miesiąc na aktualny
            comRok.Text = DateTime.Now.Year.ToString();
            //sprawdza aktualny miesiąc
            int miesiac = DateTime.Now.Month;
            int days = DateTime.DaysInMonth(DateTime.Now.Year, miesiac);
            string nazmie = NazwaMiesiaca(miesiac);
            comMiesiac.Text = nazmie;

            lblMiesiacRok.Text = nazmie + " " + DateTime.Now.Year.ToString() + " r.";

            //Inicjalizacja listy miesięcznej

            lstMiesiac.View = View.Details;
            lstMiesiac.GridLines = true;
            lstMiesiac.FullRowSelect = true;

            //Add column header
            lstMiesiac.Columns.Add("Data", 150, HorizontalAlignment.Center);
            lstMiesiac.Columns.Add("Dzień tygodnia", 150, HorizontalAlignment.Left);
            lstMiesiac.Columns.Add("Waga", 100, HorizontalAlignment.Right);
            lstMiesiac.Columns.Add("Dystans", 100, HorizontalAlignment.Right);



            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            for (int i = 1; i <= days; i++)
            {
                DateTime dt = new DateTime(DateTime.Now.Year, miesiac, i);
                arr[0] = dt.ToShortDateString();
                arr[1] = dt.ToString("dddd");
                arr[2] = "";
                arr[3] = "";
                itm = new ListViewItem(arr);
                lstMiesiac.Items.Add(itm);           }

            // otwarcie sesji bazy danych
            try
            {
                connection = new MySqlConnection("datasource=sql7.freesqldatabase.com;port=3306;username=sql7302398;password=HsDmvTJ3Ar;convert zero datetime=True");

                //DBConnect polaczenie;
                //polaczenie = new DBConnect();

               
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from sql7302398.waga", connection);
                MySqlCommand sumaDystans = new MySqlCommand("select sum(dystans) from sql7302398.waga", connection);
                MySqlCommand licznikRekordow = new MySqlCommand("select count(*) from sql7302398.waga", connection);
                

                string selectRok = "select sum(dystans) from sql7302398.waga where data>\"" + DateTime.Now.Year.ToString() + "-08-15\""; //UWAGA! Zmienić na 01-01
                MySqlCommand sumaDystansRok = new MySqlCommand(selectRok, connection);

                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "waga");

                string licznikcalkowity = Convert.ToString(sumaDystans.ExecuteScalar());
                lblDystansCalkowity.Text = "Dystans przebiegnięty od 12 marca 2011 roku - " + licznikcalkowity + " km";

                string licznikRok = Convert.ToString(sumaDystansRok.ExecuteScalar());
                lblCalkowityNaRok.Text = "Dystans przebiegnięty w " + DateTime.Now.Year.ToString() + " roku - " + licznikRok + " km";

                lblDzienzTabeli.Text = lstMiesiac.Items[0].SubItems[0].Text;

                int w = 1;
                int k = 1;


                int licznikWierszy = Convert.ToInt16(licznikRekordow.ExecuteScalar())+1;
                int licznikKolumn = 4 + 1;

                string[,] tablica = new string[licznikWierszy, licznikKolumn];

                foreach (DataTable myTable in ds.Tables)
                {
                    foreach (DataRow myRow in myTable.Rows)
                    {
                        foreach (DataColumn myColumn in myTable.Columns)
                        {
                            tablica[w, k] = myRow[myColumn].ToString();
                            k++;
                        }
                        k = 1;
                        w++;
                    }
                }
                connection.Close();


                ileWag = 0;
                for (int i = 1; i < licznikWierszy; i++)
                {
                    string data = tablica[i, 2];
                    DateTime znowudata = DateTime.Parse(data);
                    int ktory = znowudata.Day;
                    lstMiesiac.Items[ktory-1].SubItems[2].Text = tablica[i, 3];
                    lstMiesiac.Items[ktory-1].SubItems[3].Text = tablica[i, 4];
                    if(tablica[i, 3]!="")
                    {
                        ileWag++;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnWyjscie_Click(object sender, EventArgs e)
        {
            connection.Close();
        }


        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void LstMiesiac_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblDzienzTabeli.Text = lstMiesiac.SelectedItems[0].SubItems[0].Text + " " + lstMiesiac.SelectedItems[0].SubItems[1].Text;

                lblOpisDystans.Visible = true;
                lblOpisWaga.Visible = true;
                txtDystansDzien.Visible = true;
                txtWagaDzien.Visible = true;
                txtDystansDzien.Enabled = true;
                txtWagaDzien.Enabled = true;
                btnZapiszDystans.Visible = true;

            if (lstMiesiac.SelectedItems[0].SubItems[3].Text != "")
            {
                txtDystansDzien.Text = lstMiesiac.SelectedItems[0].SubItems[3].Text;
                txtWagaDzien.Text = lstMiesiac.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                txtDystansDzien.Text = "";
                txtWagaDzien.Text = "";
            }

            txtDystansDzien.KeyPress += new KeyPressEventHandler(keypressed);
            txtWagaDzien.KeyPress += new KeyPressEventHandler(keypressed);

        }

        // Moje obliczenia i inne

        private string NazwaMiesiaca(int jakimiesiac)
        // zwraca nazwę miesiąca
        {
            if (jakimiesiac == 1)
            {
                return "Styczeń";
            }
            else if (jakimiesiac == 2)
            {
                return "Luty";
            }
            else if (jakimiesiac == 2)
            {
                return "Luty";
            }
            else if (jakimiesiac == 3)
            {
                return "Marzec";
            }
            else if (jakimiesiac == 4)
            {
                return "Kwiecień";
            }
            else if (jakimiesiac == 5)
            {
                return "Maj";
            }
            else if (jakimiesiac == 6)
            {
                return "Czerwiec";
            }
            else if (jakimiesiac == 7)
            {
                return "Lipiec";
            }
            else if (jakimiesiac == 8)
            {
                return "Sierpień";
            }
            else if (jakimiesiac == 9)
            {
                return "Wrzesień";
            }
            else if (jakimiesiac == 10)
            {
                return "Październik";
            }
            else if (jakimiesiac == 11)
            {
                return "Listopad";
            }
            else if (jakimiesiac == 12)
            {
                return "Grudzień";
            }
            return "";
        }

        private DateTime GetDate(string s)
        {
            return (Convert.ToDateTime(s.Substring(0, 10)));
        }


        //Tworzenie wykresu

        private int DToX(double d, double dmax)
        // określenie skali osi x (pozioma)
        {
            return ((int)(d * (plnWeightPlot.ClientSize.Width - 1) / dmax));
        }

        private int WToY(double w, double wmin, double wmax)
        // określenie skali osi y (pionowa)
        {
            return ((int)((wmax - w) * (plnWeightPlot.Height - 1) / (wmax - wmin)));
        }

        private void pnlWeightPlot_Paint(object sender, PaintEventArgs e)
        {
            int [] d = new int[ileWag];
            double[] w = new double[ileWag];
            double wmax,wsuma,wsrednia;
            int intervals;
            double gridSpacing, wLegend;

            Graphics weightPlot;
            Graphics legendArea;
            string s;
            SizeF sSize;
            Font legendFont;
            Pen myPen;

            if (ileWag < 2)
                return;

            weightPlot = plnWeightPlot.CreateGraphics();
            myPen = new Pen(Color.Blue, 2);
            wmin = 1000.0;
            wmax = 0.0;
            wsuma = 0.0;
            wsrednia = 0;


            int licz = 0;
            for (int i=1;i<lstMiesiac.Items.Count;i++)
            {
                if(lstMiesiac.Items[i].SubItems[2].Text!="")
                {
                    //TimeSpan diff = DateTime.Parse(lstMiesiac.Items[i].SubItems[0].Text) - DateTime.Parse(lstMiesiac.Items[0].SubItems[0].Text);
                    d[licz] = licz;
                    w[licz] = Convert.ToDouble(lstMiesiac.Items[i].SubItems[2].Text);
                    wmin = Math.Min(w[licz], wmin);
                    wmax = Math.Max(w[licz], wmax);
                    wsuma = wsuma + w[licz];
                    licz++;
                }
            }

            wsrednia = wsuma / licz;
            //lblWagaMiesiacMin.Text = string.Format("{0:0.00}", Convert.ToString(wmin));
            lblWagaMiesiacMin.Text = string.Format("{0:0.00}",wmin);
            lblWagaMiesiacMax.Text = string.Format("{0:0.00}",wmax);
            lblWagaMiesiacSrednia.Text = string.Format("{0:0.00}",wsrednia);

            if (wmin == wmax)
                wmin = wmax - 1;
            wmax = (double)((int)(wmax + 0.5)); // round up
            wmin = (double)((int)(wmin - 0.5)); // round down
            if (wmax - wmin <= 5.0)
                gridSpacing = 1.0;
            else if (wmax - wmin <= 10.0)
                gridSpacing = 2.0;
            else if (wmax - wmin <= 25.0)
                gridSpacing = 5.0;
            else if (wmax - wmin <= 50.0)
                gridSpacing = 10.0;
            else
                gridSpacing = 20.0;
            if (wmax % (int)gridSpacing != 0)
                wmax = gridSpacing * (int)(wmax / gridSpacing) + gridSpacing;
            if (wmin % (int)gridSpacing != 0)
                wmin = gridSpacing * (int)(wmin / gridSpacing);
            intervals = (int)((wmax - wmin) / gridSpacing);

            weightPlot.Clear(plnWeightPlot.BackColor);

            for (int i = 1; i < ileWag; i++)
            {
                // connect current point to previous point
                weightPlot.DrawLine(myPen, DToX(d[i - 1], d[ileWag - 1]), WToY(w[i - 1], wmin, wmax), DToX(d[i], d[ileWag - 1]), WToY(w[i], wmin, wmax));
            }

            legendArea = pnlWeight.CreateGraphics();
            legendFont = new Font("Arial", 10, FontStyle.Bold);
            int pozycja_first = d[0];
            int pozycja_last = d[ileWag-1];

            s = "Start: " + String.Format("{0:MMMM d, yyyy}", lstMiesiac.Items[pozycja_first].SubItems[0].Text);
            legendArea.DrawString(s, legendFont, Brushes.Black, plnWeightPlot.Left + 10, plnWeightPlot.Top + plnWeightPlot.Height + 10);
            legendArea.DrawLine(Pens.Black, plnWeightPlot.Left + 10, plnWeightPlot.Top + plnWeightPlot.Height + 10, plnWeightPlot.Left, plnWeightPlot.Top + plnWeightPlot.Height);
            s = "End: " + String.Format("{0:MMMM d, yyyy}", lstMiesiac.Items[pozycja_last].SubItems[0].Text);
            sSize = legendArea.MeasureString(s, legendFont);
            legendArea.DrawString(s, legendFont, Brushes.Black, plnWeightPlot.Left + plnWeightPlot.Width - sSize.Width - 10, plnWeightPlot.Top + plnWeightPlot.Height + 10);
            legendArea.DrawLine(Pens.Black, plnWeightPlot.Left + plnWeightPlot.Width - 10, plnWeightPlot.Top + plnWeightPlot.Height + 10, plnWeightPlot.Left + DToX(d[ileWag - 1], d[ileWag - 1]), plnWeightPlot.Top + plnWeightPlot.Height);

            wLegend = wmin;
            for (int i = 0; i <= intervals; i++)
            {
                s = wLegend.ToString();
                sSize = legendArea.MeasureString(s, legendFont);
                legendArea.DrawString(s, legendFont, Brushes.Black, plnWeightPlot.Left - sSize.Width, plnWeightPlot.Top + WToY(wLegend, wmin, wmax) - (int)(0.5 * sSize.Height));
                if (i > 0 && i < intervals)
                {
                    // draw grid line (except at top and bottom)
                    weightPlot.DrawLine(Pens.Black, 0, WToY(wLegend, wmin, wmax),plnWeightPlot.ClientSize.Width , WToY(wLegend, wmin, wmax));
                }
                wLegend += gridSpacing;
            }


            weightPlot.Dispose();
            legendArea.Dispose();
            myPen.Dispose();
        }

        private void Txtdystansmiesiac_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSredniaWaga_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void LstMiesiac_MouseClick(object sender, MouseEventArgs e)
        {

            lblDzienzTabeli.Text = lstMiesiac.SelectedItems[0].SubItems[0].Text + " " + lstMiesiac.SelectedItems[0].SubItems[1].Text;

            if (lstMiesiac.SelectedItems[0].SubItems[3].Text != "")
            {
                lblOpisDystans.Visible = true;
                lblOpisWaga.Visible = true;
                txtDystansDzien.Visible = true;
                txtWagaDzien.Visible = true;
                txtDystansDzien.Text = lstMiesiac.SelectedItems[0].SubItems[3].Text;
                txtWagaDzien.Text = lstMiesiac.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                lblOpisDystans.Visible = false;
                lblOpisWaga.Visible = false;
                txtDystansDzien.Visible = false;
                txtWagaDzien.Visible = false;
            }

             //MessageBox.Show(productName + " , " + price + " , " + quantity);
        }

        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // można wpisać tylko: cyfry 0-9, przecinek, beckspace
            // naciśnięcie ENTER uruchamia przycisk HELLO
            //lblFile.Text = e.KeyChar.ToString();
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                if (txtDystansDzien.Text.IndexOf(",") == -1)
                    e.Handled = false;
                else
                    e.Handled = true;

                if (txtWagaDzien.Text.IndexOf(",") == -1)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else if ((int)e.KeyChar == 13)
            {
                btnZapiszDystans.PerformClick();
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnZapiszDystans_Click(object sender, EventArgs e)
        {
            string zapiszDate;
            string zapiszDystans;
            string zapiszWaga;

            zapiszDate= lstMiesiac.SelectedItems[0].SubItems[1].Text;
            zapiszDystans = txtDystansDzien.Text;
            zapiszWaga = txtWagaDzien.Text;

            double num = double.Parse(zapiszDystans);
            lstMiesiac.SelectedItems[0].SubItems[3].Text = String.Format("{0:0.00}", num);
            num = double.Parse(zapiszWaga);
            lstMiesiac.SelectedItems[0].SubItems[2].Text = String.Format("{0:0.00}", num);


            ileWag++;

            btnZapiszDystans.Visible = false;
            txtDystansDzien.Enabled = false;
            txtWagaDzien.Enabled = false;

            double jakaWaga;

            jakaWaga = Convert.ToDouble(lstMiesiac.SelectedItems[0].SubItems[2].Text);

        }
    }
}
