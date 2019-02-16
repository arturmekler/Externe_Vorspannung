namespace Externe_Vorspannung
{
    partial class PodgladSil
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
            ((System.ComponentModel.ISupportInitialize)(this.silyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // silyDataGridView
            // 
            this.silyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.silyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrZalamaniaDataGridView,
            this.silaPxDataGridView,
            this.silaPyDataGridView});
            this.silyDataGridView.Location = new System.Drawing.Point(46, 58);
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
            this.silaPxDataGridView.HeaderText = "Px";
            this.silaPxDataGridView.Name = "silaPxDataGridView";
            this.silaPxDataGridView.ReadOnly = true;
            // 
            // silaPyDataGridView
            // 
            this.silaPyDataGridView.HeaderText = "Py";
            this.silaPyDataGridView.Name = "silaPyDataGridView";
            this.silaPyDataGridView.ReadOnly = true;
            // 
            // PodgladSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.silyDataGridView);
            this.Name = "PodgladSil";
            this.Text = "PodgladSil";
            ((System.ComponentModel.ISupportInitialize)(this.silyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView silyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZalamaniaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaPxDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaPyDataGridView;
    }
}