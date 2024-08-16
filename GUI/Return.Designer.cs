
namespace GUI
{
    partial class frmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDelayReturn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFineReturn = new System.Windows.Forms.TextBox();
            this.txtIdRet = new System.Windows.Forms.TextBox();
            this.txtNameReturn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteReturn = new System.Windows.Forms.Button();
            this.btnEditReturn = new System.Windows.Forms.Button();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.btnBackReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCarIdReturn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(402, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(20, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 105;
            this.label11.Text = "Name";
            // 
            // txtDelayReturn
            // 
            this.txtDelayReturn.Location = new System.Drawing.Point(129, 364);
            this.txtDelayReturn.Multiline = true;
            this.txtDelayReturn.Name = "txtDelayReturn";
            this.txtDelayReturn.Size = new System.Drawing.Size(200, 32);
            this.txtDelayReturn.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(20, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 22);
            this.label10.TabIndex = 103;
            this.label10.Text = "Fine";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 306);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 100;
            this.dateTimePicker1.Value = new System.DateTime(2023, 7, 23, 23, 4, 26, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(21, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 22);
            this.label9.TabIndex = 99;
            this.label9.Text = "CarId";
            // 
            // btnFineReturn
            // 
            this.btnFineReturn.Location = new System.Drawing.Point(129, 414);
            this.btnFineReturn.Multiline = true;
            this.btnFineReturn.Name = "btnFineReturn";
            this.btnFineReturn.Size = new System.Drawing.Size(200, 31);
            this.btnFineReturn.TabIndex = 97;
            // 
            // txtIdRet
            // 
            this.txtIdRet.Location = new System.Drawing.Point(130, 138);
            this.txtIdRet.Multiline = true;
            this.txtIdRet.Name = "txtIdRet";
            this.txtIdRet.Size = new System.Drawing.Size(199, 31);
            this.txtIdRet.TabIndex = 96;
            // 
            // txtNameReturn
            // 
            this.txtNameReturn.Location = new System.Drawing.Point(129, 241);
            this.txtNameReturn.Multiline = true;
            this.txtNameReturn.Name = "txtNameReturn";
            this.txtNameReturn.Size = new System.Drawing.Size(200, 32);
            this.txtNameReturn.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(20, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 94;
            this.label5.Text = "ReturnDate";
            // 
            // btnDeleteReturn
            // 
            this.btnDeleteReturn.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteReturn.FlatAppearance.BorderSize = 0;
            this.btnDeleteReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReturn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReturn.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReturn.Location = new System.Drawing.Point(239, 498);
            this.btnDeleteReturn.Name = "btnDeleteReturn";
            this.btnDeleteReturn.Size = new System.Drawing.Size(102, 36);
            this.btnDeleteReturn.TabIndex = 92;
            this.btnDeleteReturn.Text = "DELETE";
            this.btnDeleteReturn.UseVisualStyleBackColor = false;
            // 
            // btnEditReturn
            // 
            this.btnEditReturn.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditReturn.FlatAppearance.BorderSize = 0;
            this.btnEditReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditReturn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReturn.ForeColor = System.Drawing.Color.White;
            this.btnEditReturn.Location = new System.Drawing.Point(131, 498);
            this.btnEditReturn.Name = "btnEditReturn";
            this.btnEditReturn.Size = new System.Drawing.Size(102, 36);
            this.btnEditReturn.TabIndex = 91;
            this.btnEditReturn.Text = "EDIT";
            this.btnEditReturn.UseVisualStyleBackColor = false;
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddReturn.FlatAppearance.BorderSize = 0;
            this.btnAddReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReturn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReturn.ForeColor = System.Drawing.Color.White;
            this.btnAddReturn.Location = new System.Drawing.Point(24, 498);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(101, 36);
            this.btnAddReturn.TabIndex = 90;
            this.btnAddReturn.Text = "ADD";
            this.btnAddReturn.UseVisualStyleBackColor = false;
            // 
            // btnBackReturn
            // 
            this.btnBackReturn.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBackReturn.FlatAppearance.BorderSize = 0;
            this.btnBackReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackReturn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackReturn.ForeColor = System.Drawing.Color.White;
            this.btnBackReturn.Location = new System.Drawing.Point(129, 540);
            this.btnBackReturn.Name = "btnBackReturn";
            this.btnBackReturn.Size = new System.Drawing.Size(102, 36);
            this.btnBackReturn.TabIndex = 93;
            this.btnBackReturn.Text = "BACK";
            this.btnBackReturn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 22);
            this.label4.TabIndex = 89;
            this.label4.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(21, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 88;
            this.label7.Text = "Delay";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 29);
            this.panel2.TabIndex = 106;
            // 
            // txtCarIdReturn
            // 
            this.txtCarIdReturn.Location = new System.Drawing.Point(131, 183);
            this.txtCarIdReturn.Multiline = true;
            this.txtCarIdReturn.Name = "txtCarIdReturn";
            this.txtCarIdReturn.Size = new System.Drawing.Size(200, 32);
            this.txtCarIdReturn.TabIndex = 107;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(383, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 183);
            this.dataGridView1.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(520, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 108;
            this.label6.Text = "Cars on Rent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(520, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 110;
            this.label8.Text = "Cars Returned";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(383, 393);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(456, 183);
            this.dataGridView2.TabIndex = 111;
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 634);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCarIdReturn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDelayReturn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFineReturn);
            this.Controls.Add(this.txtIdRet);
            this.Controls.Add(this.txtNameReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteReturn);
            this.Controls.Add(this.btnEditReturn);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.btnBackReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDelayReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox btnFineReturn;
        private System.Windows.Forms.TextBox txtIdRet;
        private System.Windows.Forms.TextBox txtNameReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteReturn;
        private System.Windows.Forms.Button btnEditReturn;
        private System.Windows.Forms.Button btnAddReturn;
        private System.Windows.Forms.Button btnBackReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCarIdReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}