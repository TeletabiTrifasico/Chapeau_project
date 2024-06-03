namespace ChapeauUI._2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtBoxUserName = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            pictureBoxLogo = new PictureBox();
            lblUserName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(394, 313);
            txtBoxUserName.Multiline = true;
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(637, 145);
            txtBoxUserName.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(394, 497);
            txtBoxPassword.Multiline = true;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(637, 145);
            txtBoxPassword.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(498, 690);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(416, 112);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(498, 50);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(416, 201);
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point);
            lblUserName.Location = new Point(87, 352);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(262, 65);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(87, 526);
            label1.Name = "label1";
            label1.Size = new Size(225, 65);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 889);
            Controls.Add(label1);
            Controls.Add(lblUserName);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUserName);
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxUserName;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private PictureBox pictureBoxLogo;
        private Label lblUserName;
        private Label label1;
    }
}
