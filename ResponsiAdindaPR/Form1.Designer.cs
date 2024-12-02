namespace ResponsiAdindaPR
{
    partial class Form1
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(45, 180);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(91, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Karyawan :";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(45, 202);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(71, 13);
            this.lblDep.TabIndex = 2;
            this.lblDep.Text = "Departemen :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(157, 180);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(408, 20);
            this.tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            this.cbDep.AutoCompleteCustomSource.AddRange(new string[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Items.AddRange(new object[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.cbDep.Location = new System.Drawing.Point(157, 202);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(408, 21);
            this.cbDep.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInsert.Location = new System.Drawing.Point(48, 260);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 39);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Location = new System.Drawing.Point(253, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 39);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(465, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 209);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(621, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 101);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "ID Departemen :\nHR : HR\nENG : Engineer\nDEV : Developer\nPM : Product M\nFIN : Finan" +
    "ce";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResponsiAdindaPR.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 556);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbDep);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

