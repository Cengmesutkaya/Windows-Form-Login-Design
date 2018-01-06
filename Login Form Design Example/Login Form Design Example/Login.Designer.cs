namespace Login_Form_Design_Example
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbxRemember = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblErrorMessage = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Depth = 0;
            this.txtUserName.Hint = "";
            this.txtUserName.Location = new System.Drawing.Point(104, 168);
            this.txtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.Size = new System.Drawing.Size(247, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(176, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Welcome";
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(104, 213);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(247, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cbxRemember
            // 
            this.cbxRemember.AutoSize = true;
            this.cbxRemember.BackColor = System.Drawing.Color.Transparent;
            this.cbxRemember.Depth = 0;
            this.cbxRemember.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxRemember.Location = new System.Drawing.Point(104, 262);
            this.cbxRemember.Margin = new System.Windows.Forms.Padding(0);
            this.cbxRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxRemember.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxRemember.Name = "cbxRemember";
            this.cbxRemember.Ripple = true;
            this.cbxRemember.Size = new System.Drawing.Size(120, 30);
            this.cbxRemember.TabIndex = 4;
            this.cbxRemember.Text = "Remember Me";
            this.cbxRemember.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(104, 315);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(247, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Depth = 0;
            this.lblErrorMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorMessage.Location = new System.Drawing.Point(100, 370);
            this.lblErrorMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMessage.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxRemember);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUserName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialCheckBox cbxRemember;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel lblErrorMessage;
    }
}

