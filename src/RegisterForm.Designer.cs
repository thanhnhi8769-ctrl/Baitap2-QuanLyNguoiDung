namespace UserManagement
{
    partial class RegisterForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnExit = new Button();
            label1 = new Label();
            panelCenter = new Panel();
            lblErrorHoTen = new Label();
            txtHovaTen = new TextBox();
            label6 = new Label();
            lblErrorEmail = new Label();
            lblErrorConfirm = new Label();
            lblErrorPassword = new Label();
            lblErrorUsername = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
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
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 38);
            panel1.TabIndex = 0;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Peru;
            btnMaximize.ForeColor = Color.SaddleBrown;
            btnMaximize.Location = new Point(807, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(47, 34);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Peru;
            btnMinimize.ForeColor = Color.SaddleBrown;
            btnMinimize.Location = new Point(763, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(47, 34);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click_1;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Peru;
            btnExit.ForeColor = Color.SaddleBrown;
            btnExit.Location = new Point(849, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(47, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 1;
            label1.Text = "Đăng ký tài khoản";
            // 
            // panelCenter
            // 
            panelCenter.BackColor = Color.SaddleBrown;
            panelCenter.Controls.Add(lblErrorHoTen);
            panelCenter.Controls.Add(txtHovaTen);
            panelCenter.Controls.Add(label6);
            panelCenter.Controls.Add(lblErrorEmail);
            panelCenter.Controls.Add(lblErrorConfirm);
            panelCenter.Controls.Add(lblErrorPassword);
            panelCenter.Controls.Add(lblErrorUsername);
            panelCenter.Controls.Add(btnCancel);
            panelCenter.Controls.Add(btnRegister);
            panelCenter.Controls.Add(txtEmail);
            panelCenter.Controls.Add(txtConfirmPassword);
            panelCenter.Controls.Add(txtPassword);
            panelCenter.Controls.Add(txtUsername);
            panelCenter.Controls.Add(label5);
            panelCenter.Controls.Add(label4);
            panelCenter.Controls.Add(label3);
            panelCenter.Controls.Add(label2);
            panelCenter.Location = new Point(227, 62);
            panelCenter.Margin = new Padding(4, 3, 4, 3);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(489, 394);
            panelCenter.TabIndex = 2;
            panelCenter.Paint += panelCenter_Paint;
            // 
            // lblErrorHoTen
            // 
            lblErrorHoTen.AutoSize = true;
            lblErrorHoTen.ForeColor = Color.Red;
            lblErrorHoTen.Location = new Point(20, 249);
            lblErrorHoTen.Name = "lblErrorHoTen";
            lblErrorHoTen.Size = new Size(0, 24);
            lblErrorHoTen.TabIndex = 16;
            // 
            // txtHovaTen
            // 
            txtHovaTen.ForeColor = Color.SaddleBrown;
            txtHovaTen.Location = new Point(231, 221);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.Size = new Size(238, 28);
            txtHovaTen.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.NavajoWhite;
            label6.Location = new Point(20, 225);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(109, 24);
            label6.TabIndex = 14;
            label6.Text = "Họ và tên";
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(20, 321);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(0, 24);
            lblErrorEmail.TabIndex = 13;
            // 
            // lblErrorConfirm
            // 
            lblErrorConfirm.AutoSize = true;
            lblErrorConfirm.ForeColor = Color.Red;
            lblErrorConfirm.Location = new Point(20, 188);
            lblErrorConfirm.Name = "lblErrorConfirm";
            lblErrorConfirm.Size = new Size(0, 24);
            lblErrorConfirm.TabIndex = 12;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(20, 115);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(0, 24);
            lblErrorPassword.TabIndex = 11;
            // 
            // lblErrorUsername
            // 
            lblErrorUsername.AutoSize = true;
            lblErrorUsername.ForeColor = Color.Red;
            lblErrorUsername.Location = new Point(20, 55);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(0, 24);
            lblErrorUsername.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(361, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 31);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(216, 345);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 31);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.SaddleBrown;
            txtEmail.Location = new Point(231, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 28);
            txtEmail.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.ForeColor = Color.SaddleBrown;
            txtConfirmPassword.Location = new Point(231, 155);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(238, 28);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.SaddleBrown;
            txtPassword.Location = new Point(231, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 28);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = Color.SaddleBrown;
            txtUsername.Location = new Point(231, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 28);
            txtUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.NavajoWhite;
            label5.Location = new Point(20, 297);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 24);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.NavajoWhite;
            label4.Location = new Point(20, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(197, 24);
            label4.TabIndex = 2;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.NavajoWhite;
            label3.Location = new Point(20, 91);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.NavajoWhite;
            label2.Location = new Point(20, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_w6rdwow6rdwow6rd;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 482);
            Controls.Add(panelCenter);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.SaddleBrown;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelCenter;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private Button btnExit;
        private Button btnMaximize;
        private Button btnMinimize;
        private Label lblErrorEmail;
        private Label lblErrorConfirm;
        private Label lblErrorPassword;
        private Label lblErrorUsername;
        private Label label6;
        private TextBox txtHovaTen;
        private Label lblErrorHoTen;
    }
}