namespace Externe_Vorspannung
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.silaSprez = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.silaSprezTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aktualizaca = new System.Windows.Forms.Button();
            this.iloscPrzesel = new System.Windows.Forms.Label();
            this.textBoxIloscPrzesel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrPodpory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlugoscPrzesla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SilaSum = new System.Windows.Forms.Button();
            this.labeltarcie = new System.Windows.Forms.Label();
            this.tarcieTextBox = new System.Windows.Forms.TextBox();
            this.podgladSil = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.dodajKabelbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rzednaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rzednaY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrKablaTypbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nazwaSystexTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iloscKabliTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // silaSprez
            // 
            this.silaSprez.AutoSize = true;
            this.silaSprez.Location = new System.Drawing.Point(6, 35);
            this.silaSprez.Name = "silaSprez";
            this.silaSprez.Size = new System.Drawing.Size(80, 13);
            this.silaSprez.TabIndex = 1;
            this.silaSprez.Text = "Siła sprężająca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nr kabla";
            // 
            // silaSprezTextbox
            // 
            this.silaSprezTextbox.Location = new System.Drawing.Point(92, 32);
            this.silaSprezTextbox.Name = "silaSprezTextbox";
            this.silaSprezTextbox.Size = new System.Drawing.Size(48, 20);
            this.silaSprezTextbox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 396);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Definicja ustroju";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aktualizaca);
            this.groupBox1.Controls.Add(this.iloscPrzesel);
            this.groupBox1.Controls.Add(this.textBoxIloscPrzesel);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 310);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definicja ustroju";
            // 
            // aktualizaca
            // 
            this.aktualizaca.Location = new System.Drawing.Point(19, 43);
            this.aktualizaca.Name = "aktualizaca";
            this.aktualizaca.Size = new System.Drawing.Size(94, 33);
            this.aktualizaca.TabIndex = 9;
            this.aktualizaca.Text = "Aktualizuj";
            this.aktualizaca.UseVisualStyleBackColor = true;
            this.aktualizaca.Click += new System.EventHandler(this.aktualizaca_Click);
            // 
            // iloscPrzesel
            // 
            this.iloscPrzesel.AutoSize = true;
            this.iloscPrzesel.Location = new System.Drawing.Point(16, 20);
            this.iloscPrzesel.Name = "iloscPrzesel";
            this.iloscPrzesel.Size = new System.Drawing.Size(67, 13);
            this.iloscPrzesel.TabIndex = 0;
            this.iloscPrzesel.Text = "Ilość przęseł";
            // 
            // textBoxIloscPrzesel
            // 
            this.textBoxIloscPrzesel.Location = new System.Drawing.Point(89, 17);
            this.textBoxIloscPrzesel.Name = "textBoxIloscPrzesel";
            this.textBoxIloscPrzesel.Size = new System.Drawing.Size(48, 20);
            this.textBoxIloscPrzesel.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrPodpory,
            this.dlugoscPrzesla});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(6, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(194, 222);
            this.dataGridView1.TabIndex = 4;
            // 
            // nrPodpory
            // 
            this.nrPodpory.HeaderText = "Oś";
            this.nrPodpory.Name = "nrPodpory";
            this.nrPodpory.ReadOnly = true;
            this.nrPodpory.Width = 50;
            // 
            // dlugoscPrzesla
            // 
            this.dlugoscPrzesla.HeaderText = "Długość przęsła";
            this.dlugoscPrzesla.Name = "dlugoscPrzesla";
            this.dlugoscPrzesla.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SilaSum);
            this.tabPage2.Controls.Add(this.labeltarcie);
            this.tabPage2.Controls.Add(this.tarcieTextBox);
            this.tabPage2.Controls.Add(this.podgladSil);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dodajKabelbutton);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.nrKablaTypbox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.nazwaSystexTextbox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.iloscKabliTextbox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.silaSprez);
            this.tabPage2.Controls.Add(this.silaSprezTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spreżenie zewnętrzne";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SilaSum
            // 
            this.SilaSum.Location = new System.Drawing.Point(276, 277);
            this.SilaSum.Name = "SilaSum";
            this.SilaSum.Size = new System.Drawing.Size(229, 32);
            this.SilaSum.TabIndex = 24;
            this.SilaSum.Text = "Suma sił";
            this.SilaSum.UseVisualStyleBackColor = true;
            this.SilaSum.Click += new System.EventHandler(this.SilaSum_Click);
            // 
            // labeltarcie
            // 
            this.labeltarcie.AutoSize = true;
            this.labeltarcie.Location = new System.Drawing.Point(396, 38);
            this.labeltarcie.Name = "labeltarcie";
            this.labeltarcie.Size = new System.Drawing.Size(56, 13);
            this.labeltarcie.TabIndex = 23;
            this.labeltarcie.Text = "Tarcie \"u\"";
            // 
            // tarcieTextBox
            // 
            this.tarcieTextBox.Location = new System.Drawing.Point(457, 35);
            this.tarcieTextBox.Name = "tarcieTextBox";
            this.tarcieTextBox.Size = new System.Drawing.Size(48, 20);
            this.tarcieTextBox.TabIndex = 22;
            // 
            // podgladSil
            // 
            this.podgladSil.Location = new System.Drawing.Point(277, 239);
            this.podgladSil.Name = "podgladSil";
            this.podgladSil.Size = new System.Drawing.Size(229, 32);
            this.podgladSil.TabIndex = 21;
            this.podgladSil.Text = "Podgląd sił";
            this.podgladSil.UseVisualStyleBackColor = true;
            this.podgladSil.Click += new System.EventHandler(this.podgladSil_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(289, 97);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(216, 126);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Podgląd kabla";
            // 
            // dodajKabelbutton
            // 
            this.dodajKabelbutton.Location = new System.Drawing.Point(277, 326);
            this.dodajKabelbutton.Name = "dodajKabelbutton";
            this.dodajKabelbutton.Size = new System.Drawing.Size(229, 32);
            this.dodajKabelbutton.TabIndex = 6;
            this.dodajKabelbutton.Text = "Dodaj kabel";
            this.dodajKabelbutton.UseVisualStyleBackColor = true;
            this.dodajKabelbutton.Click += new System.EventHandler(this.dodajKabelbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(9, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 269);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geometria kabli";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rzednaX,
            this.rzednaY});
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(244, 242);
            this.dataGridView2.TabIndex = 5;
            // 
            // rzednaX
            // 
            this.rzednaX.HeaderText = "rzędna X";
            this.rzednaX.Name = "rzednaX";
            // 
            // rzednaY
            // 
            this.rzednaY.HeaderText = "rzędna Y";
            this.rzednaY.Name = "rzednaY";
            // 
            // nrKablaTypbox
            // 
            this.nrKablaTypbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nrKablaTypbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nrKablaTypbox.Location = new System.Drawing.Point(465, 6);
            this.nrKablaTypbox.Name = "nrKablaTypbox";
            this.nrKablaTypbox.Size = new System.Drawing.Size(41, 21);
            this.nrKablaTypbox.TabIndex = 4;
            this.nrKablaTypbox.SelectedIndexChanged += new System.EventHandler(this.nrKablaTypbox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nazwa systemu";
            // 
            // nazwaSystexTextbox
            // 
            this.nazwaSystexTextbox.Location = new System.Drawing.Point(92, 6);
            this.nazwaSystexTextbox.Name = "nazwaSystexTextbox";
            this.nazwaSystexTextbox.Size = new System.Drawing.Size(217, 20);
            this.nazwaSystexTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ilość kabli";
            // 
            // iloscKabliTextbox
            // 
            this.iloscKabliTextbox.Location = new System.Drawing.Point(92, 60);
            this.iloscKabliTextbox.Name = "iloscKabliTextbox";
            this.iloscKabliTextbox.Size = new System.Drawing.Size(48, 20);
            this.iloscKabliTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "kN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label silaSprez;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox silaSprezTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aktualizaca;
        private System.Windows.Forms.Label iloscPrzesel;
        private System.Windows.Forms.TextBox textBoxIloscPrzesel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPodpory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlugoscPrzesla;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox iloscKabliTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox nazwaSystexTextbox;
        private System.Windows.Forms.ComboBox nrKablaTypbox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rzednaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn rzednaY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajKabelbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button podgladSil;
        private System.Windows.Forms.Label labeltarcie;
        public System.Windows.Forms.TextBox tarcieTextBox;
        private System.Windows.Forms.Button SilaSum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

