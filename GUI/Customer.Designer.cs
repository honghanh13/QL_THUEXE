
namespace GUI
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnBackCus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(880, 91);
            this.panel1.TabIndex = 3;
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(820, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manege Customer";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 29);
            this.panel2.TabIndex = 30;
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(158, 202);
            this.btnId.Multiline = true;
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(190, 33);
            this.btnId.TabIndex = 65;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 267);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 33);
            this.txtName.TabIndex = 64;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(158, 319);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(190, 33);
            this.txtAddress.TabIndex = 63;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(158, 384);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(190, 33);
            this.txtPhone.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(34, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 60;
            this.label5.Text = "Phone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(395, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 391);
            this.dataGridView1.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(553, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Customer List";
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteCus.FlatAppearance.BorderSize = 0;
            this.btnDeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCus.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCus.Location = new System.Drawing.Point(246, 458);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(102, 36);
            this.btnDeleteCus.TabIndex = 55;
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
            this.btnEditCus.Location = new System.Drawing.Point(136, 458);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(102, 36);
            this.btnEditCus.TabIndex = 54;
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
            this.btnAddCus.Location = new System.Drawing.Point(31, 458);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(101, 36);
            this.btnAddCus.TabIndex = 53;
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
            this.btnBackCus.Location = new System.Drawing.Point(136, 500);
            this.btnBackCus.Name = "btnBackCus";
            this.btnBackCus.Size = new System.Drawing.Size(102, 36);
            this.btnBackCus.TabIndex = 56;
            this.btnBackCus.Text = "BACK";
            this.btnBackCus.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(34, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(34, 326);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 51;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(34, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 50;
            this.label7.Text = "Name";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 615);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeleteCus);
            this.Controls.Add(this.btnEditCus);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.btnBackCus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
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
        private System.Windows.Forms.TextBox btnId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnBackCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}