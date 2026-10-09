namespace UserManagement
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnExit = new Button();
            panelCenter = new Panel();
            lblLoginTime = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblWelcome = new Label();
            label5 = new Label();
            btnLogout = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panelCenter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 14);
            label1.Name = "label1";
            label1.Size = new Size(156, 29);
            label1.TabIndex = 1;
            label1.Text = "Trang chính";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Peru;
            btnMinimize.Location = new Point(761, 14);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(44, 33);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click_1;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Peru;
            btnMaximize.Location = new Point(799, 14);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(44, 33);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click_1;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Peru;
            btnExit.Location = new Point(836, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(44, 33);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // panelCenter
            // 
            panelCenter.BackColor = Color.SaddleBrown;
            panelCenter.Controls.Add(lblLoginTime);
            panelCenter.Controls.Add(lblEmail);
            panelCenter.Controls.Add(lblUsername);
            panelCenter.Controls.Add(lblWelcome);
            panelCenter.Controls.Add(label5);
            panelCenter.Controls.Add(btnLogout);
            panelCenter.Controls.Add(label4);
            panelCenter.Controls.Add(label3);
            panelCenter.Controls.Add(label2);
            panelCenter.Location = new Point(198, 83);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(490, 265);
            panelCenter.TabIndex = 1;
            // 
            // lblLoginTime
            // 
            lblLoginTime.AutoSize = true;
            lblLoginTime.ForeColor = Color.White;
            lblLoginTime.Location = new Point(18, 173);
            lblLoginTime.Name = "lblLoginTime";
            lblLoginTime.Size = new Size(0, 24);
            lblLoginTime.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(94, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 24);
            lblEmail.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(182, 63);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 24);
            lblUsername.TabIndex = 6;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.BlanchedAlmond;
            lblWelcome.Location = new Point(158, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 32);
            lblWelcome.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FloralWhite;
            label5.Location = new Point(18, 19);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 4;
            label5.Text = "Xin chào,";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(325, 210);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.NavajoWhite;
            label4.Location = new Point(18, 149);
            label4.Name = "label4";
            label4.Size = new Size(263, 24);
            label4.TabIndex = 2;
            label4.Text = "Lần đăng nhập gần nhất:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.NavajoWhite;
            label3.Location = new Point(18, 104);
            label3.Name = "label3";
            label3.Size = new Size(76, 24);
            label3.TabIndex = 1;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.NavajoWhite;
            label2.Location = new Point(18, 63);
            label2.Name = "label2";
            label2.Size = new Size(164, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            label2.Click += label2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_w6rdwow6rdwow6rd1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 432);
            Controls.Add(panelCenter);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.SaddleBrown;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit;
        private Label label1;
        private Panel panelCenter;
        private Label label2;
        private Button btnLogout;
        private Label label4;
        private Label label3;
        private Label lblWelcome;
        private Label label5;
        private Label lblLoginTime;
        private Label lblEmail;
        private Label lblUsername;
    }
}