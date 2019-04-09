namespace Externe_Vorspannung
{
    partial class Externe_Vorspannung
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyświetlPomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SilaSum = new System.Windows.Forms.Button();
            this.labeltarcie = new System.Windows.Forms.Label();
            this.frictionTextBox = new System.Windows.Forms.TextBox();
            this.systemNameTextbox = new System.Windows.Forms.TextBox();
            this.quantitiyCableTextbox = new System.Windows.Forms.TextBox();
            this.prestressForceTextbox = new System.Windows.Forms.TextBox();
            this.podgladSil = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.dodajKabelbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rzednaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rzednaY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCableTypbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.silaSprez = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cableBeginActive = new System.Windows.Forms.CheckBox();
            this.cableEndActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteCableButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
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
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyświetlPomocToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // wyświetlPomocToolStripMenuItem
            // 
            this.wyświetlPomocToolStripMenuItem.Name = "wyświetlPomocToolStripMenuItem";
            this.wyświetlPomocToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.wyświetlPomocToolStripMenuItem.Text = "Wyświetl pomoc";
            this.wyświetlPomocToolStripMenuItem.Click += new System.EventHandler(this.wyświetlPomocToolStripMenuItem_Click);
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteCableButton);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.SilaSum);
            this.tabPage2.Controls.Add(this.labeltarcie);
            this.tabPage2.Controls.Add(this.frictionTextBox);
            this.tabPage2.Controls.Add(this.systemNameTextbox);
            this.tabPage2.Controls.Add(this.quantitiyCableTextbox);
            this.tabPage2.Controls.Add(this.prestressForceTextbox);
            this.tabPage2.Controls.Add(this.podgladSil);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dodajKabelbutton);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.nrCableTypbox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.silaSprez);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spreżenie zewnętrzne";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SilaSum
            // 
            this.SilaSum.Location = new System.Drawing.Point(275, 340);
            this.SilaSum.Name = "SilaSum";
            this.SilaSum.Size = new System.Drawing.Size(229, 32);
            this.SilaSum.TabIndex = 24;
            this.SilaSum.Text = "Suma sił";
            this.SilaSum.UseVisualStyleBackColor = true;
            this.SilaSum.Click += new System.EventHandler(this.ForcesSum_Click);
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
            // frictionTextBox
            // 
            this.frictionTextBox.Location = new System.Drawing.Point(457, 35);
            this.frictionTextBox.Name = "frictionTextBox";
            this.frictionTextBox.Size = new System.Drawing.Size(48, 20);
            this.frictionTextBox.TabIndex = 22;
            // 
            // systemNameTextbox
            // 
            this.systemNameTextbox.Location = new System.Drawing.Point(92, 6);
            this.systemNameTextbox.Name = "systemNameTextbox";
            this.systemNameTextbox.Size = new System.Drawing.Size(217, 20);
            this.systemNameTextbox.TabIndex = 1;
            // 
            // quantitiyCableTextbox
            // 
            this.quantitiyCableTextbox.Location = new System.Drawing.Point(92, 60);
            this.quantitiyCableTextbox.Name = "quantitiyCableTextbox";
            this.quantitiyCableTextbox.Size = new System.Drawing.Size(48, 20);
            this.quantitiyCableTextbox.TabIndex = 3;
            // 
            // prestressForceTextbox
            // 
            this.prestressForceTextbox.Location = new System.Drawing.Point(92, 32);
            this.prestressForceTextbox.Name = "prestressForceTextbox";
            this.prestressForceTextbox.Size = new System.Drawing.Size(48, 20);
            this.prestressForceTextbox.TabIndex = 2;
            // 
            // podgladSil
            // 
            this.podgladSil.Location = new System.Drawing.Point(275, 302);
            this.podgladSil.Name = "podgladSil";
            this.podgladSil.Size = new System.Drawing.Size(229, 32);
            this.podgladSil.TabIndex = 21;
            this.podgladSil.Text = "Podgląd sił";
            this.podgladSil.UseVisualStyleBackColor = true;
            this.podgladSil.Click += new System.EventHandler(this.reviewForces_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(280, 115);
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
            this.label3.Location = new System.Drawing.Point(277, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Podgląd kabla";
            // 
            // dodajKabelbutton
            // 
            this.dodajKabelbutton.Location = new System.Drawing.Point(275, 264);
            this.dodajKabelbutton.Name = "dodajKabelbutton";
            this.dodajKabelbutton.Size = new System.Drawing.Size(229, 32);
            this.dodajKabelbutton.TabIndex = 6;
            this.dodajKabelbutton.Text = "Dodaj kabel";
            this.dodajKabelbutton.UseVisualStyleBackColor = true;
            this.dodajKabelbutton.Click += new System.EventHandler(this.cableAddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(9, 179);
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
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(244, 242);
            this.dataGridView2.TabIndex = 5;
            // 
            // rzednaX
            // 
            this.rzednaX.HeaderText = "rzędna X [m]";
            this.rzednaX.Name = "rzednaX";
            // 
            // rzednaY
            // 
            this.rzednaY.HeaderText = "rzędna Y [m]";
            this.rzednaY.Name = "rzednaY";
            // 
            // nrCableTypbox
            // 
            this.nrCableTypbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nrCableTypbox.Items.AddRange(new object[] {
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
            this.nrCableTypbox.Location = new System.Drawing.Point(465, 6);
            this.nrCableTypbox.Name = "nrCableTypbox";
            this.nrCableTypbox.Size = new System.Drawing.Size(41, 21);
            this.nrCableTypbox.TabIndex = 4;
            this.nrCableTypbox.SelectedIndexChanged += new System.EventHandler(this.nrCableTypbox_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nr kabla";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "kN";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 489);
            this.tabControl1.TabIndex = 11;
            // 
            // cableBeginActive
            // 
            this.cableBeginActive.AutoSize = true;
            this.cableBeginActive.Location = new System.Drawing.Point(14, 22);
            this.cableBeginActive.Name = "cableBeginActive";
            this.cableBeginActive.Size = new System.Drawing.Size(100, 17);
            this.cableBeginActive.TabIndex = 25;
            this.cableBeginActive.Text = "Początek kabla";
            this.cableBeginActive.UseVisualStyleBackColor = true;
            // 
            // cableEndActive
            // 
            this.cableEndActive.AutoSize = true;
            this.cableEndActive.Location = new System.Drawing.Point(14, 45);
            this.cableEndActive.Name = "cableEndActive";
            this.cableEndActive.Size = new System.Drawing.Size(88, 17);
            this.cableEndActive.TabIndex = 26;
            this.cableEndActive.Text = "Koniec kabla";
            this.cableEndActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cableEndActive);
            this.groupBox1.Controls.Add(this.cableBeginActive);
            this.groupBox1.Location = new System.Drawing.Point(17, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 71);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakotwienie czynne kabla";
            // 
            // deleteCableButton
            // 
            this.deleteCableButton.Location = new System.Drawing.Point(275, 396);
            this.deleteCableButton.Name = "deleteCableButton";
            this.deleteCableButton.Size = new System.Drawing.Size(229, 32);
            this.deleteCableButton.TabIndex = 28;
            this.deleteCableButton.Text = "Usuń kabel";
            this.deleteCableButton.UseVisualStyleBackColor = true;
            this.deleteCableButton.Click += new System.EventHandler(this.deleteCableButton_Click);
            // 
            // Externe_Vorspannung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Externe_Vorspannung";
            this.Text = "Externe_Vorspannung";
            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SilaSum;
        private System.Windows.Forms.Label labeltarcie;
        public System.Windows.Forms.TextBox frictionTextBox;
        public System.Windows.Forms.TextBox systemNameTextbox;
        public System.Windows.Forms.TextBox quantitiyCableTextbox;
        public System.Windows.Forms.TextBox prestressForceTextbox;
        private System.Windows.Forms.Button podgladSil;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dodajKabelbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox nrCableTypbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label silaSprez;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rzednaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn rzednaY;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyświetlPomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.CheckBox cableBeginActive;
        private System.Windows.Forms.Button deleteCableButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cableEndActive;
    }
}

