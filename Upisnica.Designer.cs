namespace Ednevnik410b
{
    partial class Upisnica
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Combo_Godine = new System.Windows.Forms.ComboBox();
            this.Combo_Odeljenje = new System.Windows.Forms.ComboBox();
            this.Combo_Ucenik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Text_Upisnica";
            // 
            // Combo_Godine
            // 
            this.Combo_Godine.FormattingEnabled = true;
            this.Combo_Godine.Location = new System.Drawing.Point(185, 64);
            this.Combo_Godine.Name = "Combo_Godine";
            this.Combo_Godine.Size = new System.Drawing.Size(121, 21);
            this.Combo_Godine.TabIndex = 1;
            this.Combo_Godine.SelectedValueChanged += new System.EventHandler(this.Combo_Godine_SelectedValueChanged);
            // 
            // Combo_Odeljenje
            // 
            this.Combo_Odeljenje.FormattingEnabled = true;
            this.Combo_Odeljenje.Location = new System.Drawing.Point(337, 64);
            this.Combo_Odeljenje.Name = "Combo_Odeljenje";
            this.Combo_Odeljenje.Size = new System.Drawing.Size(121, 21);
            this.Combo_Odeljenje.TabIndex = 2;
            this.Combo_Odeljenje.SelectedValueChanged += new System.EventHandler(this.Combo_Odeljenje_SelectedValueChanged);
            // 
            // Combo_Ucenik
            // 
            this.Combo_Ucenik.FormattingEnabled = true;
            this.Combo_Ucenik.Location = new System.Drawing.Point(492, 63);
            this.Combo_Ucenik.Name = "Combo_Ucenik";
            this.Combo_Ucenik.Size = new System.Drawing.Size(121, 21);
            this.Combo_Ucenik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odeljenje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ucenik";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 249);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // Button_Insert
            // 
            this.Button_Insert.Location = new System.Drawing.Point(122, 113);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(75, 23);
            this.Button_Insert.TabIndex = 9;
            this.Button_Insert.Text = "Button_Insert";
            this.Button_Insert.UseVisualStyleBackColor = true;
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(283, 113);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(75, 23);
            this.Button_Update.TabIndex = 10;
            this.Button_Update.Text = "Button_Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(440, 113);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 11;
            this.Button_Delete.Text = "Button_Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            // 
            // Upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combo_Ucenik);
            this.Controls.Add(this.Combo_Odeljenje);
            this.Controls.Add(this.Combo_Godine);
            this.Controls.Add(this.textBox1);
            this.Name = "Upisnica";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Combo_Godine;
        private System.Windows.Forms.ComboBox Combo_Odeljenje;
        private System.Windows.Forms.ComboBox Combo_Ucenik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_Insert;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Delete;
    }
}