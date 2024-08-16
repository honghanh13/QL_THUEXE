
namespace GUI
{
    partial class frmRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRental));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFeeRen = new System.Windows.Forms.TextBox();
            this.txtIdRen = new System.Windows.Forms.TextBox();
            this.txtCusIdRen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnBackCus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 91);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(852, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = " Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 29);
            this.panel2.TabIndex = 31;
            // 
            // btnFeeRen
            // 
            this.btnFeeRen.Location = new System.Drawing.Point(144, 430);
            this.btnFeeRen.Multiline = true;
            this.btnFeeRen.Name = "btnFeeRen";
            this.btnFeeRen.Size = new System.Drawing.Size(200, 31);
            this.btnFeeRen.TabIndex = 79;
            // 
            // txtIdRen
            // 
            this.txtIdRen.Location = new System.Drawing.Point(145, 154);
            this.txtIdRen.Multiline = true;
            this.txtIdRen.Name = "txtIdRen";
            this.txtIdRen.Size = new System.Drawing.Size(199, 31);
            this.txtIdRen.TabIndex = 78;
            // 
            // txtCusIdRen
            // 
            this.txtCusIdRen.Location = new System.Drawing.Point(144, 257);
            this.txtCusIdRen.Multiline = true;
            this.txtCusIdRen.Name = "txtCusIdRen";
            this.txtCusIdRen.Size = new System.Drawing.Size(200, 32);
            this.txtCusIdRen.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 75;
            this.label5.Text = "RentalDate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(396, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 391);
            this.dataGridView1.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(560, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cars on Rent";
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteCus.FlatAppearance.BorderSize = 0;
            this.btnDeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCus.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCus.Location = new System.Drawing.Point(254, 495);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(102, 36);
            this.btnDeleteCus.TabIndex = 71;
            this.btnDeleteCus.Text = "DELETE";
            this.btnDeleteCus.UseVisualStyleBackColor = false;
            // 
            // btnEditCus
            // 
            this.btnEditCus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditCus.FlatAppearance.BorderSize = 0;
            this.btnEditCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCus.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCus.ForeColor = System.Drawing.Color.White;
            this.btnEditCus.Location = new System.Drawing.Point(146, 495);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(102, 36);
            this.btnEditCus.TabIndex = 70;
            this.btnEditCus.Text = "EDIT";
            this.btnEditCus.UseVisualStyleBackColor = false;
            // 
            // btnAddCus
            // 
            this.btnAddCus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddCus.FlatAppearance.BorderSize = 0;
            this.btnAddCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCus.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.Color.White;
            this.btnAddCus.Location = new System.Drawing.Point(39, 495);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(101, 36);
            this.btnAddCus.TabIndex = 69;
            this.btnAddCus.Text = "ADD";
            this.btnAddCus.UseVisualStyleBackColor = false;
            // 
            // btnBackCus
            // 
            this.btnBackCus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBackCus.FlatAppearance.BorderSize = 0;
            this.btnBackCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCus.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCus.ForeColor = System.Drawing.Color.White;
            this.btnBackCus.Location = new System.Drawing.Point(144, 537);
            this.btnBackCus.Name = "btnBackCus";
            this.btnBackCus.Size = new System.Drawing.Size(102, 36);
            this.btnBackCus.TabIndex = 72;
            this.btnBackCus.Text = "BACK";
            this.btnBackCus.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(35, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 22);
            this.label4.TabIndex = 68;
            this.label4.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(35, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 66;
            this.label7.Text = "CustId";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 207);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 24);
            this.comboBox2.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(35, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 81;
            this.label9.Text = "CarReg";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 359);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 82;
            this.dateTimePicker1.Value = new System.DateTime(2023, 7, 23, 23, 4, 26, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(35, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 22);
            this.label8.TabIndex = 83;
            this.label8.Text = "ReturnDate";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 395);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker2.TabIndex = 84;
            this.dateTimePicker2.Value = new System.DateTime(2023, 7, 23, 23, 4, 26, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(35, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 22);
            this.label10.TabIndex = 85;
            this.label10.Text = "Fees";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(144, 311);
            this.txtNameCus.Multiline = true;
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(200, 32);
            this.txtNameCus.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(35, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 87;
            this.label11.Text = "Name";
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 634);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNameCus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnFeeRen);
            this.Controls.Add(this.txtIdRen);
            this.Controls.Add(this.txtCusIdRen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeleteCus);
            this.Controls.Add(this.btnEditCus);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.btnBackCus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox btnFeeRen;
        private System.Windows.Forms.TextBox txtIdRen;
        private System.Windows.Forms.TextBox txtCusIdRen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnBackCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Label label11;
    }
}