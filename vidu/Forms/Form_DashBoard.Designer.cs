﻿namespace vidu.Forms
{
    partial class Form_DashBoard
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
            components = new System.ComponentModel.Container();
            panelLeft = new Panel();
            panelSide = new Panel();
            btnSettings = new Button();
            btnKH = new Button();
            btnUsers = new Button();
            btnExpense = new Button();
            btnPurchase = new Button();
            btnSaleBooks = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            button9 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            labelTime = new Label();
            label5 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerTime = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelControls = new Panel();
            panelLeft.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.DodgerBlue;
            panelLeft.Controls.Add(panelSide);
            panelLeft.Controls.Add(btnSettings);
            panelLeft.Controls.Add(btnKH);
            panelLeft.Controls.Add(btnUsers);
            panelLeft.Controls.Add(btnExpense);
            panelLeft.Controls.Add(btnPurchase);
            panelLeft.Controls.Add(btnSaleBooks);
            panelLeft.Controls.Add(btnHome);
            panelLeft.Controls.Add(panel3);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(263, 886);
            panelLeft.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 161);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(7, 60);
            panelSide.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 581);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(263, 60);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "    Cài đặt";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += BtnSettings_Click;
            // 
            // btnKH
            // 
            btnKH.FlatAppearance.BorderSize = 0;
            btnKH.FlatStyle = FlatStyle.Flat;
            btnKH.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKH.ForeColor = Color.White;
            btnKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnKH.Location = new Point(0, 511);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(263, 60);
            btnKH.TabIndex = 2;
            btnKH.Text = "Khách Hàng";
            btnKH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKH.UseVisualStyleBackColor = true;
            btnKH.Click += btnViewSales_Click_1;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 441);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(263, 60);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "    Khách hàng";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += BtnUsers_Click;
            // 
            // btnExpense
            // 
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = Color.White;
            btnExpense.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpense.Location = new Point(0, 371);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(263, 60);
            btnExpense.TabIndex = 2;
            btnExpense.Text = "     Chi phí";
            btnExpense.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExpense.UseVisualStyleBackColor = true;
            btnExpense.Click += btnExpense_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = Color.White;
            btnPurchase.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchase.Location = new Point(0, 301);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(263, 60);
            btnPurchase.TabIndex = 2;
            btnPurchase.Text = "    Sản phẩm";
            btnPurchase.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += BtnPurchase_Click;
            // 
            // btnSaleBooks
            // 
            btnSaleBooks.FlatAppearance.BorderSize = 0;
            btnSaleBooks.FlatStyle = FlatStyle.Flat;
            btnSaleBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaleBooks.ForeColor = Color.White;
            btnSaleBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaleBooks.Location = new Point(0, 231);
            btnSaleBooks.Name = "btnSaleBooks";
            btnSaleBooks.Size = new Size(263, 60);
            btnSaleBooks.TabIndex = 2;
            btnSaleBooks.Text = "    Bán sản phẩm";
            btnSaleBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaleBooks.UseVisualStyleBackColor = true;
            btnSaleBooks.Click += BtnSaleBooks_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DodgerBlue;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 161);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(263, 60);
            btnHome.TabIndex = 2;
            btnHome.Text = "     Trang chủ";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(button8);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 161);
            panel3.TabIndex = 0;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(226, 0);
            button8.Name = "button8";
            button8.Size = new Size(37, 36);
            button8.TabIndex = 2;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(69, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(button9);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(263, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1337, 48);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(17, 10);
            label4.Name = "label4";
            label4.Size = new Size(188, 23);
            label4.TabIndex = 0;
            label4.Text = "Cua Hang Dong Ho";
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Dock = DockStyle.Right;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.Red;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(1293, 0);
            button9.Name = "button9";
            button9.Size = new Size(44, 48);
            button9.TabIndex = 2;
            button9.Text = "X";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += Button9_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(labelTime);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(263, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 113);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(148, 50);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 0;
            label7.Text = "Admin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(92, 50);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 0;
            label6.Text = "Role:";
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(1228, 34);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(83, 19);
            labelTime.TabIndex = 0;
            labelTime.Text = "HH:MM:SS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(167, 19);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 0;
            label5.Text = "Nguyen Van Dung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 0;
            label1.Text = "Welcome:";
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // timerTime
            // 
            timerTime.Tick += TimerTime_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelControls
            // 
            panelControls.Dock = DockStyle.Fill;
            panelControls.Location = new Point(263, 161);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1337, 725);
            panelControls.TabIndex = 3;
            // 
            // Form_DashBoard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1600, 886);
            Controls.Add(panelControls);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panelLeft);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_DashBoard";
            Text = "Form_Dashboard";
            panelLeft.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSaleBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private Panel panel3;
        private Button button8;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelControls;
    }
}