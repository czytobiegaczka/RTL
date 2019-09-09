namespace RTL
{
    partial class frmRTL
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMiesiac = new System.Windows.Forms.Panel();
            this.lstMiesiac = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabBiegi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMiesiacRok = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSredniaMiesiac = new System.Windows.Forms.TextBox();
            this.txtdystansmiesiac = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDzienzTabeli = new System.Windows.Forms.Label();
            this.lblOpisDystans = new System.Windows.Forms.Label();
            this.lblOpisUwagi = new System.Windows.Forms.Label();
            this.lblOpisWaga = new System.Windows.Forms.Label();
            this.txtWagaDzien = new System.Windows.Forms.TextBox();
            this.txtDystansDzien = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWagaRokSrednia = new System.Windows.Forms.Label();
            this.lblWagaRokMax = new System.Windows.Forms.Label();
            this.lblWagaRokMin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblWagaMiesiacSrednia = new System.Windows.Forms.Label();
            this.lblWagaMiesiacMax = new System.Windows.Forms.Label();
            this.lblWagaMiesiacMin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plnWeightPlot = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.btnZapiszDystans = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlRokMiesiac = new System.Windows.Forms.Panel();
            this.lblMiesiac = new System.Windows.Forms.Label();
            this.comMiesiac = new System.Windows.Forms.ComboBox();
            this.comRok = new System.Windows.Forms.ComboBox();
            this.lblRok = new System.Windows.Forms.Label();
            this.pnlCalkowity = new System.Windows.Forms.Panel();
            this.lblCalkowityNaRok = new System.Windows.Forms.Label();
            this.lblDystansCalkowity = new System.Windows.Forms.Label();
            this.pnlMiesiac.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBiegi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlRokMiesiac.SuspendLayout();
            this.pnlCalkowity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMiesiac
            // 
            this.pnlMiesiac.BackColor = System.Drawing.SystemColors.Info;
            this.pnlMiesiac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMiesiac.Controls.Add(this.lstMiesiac);
            this.pnlMiesiac.Location = new System.Drawing.Point(12, 107);
            this.pnlMiesiac.Name = "pnlMiesiac";
            this.pnlMiesiac.Size = new System.Drawing.Size(538, 697);
            this.pnlMiesiac.TabIndex = 0;
            // 
            // lstMiesiac
            // 
            this.lstMiesiac.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstMiesiac.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMiesiac.HideSelection = false;
            this.lstMiesiac.Location = new System.Drawing.Point(19, 12);
            this.lstMiesiac.Name = "lstMiesiac";
            this.lstMiesiac.Size = new System.Drawing.Size(505, 664);
            this.lstMiesiac.TabIndex = 1;
            this.lstMiesiac.UseCompatibleStateImageBehavior = false;
            this.lstMiesiac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstMiesiac_MouseClick);
            this.lstMiesiac.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstMiesiac_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabBiegi);
            this.panel2.Location = new System.Drawing.Point(562, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 697);
            this.panel2.TabIndex = 1;
            // 
            // tabBiegi
            // 
            this.tabBiegi.Controls.Add(this.tabPage1);
            this.tabBiegi.Controls.Add(this.tabPage2);
            this.tabBiegi.Location = new System.Drawing.Point(20, 12);
            this.tabBiegi.Name = "tabBiegi";
            this.tabBiegi.SelectedIndex = 0;
            this.tabBiegi.Size = new System.Drawing.Size(666, 664);
            this.tabBiegi.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sczegóły";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblMiesiacRok);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtSredniaMiesiac);
            this.panel6.Controls.Add(this.txtdystansmiesiac);
            this.panel6.Location = new System.Drawing.Point(16, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(626, 187);
            this.panel6.TabIndex = 4;
            this.panel6.Visible = false;
            // 
            // lblMiesiacRok
            // 
            this.lblMiesiacRok.AutoSize = true;
            this.lblMiesiacRok.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiesiacRok.Location = new System.Drawing.Point(26, 23);
            this.lblMiesiacRok.Name = "lblMiesiacRok";
            this.lblMiesiacRok.Size = new System.Drawing.Size(0, 22);
            this.lblMiesiacRok.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(26, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Średni dystans:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Łaczny dystans:";
            // 
            // txtSredniaMiesiac
            // 
            this.txtSredniaMiesiac.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSredniaMiesiac.Enabled = false;
            this.txtSredniaMiesiac.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSredniaMiesiac.Location = new System.Drawing.Point(470, 125);
            this.txtSredniaMiesiac.Name = "txtSredniaMiesiac";
            this.txtSredniaMiesiac.Size = new System.Drawing.Size(81, 29);
            this.txtSredniaMiesiac.TabIndex = 1;
            this.txtSredniaMiesiac.Text = "25";
            this.txtSredniaMiesiac.TextChanged += new System.EventHandler(this.Txtdystansmiesiac_TextChanged);
            // 
            // txtdystansmiesiac
            // 
            this.txtdystansmiesiac.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtdystansmiesiac.Enabled = false;
            this.txtdystansmiesiac.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtdystansmiesiac.Location = new System.Drawing.Point(470, 79);
            this.txtdystansmiesiac.Name = "txtdystansmiesiac";
            this.txtdystansmiesiac.Size = new System.Drawing.Size(81, 29);
            this.txtdystansmiesiac.TabIndex = 1;
            this.txtdystansmiesiac.Text = "25";
            this.txtdystansmiesiac.TextChanged += new System.EventHandler(this.Txtdystansmiesiac_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblDzienzTabeli);
            this.panel5.Controls.Add(this.btnZapiszDystans);
            this.panel5.Controls.Add(this.lblOpisDystans);
            this.panel5.Controls.Add(this.lblOpisUwagi);
            this.panel5.Controls.Add(this.lblOpisWaga);
            this.panel5.Controls.Add(this.txtWagaDzien);
            this.panel5.Controls.Add(this.txtDystansDzien);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(16, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(626, 366);
            this.panel5.TabIndex = 3;
            // 
            // lblDzienzTabeli
            // 
            this.lblDzienzTabeli.AutoSize = true;
            this.lblDzienzTabeli.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDzienzTabeli.Location = new System.Drawing.Point(36, 33);
            this.lblDzienzTabeli.Name = "lblDzienzTabeli";
            this.lblDzienzTabeli.Size = new System.Drawing.Size(0, 22);
            this.lblDzienzTabeli.TabIndex = 3;
            this.lblDzienzTabeli.Click += new System.EventHandler(this.Label14_Click);
            // 
            // lblOpisDystans
            // 
            this.lblOpisDystans.AutoSize = true;
            this.lblOpisDystans.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisDystans.Location = new System.Drawing.Point(31, 75);
            this.lblOpisDystans.Name = "lblOpisDystans";
            this.lblOpisDystans.Size = new System.Drawing.Size(98, 21);
            this.lblOpisDystans.TabIndex = 2;
            this.lblOpisDystans.Text = "Dystans:";
            this.lblOpisDystans.Visible = false;
            // 
            // lblOpisUwagi
            // 
            this.lblOpisUwagi.AutoSize = true;
            this.lblOpisUwagi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisUwagi.Location = new System.Drawing.Point(31, 167);
            this.lblOpisUwagi.Name = "lblOpisUwagi";
            this.lblOpisUwagi.Size = new System.Drawing.Size(76, 21);
            this.lblOpisUwagi.TabIndex = 2;
            this.lblOpisUwagi.Text = "Uwagi:";
            this.lblOpisUwagi.Visible = false;
            // 
            // lblOpisWaga
            // 
            this.lblOpisWaga.AutoSize = true;
            this.lblOpisWaga.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisWaga.Location = new System.Drawing.Point(31, 124);
            this.lblOpisWaga.Name = "lblOpisWaga";
            this.lblOpisWaga.Size = new System.Drawing.Size(65, 21);
            this.lblOpisWaga.TabIndex = 2;
            this.lblOpisWaga.Text = "Waga:";
            this.lblOpisWaga.Visible = false;
            // 
            // txtWagaDzien
            // 
            this.txtWagaDzien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtWagaDzien.Enabled = false;
            this.txtWagaDzien.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWagaDzien.Location = new System.Drawing.Point(480, 121);
            this.txtWagaDzien.Name = "txtWagaDzien";
            this.txtWagaDzien.Size = new System.Drawing.Size(81, 29);
            this.txtWagaDzien.TabIndex = 1;
            this.txtWagaDzien.Text = "10";
            this.txtWagaDzien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWagaDzien.Visible = false;
            // 
            // txtDystansDzien
            // 
            this.txtDystansDzien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDystansDzien.Enabled = false;
            this.txtDystansDzien.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDystansDzien.Location = new System.Drawing.Point(479, 72);
            this.txtDystansDzien.Name = "txtDystansDzien";
            this.txtDystansDzien.Size = new System.Drawing.Size(81, 29);
            this.txtDystansDzien.TabIndex = 1;
            this.txtDystansDzien.Text = "10";
            this.txtDystansDzien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDystansDzien.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(113, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "10";
            this.textBox2.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlWeight);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statystyka waga";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlWeight
            // 
            this.pnlWeight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlWeight.Controls.Add(this.panel4);
            this.pnlWeight.Controls.Add(this.panel1);
            this.pnlWeight.Controls.Add(this.plnWeightPlot);
            this.pnlWeight.Location = new System.Drawing.Point(-4, 0);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(662, 638);
            this.pnlWeight.TabIndex = 0;
            this.pnlWeight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWeightPlot_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblWagaRokSrednia);
            this.panel4.Controls.Add(this.lblWagaRokMax);
            this.panel4.Controls.Add(this.lblWagaRokMin);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(340, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 193);
            this.panel4.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label24.Location = new System.Drawing.Point(218, 142);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 18);
            this.label24.TabIndex = 2;
            this.label24.Text = "kg";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(218, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 18);
            this.label23.TabIndex = 2;
            this.label23.Text = "kg";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(218, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 18);
            this.label22.TabIndex = 2;
            this.label22.Text = "kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(42, 142);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "średnia:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Waga rok:";
            // 
            // lblWagaRokSrednia
            // 
            this.lblWagaRokSrednia.AutoSize = true;
            this.lblWagaRokSrednia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWagaRokSrednia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWagaRokSrednia.Location = new System.Drawing.Point(152, 144);
            this.lblWagaRokSrednia.Name = "lblWagaRokSrednia";
            this.lblWagaRokSrednia.Size = new System.Drawing.Size(48, 18);
            this.lblWagaRokSrednia.TabIndex = 1;
            this.lblWagaRokSrednia.Text = "74.5";
            this.lblWagaRokSrednia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWagaRokMax
            // 
            this.lblWagaRokMax.AutoSize = true;
            this.lblWagaRokMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWagaRokMax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWagaRokMax.Location = new System.Drawing.Point(172, 97);
            this.lblWagaRokMax.Name = "lblWagaRokMax";
            this.lblWagaRokMax.Size = new System.Drawing.Size(28, 18);
            this.lblWagaRokMax.TabIndex = 1;
            this.lblWagaRokMax.Text = "76";
            this.lblWagaRokMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWagaRokMin
            // 
            this.lblWagaRokMin.AutoSize = true;
            this.lblWagaRokMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWagaRokMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWagaRokMin.Location = new System.Drawing.Point(152, 50);
            this.lblWagaRokMin.Name = "lblWagaRokMin";
            this.lblWagaRokMin.Size = new System.Drawing.Size(48, 18);
            this.lblWagaRokMin.TabIndex = 1;
            this.lblWagaRokMin.Text = "73.1";
            this.lblWagaRokMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "maksymalna:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(22, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "minimalna:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.Label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.lblWagaMiesiacSrednia);
            this.panel1.Controls.Add(this.lblWagaMiesiacMax);
            this.panel1.Controls.Add(this.lblWagaMiesiacMin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(45, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 193);
            this.panel1.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.Location = new System.Drawing.Point(223, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 18);
            this.label21.TabIndex = 2;
            this.label21.Text = "kg";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Location = new System.Drawing.Point(223, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 18);
            this.label20.TabIndex = 2;
            this.label20.Text = "kg";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(223, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 18);
            this.label19.TabIndex = 2;
            this.label19.Text = "kg";
            // 
            // lblWagaMiesiacSrednia
            // 
            this.lblWagaMiesiacSrednia.AutoSize = true;
            this.lblWagaMiesiacSrednia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWagaMiesiacSrednia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWagaMiesiacSrednia.Location = new System.Drawing.Point(153, 142);
            this.lblWagaMiesiacSrednia.Name = "lblWagaMiesiacSrednia";
            this.lblWagaMiesiacSrednia.Size = new System.Drawing.Size(0, 18);
            this.lblWagaMiesiacSrednia.TabIndex = 1;
            this.lblWagaMiesiacSrednia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWagaMiesiacMax
            // 
            this.lblWagaMiesiacMax.AutoSize = true;
            this.lblWagaMiesiacMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWagaMiesiacMax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWagaMiesiacMax.Location = new System.Drawing.Point(153, 97);
            this.lblWagaMiesiacMax.Name = "lblWagaMiesiacMax";
            this.lblWagaMiesiacMax.Size = new System.Drawing.Size(0, 18);
            this.lblWagaMiesiacMax.TabIndex = 1;
            this.lblWagaMiesiacMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWagaMiesiacMin
            // 
            this.lblWagaMiesiacMin.AutoSize = true;
            this.lblWagaMiesiacMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWagaMiesiacMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWagaMiesiacMin.Location = new System.Drawing.Point(153, 51);
            this.lblWagaMiesiacMin.Name = "lblWagaMiesiacMin";
            this.lblWagaMiesiacMin.Size = new System.Drawing.Size(0, 18);
            this.lblWagaMiesiacMin.TabIndex = 1;
            this.lblWagaMiesiacMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(44, 142);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "średnia:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(14, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "maksymalna:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "minimalna:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Waga miesiąc:";
            // 
            // plnWeightPlot
            // 
            this.plnWeightPlot.BackColor = System.Drawing.Color.White;
            this.plnWeightPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plnWeightPlot.Location = new System.Drawing.Point(45, 262);
            this.plnWeightPlot.Name = "plnWeightPlot";
            this.plnWeightPlot.Size = new System.Drawing.Size(574, 345);
            this.plnWeightPlot.TabIndex = 0;
            this.plnWeightPlot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWeightPlot_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnWyjscie);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(1274, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 779);
            this.panel3.TabIndex = 2;
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyjscie.Location = new System.Drawing.Point(17, 697);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(129, 58);
            this.btnWyjscie.TabIndex = 0;
            this.btnWyjscie.Text = "Wyjście";
            this.btnWyjscie.UseVisualStyleBackColor = true;
            this.btnWyjscie.Click += new System.EventHandler(this.BtnWyjscie_Click);
            // 
            // btnZapiszDystans
            // 
            this.btnZapiszDystans.Location = new System.Drawing.Point(432, 283);
            this.btnZapiszDystans.Name = "btnZapiszDystans";
            this.btnZapiszDystans.Size = new System.Drawing.Size(129, 58);
            this.btnZapiszDystans.TabIndex = 0;
            this.btnZapiszDystans.Text = "Zapisz";
            this.btnZapiszDystans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZapiszDystans.UseVisualStyleBackColor = true;
            this.btnZapiszDystans.Visible = false;
            this.btnZapiszDystans.Click += new System.EventHandler(this.BtnZapiszDystans_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 453);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 58);
            this.button6.TabIndex = 0;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 58);
            this.button5.TabIndex = 0;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 58);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 58);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 58);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlRokMiesiac
            // 
            this.pnlRokMiesiac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlRokMiesiac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRokMiesiac.Controls.Add(this.lblMiesiac);
            this.pnlRokMiesiac.Controls.Add(this.comMiesiac);
            this.pnlRokMiesiac.Controls.Add(this.comRok);
            this.pnlRokMiesiac.Controls.Add(this.lblRok);
            this.pnlRokMiesiac.Location = new System.Drawing.Point(12, 12);
            this.pnlRokMiesiac.Name = "pnlRokMiesiac";
            this.pnlRokMiesiac.Size = new System.Drawing.Size(538, 89);
            this.pnlRokMiesiac.TabIndex = 3;
            // 
            // lblMiesiac
            // 
            this.lblMiesiac.AutoSize = true;
            this.lblMiesiac.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiesiac.Location = new System.Drawing.Point(207, 30);
            this.lblMiesiac.Name = "lblMiesiac";
            this.lblMiesiac.Size = new System.Drawing.Size(114, 23);
            this.lblMiesiac.TabIndex = 3;
            this.lblMiesiac.Text = "Miesiąc:";
            this.lblMiesiac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comMiesiac
            // 
            this.comMiesiac.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comMiesiac.FormattingEnabled = true;
            this.comMiesiac.Location = new System.Drawing.Point(327, 22);
            this.comMiesiac.Name = "comMiesiac";
            this.comMiesiac.Size = new System.Drawing.Size(182, 31);
            this.comMiesiac.TabIndex = 2;
            // 
            // comRok
            // 
            this.comRok.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comRok.FormattingEnabled = true;
            this.comRok.Location = new System.Drawing.Point(83, 26);
            this.comRok.Name = "comRok";
            this.comRok.Size = new System.Drawing.Size(86, 31);
            this.comRok.TabIndex = 1;
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRok.Location = new System.Drawing.Point(15, 29);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(62, 23);
            this.lblRok.TabIndex = 0;
            this.lblRok.Text = "Rok:";
            this.lblRok.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlCalkowity
            // 
            this.pnlCalkowity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlCalkowity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalkowity.Controls.Add(this.lblCalkowityNaRok);
            this.pnlCalkowity.Controls.Add(this.lblDystansCalkowity);
            this.pnlCalkowity.Location = new System.Drawing.Point(562, 14);
            this.pnlCalkowity.Name = "pnlCalkowity";
            this.pnlCalkowity.Size = new System.Drawing.Size(704, 87);
            this.pnlCalkowity.TabIndex = 4;
            // 
            // lblCalkowityNaRok
            // 
            this.lblCalkowityNaRok.AutoSize = true;
            this.lblCalkowityNaRok.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalkowityNaRok.Location = new System.Drawing.Point(16, 46);
            this.lblCalkowityNaRok.Name = "lblCalkowityNaRok";
            this.lblCalkowityNaRok.Size = new System.Drawing.Size(22, 23);
            this.lblCalkowityNaRok.TabIndex = 1;
            this.lblCalkowityNaRok.Text = " ";
            // 
            // lblDystansCalkowity
            // 
            this.lblDystansCalkowity.AutoSize = true;
            this.lblDystansCalkowity.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDystansCalkowity.Location = new System.Drawing.Point(16, 12);
            this.lblDystansCalkowity.Name = "lblDystansCalkowity";
            this.lblDystansCalkowity.Size = new System.Drawing.Size(0, 23);
            this.lblDystansCalkowity.TabIndex = 0;
            // 
            // frmRTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 816);
            this.Controls.Add(this.pnlCalkowity);
            this.Controls.Add(this.pnlRokMiesiac);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMiesiac);
            this.Name = "frmRTL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMiesiac.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabBiegi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlWeight.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlRokMiesiac.ResumeLayout(false);
            this.pnlRokMiesiac.PerformLayout();
            this.pnlCalkowity.ResumeLayout(false);
            this.pnlCalkowity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMiesiac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabBiegi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnWyjscie;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlRokMiesiac;
        private System.Windows.Forms.Label lblMiesiac;
        private System.Windows.Forms.ComboBox comMiesiac;
        private System.Windows.Forms.ComboBox comRok;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.Panel pnlCalkowity;
        private System.Windows.Forms.Label lblCalkowityNaRok;
        private System.Windows.Forms.Label lblDystansCalkowity;
        private System.Windows.Forms.ListView lstMiesiac;
        private System.Windows.Forms.Button btnZapiszDystans;
        private System.Windows.Forms.Panel pnlWeight;
        private System.Windows.Forms.Panel plnWeightPlot;
        private System.Windows.Forms.TextBox txtdystansmiesiac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDystansDzien;
        private System.Windows.Forms.Label lblOpisDystans;
        private System.Windows.Forms.Label lblOpisWaga;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblWagaRokSrednia;
        private System.Windows.Forms.Label lblWagaRokMax;
        private System.Windows.Forms.Label lblWagaRokMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWagaMiesiacSrednia;
        private System.Windows.Forms.Label lblWagaMiesiacMax;
        private System.Windows.Forms.Label lblWagaMiesiacMin;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblMiesiacRok;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSredniaMiesiac;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDzienzTabeli;
        private System.Windows.Forms.Label lblOpisUwagi;
        private System.Windows.Forms.TextBox txtWagaDzien;
    }
}

