namespace Server
{
    partial class FrmLogin
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
            this.lblNotiPas = new System.Windows.Forms.Label();
            this.lblNotiUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Signin = new Client.VBButton();
            this.SuspendLayout();
            // 
            // lblNotiPas
            // 
            this.lblNotiPas.AutoSize = true;
            this.lblNotiPas.BackColor = System.Drawing.Color.Transparent;
            this.lblNotiPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNotiPas.ForeColor = System.Drawing.Color.Red;
            this.lblNotiPas.Location = new System.Drawing.Point(47, 303);
            this.lblNotiPas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotiPas.Name = "lblNotiPas";
            this.lblNotiPas.Size = new System.Drawing.Size(0, 20);
            this.lblNotiPas.TabIndex = 41;
            // 
            // lblNotiUser
            // 
            this.lblNotiUser.AutoSize = true;
            this.lblNotiUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNotiUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNotiUser.ForeColor = System.Drawing.Color.Red;
            this.lblNotiUser.Location = new System.Drawing.Point(47, 164);
            this.lblNotiUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotiUser.Name = "lblNotiUser";
            this.lblNotiUser.Size = new System.Drawing.Size(0, 20);
            this.lblNotiUser.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(72, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(70, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Username";
            // 
            // txbPass
            // 
            this.txbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbPass.Location = new System.Drawing.Point(36, 254);
            this.txbPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbPass.Multiline = true;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(374, 37);
            this.txbPass.TabIndex = 37;
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbUsername.Location = new System.Drawing.Point(36, 125);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(374, 37);
            this.txbUsername.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::Server.Properties.Resources.pass;
            this.label3.Location = new System.Drawing.Point(39, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 28);
            this.label3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::Server.Properties.Resources.user;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 37);
            this.label2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "Login System";
            // 
            // btn_Signin
            // 
            this.btn_Signin.BackColor = System.Drawing.Color.Peru;
            this.btn_Signin.BackgroundColor = System.Drawing.Color.Peru;
            this.btn_Signin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Signin.BorderRadius = 20;
            this.btn_Signin.BorderSize = 1;
            this.btn_Signin.FlatAppearance.BorderSize = 0;
            this.btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn_Signin.ForeColor = System.Drawing.Color.White;
            this.btn_Signin.Location = new System.Drawing.Point(74, 370);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(261, 48);
            this.btn_Signin.TabIndex = 42;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.TextColor = System.Drawing.Color.White;
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btn_Signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Server.Properties.Resources.bgl;
            this.ClientSize = new System.Drawing.Size(459, 451);
            this.Controls.Add(this.btn_Signin);
            this.Controls.Add(this.lblNotiPas);
            this.Controls.Add(this.lblNotiUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "LOGINSERVER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotiPas;
        private System.Windows.Forms.Label lblNotiUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Client.VBButton btn_Signin;
    }
}

