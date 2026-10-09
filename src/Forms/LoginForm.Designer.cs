namespace UserManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label1 = new Label();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnExit = new Button();
            panelCenter = new Panel();
            lnkRegister = new LinkLabel();
            lblError = new Label();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txtPassword = new TextBox();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panelCenter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(-77, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(440, 7);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 1;
            label1.Text = "Đăng Nhập";
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Peru;
            btnMaximize.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(877, 7);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(41, 33);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Peru;
            btnMinimize.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(840, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(41, 33);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Peru;
            btnExit.Location = new Point(916, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 33);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(lnkRegister);
            panelCenter.Controls.Add(lblError);
            panelCenter.Controls.Add(btnThoat);
            panelCenter.Controls.Add(btnDangNhap);
            panelCenter.Controls.Add(txtPassword);
            panelCenter.Controls.Add(txtTenDangNhap);
            panelCenter.Controls.Add(label3);
            panelCenter.Controls.Add(label2);
            panelCenter.Location = new Point(162, 109);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(543, 244);
            panelCenter.TabIndex = 1;
            panelCenter.Paint += panelCenter_Paint;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.ForeColor = Color.NavajoWhite;
            lnkRegister.LinkColor = Color.NavajoWhite;
            lnkRegister.Location = new Point(144, 203);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(296, 24);
            lnkRegister.TabIndex = 7;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Chưa có tài khoản? Đăng ký";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(72, 116);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 24);
            lblError.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThoat.Location = new Point(386, 152);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 36);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDangNhap.BackColor = Color.Peru;
            btnDangNhap.Location = new Point(239, 152);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(120, 36);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.ForeColor = Color.SaddleBrown;
            txtPassword.Location = new Point(184, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(339, 28);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenDangNhap.ForeColor = Color.SaddleBrown;
            txtTenDangNhap.Location = new Point(184, 26);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(339, 28);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.NavajoWhite;
            label3.Location = new Point(25, 67);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.NavajoWhite;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 432);
            Controls.Add(panelCenter);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.SaddleBrown;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnMaximize;
        private Button btnMinimize;
        private Label label1;
        private Panel panelCenter;
        private Label label2;
        private Label label3;
        private Button btnThoat;
        private Button btnDangNhap;
        private TextBox txtPassword;
        private TextBox txtTenDangNhap;
        private Label lblError;
        private LinkLabel lnkRegister;
    }
}