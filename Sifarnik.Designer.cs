namespace Ednevnik410b
{
    partial class Sifarnik
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
            this.dataGridView_Sifarnik = new System.Windows.Forms.DataGridView();
            this.btn_Sifarnik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sifarnik)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Sifarnik
            // 
            this.dataGridView_Sifarnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sifarnik.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_Sifarnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Sifarnik.Name = "dataGridView_Sifarnik";
            this.dataGridView_Sifarnik.RowTemplate.Height = 28;
            this.dataGridView_Sifarnik.Size = new System.Drawing.Size(517, 220);
            this.dataGridView_Sifarnik.TabIndex = 0;
            // 
            // btn_Sifarnik
            // 
            this.btn_Sifarnik.Location = new System.Drawing.Point(195, 232);
            this.btn_Sifarnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sifarnik.Name = "btn_Sifarnik";
            this.btn_Sifarnik.Size = new System.Drawing.Size(131, 40);
            this.btn_Sifarnik.TabIndex = 1;
            this.btn_Sifarnik.Text = "OK";
            this.btn_Sifarnik.UseVisualStyleBackColor = true;
            this.btn_Sifarnik.Click += new System.EventHandler(this.btn_Sifarnik_Click);
            // 
            // Sifarnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btn_Sifarnik);
            this.Controls.Add(this.dataGridView_Sifarnik);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sifarnik";
            this.Text = "Sifarnik";
            this.Load += new System.EventHandler(this.Sifarnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sifarnik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Sifarnik;
        private System.Windows.Forms.Button btn_Sifarnik;
    }
}