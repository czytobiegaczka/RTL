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
using System.Globalization;




namespace RTL
{
    public partial class frmRTL : Form
    {
        public int ileWag;
        public double wmin;
        public string[] miesicNr = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        private DBConnect BazaLacze; //łącze do bazy danych MySQL
        public string czyZmianaWaga;
        public string czyZmianaDystans;

     

        public frmRTL()
        {
            //zmiany 01.11.2019
            BazaLacze = new DBConnect();
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // ustawia rok i miesiąc na aktualny
            //dateTimePickerYear.Text = DateTime.Now.Year.ToString();
            //sprawdza aktualny miesiąc
            //int miesiac = DateTime.Now.Month;
            //int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            tabBiegi.SelectedIndex = 0;
            string nazmie = NazwaMiesiaca(DateTime.Now.Month);
            comMiesiac.Text = nazmie;

            lblMiesiacRok.Text = nazmie + " " + DateTime.Now.Year.ToString() + " r.";

            wyswietl_lstMiesiac(DateTime.Now.Month, DateTime.Now.Year);
            wyswietl_lblDystansCalkowity(miesicNr[DateTime.Now.Month-1], DateTime.Now.Year.ToString());
        }


        private void wyswietl_lstMiesiac(int mie,int ro)
        {
            //Inicjalizacja listy miesięcznej

            lblDystansMiesiac.Text = "";
            lblSredniaMiesiac.Text = "";

            lblDzienzTabeli.Text = "";
            lblOpisDystans.Visible = false;
            lblOpisWaga.Visible = false;
            lblDystansDzien.Visible = false;
            lblWagaDzien.Visible = false;
            txtDystansDzien.Visible = false;
            txtWagaDzien.Visible = false;

            lstMiesiac.Clear();
            lstMiesiac.View = View.Details;
            lstMiesiac.GridLines = true;
            lstMiesiac.FullRowSelect = true;

            //Add column header
            lstMiesiac.Columns.Add("Data", 150, HorizontalAlignment.Center);
            lstMiesiac.Columns.Add("Dzień tygodnia", 150, HorizontalAlignment.Left);
            lstMiesiac.Columns.Add("Waga", 100, HorizontalAlignment.Right);
            lstMiesiac.Columns.Add("Dystans", 100, HorizontalAlignment.Right);


            int licznikWierszy = System.DateTime.DaysInMonth(ro, mie);
            int licznikKolumn = 4;
            string[,] tabela = new string[licznikWierszy, licznikKolumn];
            button1.Text = BazaLacze.LicznikRekordow(miesicNr[mie - 1], ro.ToString()).ToString();

            //if (BazaLacze.LicznikRekordow(miesicNr[mie-1], ro.ToString()) != '0')
            if (button1.Text!="0")
            {

                //string[,] tabela = new string[licznikWierszy, licznikKolumn];
                tabela = BazaLacze.PobierzMiesiac(licznikWierszy, licznikKolumn, miesicNr[mie-1], ro.ToString());

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                for (int i = 0; i < licznikWierszy; i++)
                {
                    arr[0] = tabela[i, 0];
                    arr[1] = tabela[i, 1];
                    arr[2] = tabela[i, 2];
                    arr[3] = tabela[i, 3];
                    itm = new ListViewItem(arr);
                    lstMiesiac.Items.Add(itm);
                }

            }
            else
            {
                BazaLacze.InsertNowyMiesiac(ro, mie);
                //string[,] tabela = new string[licznikWierszy, licznikKolumn];
                tabela = BazaLacze.PobierzMiesiac(licznikWierszy, licznikKolumn, miesicNr[mie - 1], ro.ToString());

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                for (int i = 0; i < licznikWierszy; i++)
                {
                    arr[0] = tabela[i, 0];
                    arr[1] = tabela[i, 1];
                    arr[2] = tabela[i, 2];
                    arr[3] = tabela[i, 3];
                    itm = new ListViewItem(arr);
                    lstMiesiac.Items.Add(itm);
                }

            }

            lblDzienzTabeli.Text = lstMiesiac.Items[0].SubItems[0].Text + " " + lstMiesiac.Items[0].SubItems[1].Text;

            if (lstMiesiac.Items[0].SubItems[3].Text != "")
            {
                lblOpisDystans.Visible = true;
                lblOpisWaga.Visible = true;
                lblDystansDzien.Visible = true;
                lblWagaDzien.Visible = true;
                lblDystansDzien.Text = lstMiesiac.Items[0].SubItems[3].Text;
                lblWagaDzien.Text = lstMiesiac.Items[0].SubItems[2].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnWyjscie_Click(object sender, EventArgs e)
        {
            //BazaLacze.Close();
        }


        private void TabPage1_Click(object sender, EventArgs e)
        {

        }



        private void LstMiesiac_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblDzienzTabeli.Text = lstMiesiac.SelectedItems[0].SubItems[0].Text + " " + lstMiesiac.SelectedItems[0].SubItems[1].Text;

            tabBiegi.SelectedIndex = 0;
            pnlZmianaDystanWaga.BackColor=Color.Honeydew;
            lblDystansDzien.Visible = false;
            lblWagaDzien.Visible = false;
            lblOpisDystans.Visible = true;
            lblOpisWaga.Visible = true;
            txtDystansDzien.Visible = true;
            txtWagaDzien.Visible = true;
            txtDystansDzien.Enabled = true;
            txtWagaDzien.Enabled = true;
            btnZapiszDystans.Visible = true;
            btnAnulujDystans.Visible = true;
            pnlRokMiesiac.Enabled = false;
            pnlCalkowity.Enabled = false;
            plnButtons.Enabled = false;
            lstMiesiac.Enabled = false;


            czyZmianaWaga = lstMiesiac.SelectedItems[0].SubItems[2].Text;
            czyZmianaDystans = lstMiesiac.SelectedItems[0].SubItems[3].Text;

            txtDystansDzien.Text = czyZmianaDystans;
            txtWagaDzien.Text = czyZmianaWaga;

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

            wyswietl_BilansWaga(miesicNr[comMiesiac.SelectedIndex], dateTimePickerYear.Text);
            ileWag = BazaLacze.WagaLicznikRekordow(miesicNr[comMiesiac.SelectedIndex], dateTimePickerYear.Text);
            button1.Text = ileWag.ToString();


            int [] d = new int[ileWag];
            double[] w = new double[ileWag];
            string[] x = new string[ileWag];
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
            for (int i=0;i<lstMiesiac.Items.Count;i++)
            {
                if(lstMiesiac.Items[i].SubItems[2].Text!="")
                {
                    //TimeSpan diff = DateTime.Parse(lstMiesiac.Items[i].SubItems[0].Text) - DateTime.Parse(lstMiesiac.Items[0].SubItems[0].Text);
                    d[licz] = licz;
                    x[licz] = lstMiesiac.Items[i].SubItems[0].Text;
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

            int cos = ileWag;
            for (int i = 0; i < cos-1; i++)
            {
                // connect current point to previous point
                //weightPlot.DrawLine(myPen, DToX(d[i - 1], d[ileWag - 1]), WToY(w[i - 1], wmin, wmax), DToX(d[i], d[ileWag - 1]), WToY(w[i], wmin, wmax));
                weightPlot.DrawLine(myPen, DToX(d[i], d[ileWag - 1]), WToY(w[i], wmin, wmax), DToX(d[i+1], d[ileWag - 1]), WToY(w[i+1], wmin, wmax));
            }

            legendArea = pnlWeight.CreateGraphics();
            legendFont = new Font("Arial", 10, FontStyle.Bold);
            int pozycja_first = d[0];
            int pozycja_last = d[ileWag-1];

            s = "Start: " + String.Format("{0:MMMM d, yyyy}", lstMiesiac.Items[pozycja_first].SubItems[0].Text);
            legendArea.DrawString(s, legendFont, Brushes.Black, plnWeightPlot.Left + 10, plnWeightPlot.Top + plnWeightPlot.Height + 10);
            legendArea.DrawLine(Pens.Black, plnWeightPlot.Left + 10, plnWeightPlot.Top + plnWeightPlot.Height + 10, plnWeightPlot.Left, plnWeightPlot.Top + plnWeightPlot.Height);
            //s = "End: " + String.Format("{0:MMMM d, yyyy}", lstMiesiac.Items[pozycja_last].SubItems[0].Text);
            s = "End: " + String.Format("{0:MMMM d, yyyy}",x[ileWag-1]);
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

            if (lstMiesiac.SelectedItems[0].SubItems[2].Text != "" |  lstMiesiac.SelectedItems[0].SubItems[3].Text != "")
            {
                if (lstMiesiac.SelectedItems[0].SubItems[2].Text != "") lblOpisDystans.Visible = true;
                if (lstMiesiac.SelectedItems[0].SubItems[3].Text != "") lblOpisWaga.Visible = true;
                lblDystansDzien.Visible = true;
                lblWagaDzien.Visible = true;
                lblDystansDzien.Text = lstMiesiac.SelectedItems[0].SubItems[3].Text;
                lblWagaDzien.Text = lstMiesiac.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                lblDystansDzien.Visible = false;
                lblWagaDzien.Visible = false;
                lblOpisDystans.Visible = false;
                lblOpisWaga.Visible = false;
                txtDystansDzien.Visible = false;
                txtWagaDzien.Visible = false;
            }

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
            double num;

            zapiszDate= lstMiesiac.SelectedItems[0].SubItems[1].Text;
            zapiszDystans = txtDystansDzien.Text;
            zapiszWaga = txtWagaDzien.Text;

            // edycja dystansu
            // zmiana wpisanego 0 na puste
            if (zapiszDystans == "0") zapiszDystans = "";


            if (czyZmianaDystans == "")
            {
                if (czyZmianaDystans == zapiszDystans)
                {
                    // było puste - jest puste
                    lblDystansDzien.Text = "";
                }
                else
                {
                    // było puste - jest wartość

                    BazaLacze.InsertDystans(lstMiesiac.SelectedItems[0].SubItems[0].Text);

                    num = double.Parse(zapiszDystans);
                    lstMiesiac.SelectedItems[0].SubItems[3].Text = String.Format("{0:0.00}", num);
                    lblDystansDzien.Text = String.Format("{0:0.00}", num);

                    double jakiDystans;

                    jakiDystans = Convert.ToDouble(lstMiesiac.SelectedItems[0].SubItems[3].Text);
                    BazaLacze.UpdateDystans(lstMiesiac.SelectedItems[0].SubItems[0].Text, jakiDystans);

                    wyswietl_lblDystansCalkowity(miesicNr[comMiesiac.SelectedIndex], dateTimePickerYear.Text);
                }
            }
            else if (zapiszDystans == czyZmianaDystans)
            {
                //była wartość - jest ta sama wartość
                lblDystansDzien.Text = "";
            }
            else
            {
                if (zapiszDystans == "")
                {
                    //była wartość - jest puste
                    BazaLacze.DeleteDystans(lstMiesiac.SelectedItems[0].SubItems[0].Text);
                    lstMiesiac.SelectedItems[0].SubItems[3].Text = "";
                    lblWagaDzien.Text = "";
                    wyswietl_lblDystansCalkowity(miesicNr[comMiesiac.SelectedIndex], dateTimePickerYear.Text);
                }
                else
                {
                    //była wartość jest inna wartość

                    num = double.Parse(zapiszDystans);
                    lstMiesiac.SelectedItems[0].SubItems[3].Text = String.Format("{0:0.00}", num);
                    lblDystansDzien.Text = String.Format("{0:0.00}", num);

                    double jakiDystans;

                    jakiDystans = Convert.ToDouble(lstMiesiac.SelectedItems[0].SubItems[3].Text);
                    BazaLacze.UpdateDystans(lstMiesiac.SelectedItems[0].SubItems[0].Text, jakiDystans);

                    wyswietl_lblDystansCalkowity(miesicNr[comMiesiac.SelectedIndex], dateTimePickerYear.Text);
                }
            }


            // edycja wagi
            // zmiana wpisanego 0 na puste
            if (zapiszWaga == "0") zapiszWaga = "";


            if (czyZmianaWaga=="")
            {
                if (czyZmianaWaga==zapiszWaga)
                {
                    // było puste - jest puste
                    lblWagaDzien.Text = "";
                }
                else
                {
                    // było puste - jest wartość


                    BazaLacze.InsertWaga(lstMiesiac.SelectedItems[0].SubItems[0].Text);

                    num = double.Parse(zapiszWaga);
                    lstMiesiac.SelectedItems[0].SubItems[2].Text = String.Format("{0:0.00}", num);
                    lblWagaDzien.Text = String.Format("{0:0.00}", num);

                    double jakaWaga;
                    jakaWaga = Convert.ToDouble(lstMiesiac.SelectedItems[0].SubItems[2].Text);
                    BazaLacze.UpdateWaga(lstMiesiac.SelectedItems[0].SubItems[0].Text, jakaWaga);
                }
            }
            else if(zapiszWaga==czyZmianaWaga)
            {
                //była wartość - jest ta sama wartość
                lblWagaDzien.Text = "";
            }
            else
            {
                if(zapiszWaga=="")
                {
                    //była wartość - jest puste
                    BazaLacze.DeleteWaga(lstMiesiac.SelectedItems[0].SubItems[0].Text);
                    lstMiesiac.SelectedItems[0].SubItems[2].Text = "";
                    lblWagaDzien.Text = "";

                }
                else
                {
                    //była wartość jest inna wartość

                    num = double.Parse(zapiszWaga);
                    lstMiesiac.SelectedItems[0].SubItems[2].Text = String.Format("{0:0.00}", num);
                    lblWagaDzien.Text = String.Format("{0:0.00}", num);

                    double jakaWaga;
                    jakaWaga = Convert.ToDouble(lstMiesiac.SelectedItems[0].SubItems[2].Text);
                    BazaLacze.UpdateWaga(lstMiesiac.SelectedItems[0].SubItems[0].Text, jakaWaga);
                }
            }

            /*
            ileWag++;
            */

            pnlZmianaDystanWaga.BackColor = Color.White;
            btnZapiszDystans.Visible = false;
            btnAnulujDystans.Visible = false;
            txtDystansDzien.Enabled = false;
            txtWagaDzien.Enabled = false;
            txtDystansDzien.Visible = false;
            txtWagaDzien.Visible = false;
            lblDystansDzien.Visible = true;
            lblWagaDzien.Visible = true;

            pnlRokMiesiac.Enabled = true;
            pnlCalkowity.Enabled = true;
            plnButtons.Enabled = true;
            lstMiesiac.Enabled = true;

        }

        private void BtnAnulujDystans_Click(object sender, EventArgs e)
        {
            pnlZmianaDystanWaga.BackColor = Color.White;
            btnZapiszDystans.Visible = false;
            btnAnulujDystans.Visible = false;
            txtDystansDzien.Enabled = false;
            txtWagaDzien.Enabled = false;
            txtDystansDzien.Visible = false;
            txtWagaDzien.Visible = false;


            pnlRokMiesiac.Enabled = true;
            pnlCalkowity.Enabled = true;
            plnButtons.Enabled = true;
            lstMiesiac.Enabled = true;

            lblDzienzTabeli.Text = lstMiesiac.SelectedItems[0].SubItems[0].Text + " " + lstMiesiac.SelectedItems[0].SubItems[1].Text;

            if (lstMiesiac.SelectedItems[0].SubItems[2].Text != "" ^ lstMiesiac.SelectedItems[0].SubItems[3].Text != "")
            {
                lblOpisDystans.Visible = true;
                lblOpisWaga.Visible = true;
                lblDystansDzien.Visible = true;
                lblWagaDzien.Visible = true;
                lblDystansDzien.Text = lstMiesiac.SelectedItems[0].SubItems[3].Text;
                lblWagaDzien.Text = lstMiesiac.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                lblDystansDzien.Visible = false;
                lblWagaDzien.Visible = false;
                lblOpisDystans.Visible = false;
                lblOpisWaga.Visible = false;
                txtDystansDzien.Visible = false;
                txtWagaDzien.Visible = false;
            }
        }

        private void ComMiesiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            comMiesiac.Text = comMiesiac.SelectedItem.ToString();
            lblMiesiacRok.Text = comMiesiac.Text + " " + dateTimePickerYear.Text + " r.";
            tabBiegi.SelectedIndex = 0;
            wyswietl_lstMiesiac(comMiesiac.SelectedIndex+1, dateTimePickerYear.Value.Year);
            wyswietl_lblDystansCalkowity(miesicNr[comMiesiac.SelectedIndex], dateTimePickerYear.Text);
            
        }

        private void DateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            lblMiesiacRok.Text = comMiesiac.Text + " " + dateTimePickerYear.Text + " r.";
            wyswietl_lstMiesiac(comMiesiac.SelectedIndex + 1, dateTimePickerYear.Value.Year);
            lblMiesiacRok.Text = comMiesiac.Text + " " + dateTimePickerYear.Text + " r.";
            tabBiegi.SelectedIndex = 0;
            wyswietl_lblDystansCalkowity(miesicNr[comMiesiac.SelectedIndex], dateTimePickerYear.Text);
        }

        private void TxtDystansDzien_TextChanged(object sender, EventArgs e)
        {

        }

        private void wyswietl_lblDystansCalkowity(string mie,string ro)
        {
            lblDystansCalkowity.Text = "Dystans przebiegnięty od 12.11.2011 roku: "+ String.Format("{0:0.00}", BazaLacze.DystansCalkowity("__", "____")) + " km";
            lblCalkowityNaRok.Text = "Dystans przebiegnięty w "+ro+" roku: " + String.Format("{0:0.00}", BazaLacze.DystansCalkowity("__",ro)) + " km";
            lblDystansMiesiac.Text = String.Format("{0:0.00}", BazaLacze.DystansCalkowity(mie, ro)) + " km";
            lblSredniaMiesiac.Text=String.Format("{0:0.00}", BazaLacze.Srednia(mie, ro))+" km";

        }

        private void wyswietl_BilansWaga(string mie,string ro)
        {
            lblWagaRokMax.Text= String.Format("{0:0.00}", BazaLacze.WagaMax("__", ro));
            lblWagaRokMin.Text=String.Format("{0:0.00}", BazaLacze.WagaMinimum("__", ro));
            lblWagaRokSrednia.Text=String.Format("{0:0.00}", BazaLacze.WagaSrednia("__", ro));
            //lblWagaMiesiacMax.Text=String.Format("{0:0.00}", BazaLacze.WagaMax(mie, ro));
            //lblWagaMiesiacMin.Text=String.Format("{0:0.00}", BazaLacze.WagaMinimum(mie, ro));
            //lblWagaMiesiacSrednia.Text=String.Format("{0:0.00}", BazaLacze.WagaSrednia(mie, ro));
        }

        private void LstMiesiac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            string data;
            DateTime data1;
            int licznikWierszy = 100;
            int licznikKolumn = 4;
            string[,] tabela = new string[licznikWierszy, licznikKolumn];

            tabela = BazaLacze.ZmianaFormatu(licznikWierszy, licznikKolumn,"08","2019");

            for (int i = 0; i < licznikWierszy; i++)
            {
                data = tabela[i, 1];
                data1 = DateTime.Parse(data);
                data = data1.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"));
                //tabela[i, 1] = data;
                button1.Text = i.ToString();
                button2.Text = data;
                BazaLacze.UpdateHistoria(data, i + 1);
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowMessage("Hello world !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMessageBoxYesNo_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.ShowMessage("Are You sure You want to do it ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyMessageBox.ShowMessage("Yes !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MyMessageBox.ShowMessage("No !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
