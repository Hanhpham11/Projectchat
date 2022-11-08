namespace Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_Signin = new Client.VBButton();
            this.lblNotiPas = new System.Windows.Forms.Label();
            this.lblNotiUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_regis = new Client.VBButton();
            this.SuspendLayout();
            // 
            // btn_Signin
            // 
            this.btn_Signin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Signin.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Signin.BorderColor = System.Drawing.Color.GhostWhite;
            this.btn_Signin.BorderRadius = 20;
            this.btn_Signin.BorderSize = 1;
            this.btn_Signin.FlatAppearance.BorderSize = 0;
            this.btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btn_Signin.ForeColor = System.Drawing.Color.White;
            this.btn_Signin.Location = new System.Drawing.Point(98, 333);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(261, 44);
            this.btn_Signin.TabIndex = 52;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.TextColor = System.Drawing.Color.White;
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // lblNotiPas
            // 
            this.lblNotiPas.AutoSize = true;
            this.lblNotiPas.BackColor = System.Drawing.Color.Transparent;
            this.lblNotiPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNotiPas.ForeColor = System.Drawing.Color.Red;
            this.lblNotiPas.Location = new System.Drawing.Point(50, 303);
            this.lblNotiPas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotiPas.Name = "lblNotiPas";
            this.lblNotiPas.Size = new System.Drawing.Size(0, 20);
            this.lblNotiPas.TabIndex = 51;
            // 
            // lblNotiUser
            // 
            this.lblNotiUser.AutoSize = true;
            this.lblNotiUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNotiUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNotiUser.ForeColor = System.Drawing.Color.Red;
            this.lblNotiUser.Location = new System.Drawing.Point(50, 164);
            this.lblNotiUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotiUser.Name = "lblNotiUser";
            this.lblNotiUser.Size = new System.Drawing.Size(0, 20);
            this.lblNotiUser.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(75, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(73, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Username";
            // 
            // txbPass
            // 
            this.txbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbPass.Location = new System.Drawing.Point(39, 254);
            this.txbPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbPass.Multiline = true;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(374, 37);
            this.txbPass.TabIndex = 47;
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbUsername.Location = new System.Drawing.Point(39, 125);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(374, 37);
            this.txbUsername.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(42, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 28);
            this.label3.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 37);
            this.label2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 36);
            this.label1.TabIndex = 43;
            this.label1.Text = "Welcome To Chat App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_regis
            // 
            this.btn_regis.BackColor = System.Drawing.Color.Transparent;
            this.btn_regis.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_regis.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btn_regis.BorderRadius = 20;
            this.btn_regis.BorderSize = 1;
            this.btn_regis.FlatAppearance.BorderSize = 0;
            this.btn_regis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_regis.ForeColor = System.Drawing.Color.DimGray;
            this.btn_regis.Location = new System.Drawing.Point(98, 399);
            this.btn_regis.Name = "btn_regis";
            this.btn_regis.Size = new System.Drawing.Size(261, 44);
            this.btn_regis.TabIndex = 53;
            this.btn_regis.Text = "Don\'t have account? Register now";
            this.btn_regis.TextColor = System.Drawing.Color.DimGray;
            this.btn_regis.UseVisualStyleBackColor = false;
            this.btn_regis.Click += new System.EventHandler(this.btn_regis_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btn_Signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(459, 451);
            this.Controls.Add(this.btn_regis);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "LoginC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VBButton btn_Signin;
        private System.Windows.Forms.Label lblNotiPas;
        private System.Windows.Forms.Label lblNotiUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private VBButton btn_regis;
    }
}

