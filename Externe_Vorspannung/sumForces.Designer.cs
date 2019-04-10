namespace Externe_Vorspannung
{
    partial class sumForces
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
            this.sumaSilDataGridView = new System.Windows.Forms.DataGridView();
            this.nrZalamaniaDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rzedneXdataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silaPxDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silaPyDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sumaSilDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sumaSilDataGridView
            // 
            this.sumaSilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumaSilDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrZalamaniaDataGridView,
            this.rzedneXdataGridView,
            this.silaPxDataGridView,
            this.silaPyDataGridView});
            this.sumaSilDataGridView.Location = new System.Drawing.Point(42, 30);
            this.sumaSilDataGridView.Name = "sumaSilDataGridView";
            this.sumaSilDataGridView.ReadOnly = true;
            this.sumaSilDataGridView.Size = new System.Drawing.Size(443, 353);
            this.sumaSilDataGridView.TabIndex = 1;
            // 
            // nrZalamaniaDataGridView
            // 
            this.nrZalamaniaDataGridView.HeaderText = "Nr załamania";
            this.nrZalamaniaDataGridView.Name = "nrZalamaniaDataGridView";
            this.nrZalamaniaDataGridView.ReadOnly = true;
            // 
            // rzedneXdataGridView
            // 
            this.rzedneXdataGridView.HeaderText = "Rzędne";
            this.rzedneXdataGridView.Name = "rzedneXdataGridView";
            this.rzedneXdataGridView.ReadOnly = true;
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
            // sumForces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 409);
            this.Controls.Add(this.sumaSilDataGridView);
            this.Name = "sumForces";
            this.Text = "ForcesSum";
            ((System.ComponentModel.ISupportInitialize)(this.sumaSilDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sumaSilDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZalamaniaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rzedneXdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaPxDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaPyDataGridView;
    }
}