namespace Assignment5
{
    partial class SelectForm
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
            this.ProductdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductdataGridView
            // 
            this.ProductdataGridView.AllowUserToAddRows = false;
            this.ProductdataGridView.AllowUserToDeleteRows = false;
            this.ProductdataGridView.AllowUserToResizeColumns = false;
            this.ProductdataGridView.AllowUserToResizeRows = false;
            this.ProductdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ProductdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ProductdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductdataGridView.Location = new System.Drawing.Point(12, 52);
            this.ProductdataGridView.Name = "ProductdataGridView";
            this.ProductdataGridView.ReadOnly = true;
            this.ProductdataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProductdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductdataGridView.Size = new System.Drawing.Size(776, 290);
            this.ProductdataGridView.TabIndex = 0;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductdataGridView);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductdataGridView;
    }
}