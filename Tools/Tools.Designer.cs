namespace Tools
{
    partial class Tools
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
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetFullData = new System.Windows.Forms.Button();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnEditDB = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbThoiDiemTao = new System.Windows.Forms.ComboBox();
            this.trvDatabase = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnCapNhatDuLieu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbProcess = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(31, 149);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(158, 21);
            this.cmbDatabase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cơ sở dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Quận/Huyện";
            // 
            // btnGetFullData
            // 
            this.btnGetFullData.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFullData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGetFullData.Location = new System.Drawing.Point(267, 13);
            this.btnGetFullData.Name = "btnGetFullData";
            this.btnGetFullData.Size = new System.Drawing.Size(181, 29);
            this.btnGetFullData.TabIndex = 4;
            this.btnGetFullData.Text = "Lấy toàn bộ dữ liệu mới";
            this.btnGetFullData.UseVisualStyleBackColor = true;
            this.btnGetFullData.Click += new System.EventHandler(this.btnGetFullData_Click);
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(31, 190);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(158, 21);
            this.cmbDistrict.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(31, 67);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(103, 20);
            this.txtUser.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(31, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(103, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnAddDB
            // 
            this.btnAddDB.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddDB.Location = new System.Drawing.Point(327, 240);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(50, 21);
            this.btnAddDB.TabIndex = 10;
            this.btnAddDB.Text = "Thêm";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnEditDB
            // 
            this.btnEditDB.ForeColor = System.Drawing.Color.Maroon;
            this.btnEditDB.Location = new System.Drawing.Point(383, 240);
            this.btnEditDB.Name = "btnEditDB";
            this.btnEditDB.Size = new System.Drawing.Size(39, 21);
            this.btnEditDB.TabIndex = 11;
            this.btnEditDB.Text = "Sửa";
            this.btnEditDB.UseVisualStyleBackColor = true;
            this.btnEditDB.Click += new System.EventHandler(this.btnEditDB_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteDB.Location = new System.Drawing.Point(428, 240);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(39, 21);
            this.btnDeleteDB.TabIndex = 12;
            this.btnDeleteDB.Text = "Xóa";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Máy chủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tài khoản SQL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbServer);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbThoiDiemTao);
            this.panel1.Controls.Add(this.trvDatabase);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeleteDB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnEditDB);
            this.panel1.Controls.Add(this.cmbDatabase);
            this.panel1.Controls.Add(this.btnAddDB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbDistrict);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 274);
            this.panel1.TabIndex = 16;
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(32, 25);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(157, 21);
            this.cmbServer.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(28, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Thời điểm tạo kết nối";
            // 
            // cmbThoiDiemTao
            // 
            this.cmbThoiDiemTao.FormattingEnabled = true;
            this.cmbThoiDiemTao.Location = new System.Drawing.Point(31, 240);
            this.cmbThoiDiemTao.Name = "cmbThoiDiemTao";
            this.cmbThoiDiemTao.Size = new System.Drawing.Size(158, 21);
            this.cmbThoiDiemTao.TabIndex = 22;
            this.cmbThoiDiemTao.SelectedIndexChanged += new System.EventHandler(this.cmbThoiDiemTao_SelectedIndexChanged);
            // 
            // trvDatabase
            // 
            this.trvDatabase.CheckBoxes = true;
            this.trvDatabase.Location = new System.Drawing.Point(228, 26);
            this.trvDatabase.Name = "trvDatabase";
            this.trvDatabase.Size = new System.Drawing.Size(375, 202);
            this.trvDatabase.TabIndex = 20;
            this.trvDatabase.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvDatabase_AfterCheck);
            this.trvDatabase.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDatabase_AfterSelect);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Danh sách Database đang dùng";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(564, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(39, 21);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Maroon;
            this.btnOK.Location = new System.Drawing.Point(505, 240);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 21);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDB);
            this.panel2.Controls.Add(this.btnCapNhatDuLieu);
            this.panel2.Controls.Add(this.btnGetFullData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 54);
            this.panel2.TabIndex = 17;
            // 
            // btnDB
            // 
            this.btnDB.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDB.Location = new System.Drawing.Point(31, 13);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(95, 29);
            this.btnDB.TabIndex = 6;
            this.btnDB.Text = "Nơi lưu trữ";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnCapNhatDuLieu
            // 
            this.btnCapNhatDuLieu.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhatDuLieu.Location = new System.Drawing.Point(454, 13);
            this.btnCapNhatDuLieu.Name = "btnCapNhatDuLieu";
            this.btnCapNhatDuLieu.Size = new System.Drawing.Size(149, 29);
            this.btnCapNhatDuLieu.TabIndex = 5;
            this.btnCapNhatDuLieu.Text = "Cập nhật dữ liệu";
            this.btnCapNhatDuLieu.UseVisualStyleBackColor = true;
            this.btnCapNhatDuLieu.Click += new System.EventHandler(this.btnCapNhatDuLieu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbProcess);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 177);
            this.panel3.TabIndex = 18;
            // 
            // rtbProcess
            // 
            this.rtbProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbProcess.ForeColor = System.Drawing.Color.White;
            this.rtbProcess.Location = new System.Drawing.Point(0, 0);
            this.rtbProcess.Name = "rtbProcess";
            this.rtbProcess.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbProcess.Size = new System.Drawing.Size(631, 177);
            this.rtbProcess.TabIndex = 0;
            this.rtbProcess.Text = "";
            this.rtbProcess.WordWrap = false;
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(631, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy dữ liệu...";
            this.Load += new System.EventHandler(this.Tools_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetFullData;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnEditDB;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TreeView trvDatabase;
        private System.Windows.Forms.Button btnCapNhatDuLieu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtbProcess;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbThoiDiemTao;
        private System.Windows.Forms.ComboBox cmbServer;
    }
}

