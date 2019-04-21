namespace Externe_Vorspannung
{
    partial class reviewForces
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.silyDataGridView = new System.Windows.Forms.DataGridView();
            this.nrZalamaniaDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silaPxDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silaPyDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nrCableLabel = new System.Windows.Forms.Label();
            this.systemNameLabel = new System.Windows.Forms.Label();
            this.prestressForceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityCableLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.silyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // silyDataGridView
            // 
            this.silyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.silyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.silyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.silyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.silyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrZalamaniaDataGridView,
            this.silaPxDataGridView,
            this.silaPyDataGridView});
            this.silyDataGridView.Location = new System.Drawing.Point(46, 80);
            this.silyDataGridView.Name = "silyDataGridView";
            this.silyDataGridView.ReadOnly = true;
            this.silyDataGridView.Size = new System.Drawing.Size(345, 258);
            this.silyDataGridView.TabIndex = 0;
            // 
            // nrZalamaniaDataGridView
            // 
            this.nrZalamaniaDataGridView.HeaderText = "Nr załamania";
            this.nrZalamaniaDataGridView.Name = "nrZalamaniaDataGridView";
            this.nrZalamaniaDataGridView.ReadOnly = true;
            // 
            // silaPxDataGridView
            // 
            this.silaPxDataGridView.HeaderText = "Px [kN]";
            this.silaPxDataGridView.Name = "silaPxDataGridView";
            this.silaPxDataGridView.ReadOnly = true;
            // 
            // silaPyDataGridView
            // 
            this.silaPyDataGridView.HeaderText = "Py [kN]";
            this.silaPyDataGridView.Name = "silaPyDataGridView";
            this.silaPyDataGridView.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "System:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nr kabla:";
            // 
            // nrCableLabel
            // 
            this.nrCableLabel.AutoSize = true;
            this.nrCableLabel.Location = new System.Drawing.Point(95, 43);
            this.nrCableLabel.Name = "nrCableLabel";
            this.nrCableLabel.Size = new System.Drawing.Size(10, 13);
            this.nrCableLabel.TabIndex = 4;
            this.nrCableLabel.Text = "-";
            // 
            // systemNameLabel
            // 
            this.systemNameLabel.AutoSize = true;
            this.systemNameLabel.Location = new System.Drawing.Point(95, 19);
            this.systemNameLabel.Name = "systemNameLabel";
            this.systemNameLabel.Size = new System.Drawing.Size(10, 13);
            this.systemNameLabel.TabIndex = 3;
            this.systemNameLabel.Text = "-";
            // 
            // prestressForceLabel
            // 
            this.prestressForceLabel.AutoSize = true;
            this.prestressForceLabel.Location = new System.Drawing.Point(347, 19);
            this.prestressForceLabel.Name = "prestressForceLabel";
            this.prestressForceLabel.Size = new System.Drawing.Size(10, 13);
            this.prestressForceLabel.TabIndex = 6;
            this.prestressForceLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Siła sprężająca [kN]:";
            // 
            // quantityCableLabel
            // 
            this.quantityCableLabel.AutoSize = true;
            this.quantityCableLabel.Location = new System.Drawing.Point(347, 43);
            this.quantityCableLabel.Name = "quantityCableLabel";
            this.quantityCableLabel.Size = new System.Drawing.Size(10, 13);
            this.quantityCableLabel.TabIndex = 8;
            this.quantityCableLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ilość kabli:";
            // 
            // reviewForces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.quantityCableLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prestressForceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nrCableLabel);
            this.Controls.Add(this.systemNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silyDataGridView);
            this.Name = "reviewForces";
            this.Text = "PodgladSil";
            ((System.ComponentModel.ISupportInitialize)(this.silyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView silyDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nrCableLabel;
        private System.Windows.Forms.Label systemNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZalamaniaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaPxDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaPyDataGridView;
        private System.Windows.Forms.Label prestressForceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label quantityCableLabel;
        private System.Windows.Forms.Label label5;
    }
}