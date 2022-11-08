namespace Client
{
    partial class FrmRegis
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
            System.Windows.Forms.Label label1;
            this.txbCpass = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbUs = new System.Windows.Forms.TextBox();
            this.lblNoiCpass = new System.Windows.Forms.Label();
            this.lblNoiPas = new System.Windows.Forms.Label();
            this.lblNoiName = new System.Windows.Forms.Label();
            this.lblNoiUs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Signup = new Client.VBButton();
            this.btn_Login = new Client.VBButton();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(151, 20);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(282, 39);
            label1.TabIndex = 15;
            label1.Text = "Register Account";
            // 
            // txbCpass
            // 
            this.txbCpass.Location = new System.Drawing.Point(199, 321);
            this.txbCpass.Margin = new System.Windows.Forms.Padding(2);
            this.txbCpass.Multiline = true;
            this.txbCpass.Name = "txbCpass";
            this.txbCpass.PasswordChar = '*';
            this.txbCpass.Size = new System.Drawing.Size(294, 33);
            this.txbCpass.TabIndex = 27;
            this.txbCpass.UseSystemPasswordChar = true;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(199, 247);
            this.txbPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbPass.Multiline = true;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(294, 33);
            this.txbPass.TabIndex = 26;
            this.txbPass.UseSystemPasswordChar = true;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(199, 171);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(294, 33);
            this.txbName.TabIndex = 25;
            // 
            // txbUs
            // 
            this.txbUs.Location = new System.Drawing.Point(199, 92);
            this.txbUs.Margin = new System.Windows.Forms.Padding(2);
            this.txbUs.Multiline = true;
            this.txbUs.Name = "txbUs";
            this.txbUs.Size = new System.Drawing.Size(294, 33);
            this.txbUs.TabIndex = 24;
            this.txbUs.TextChanged += new System.EventHandler(this.txbUs_TextChanged);
            // 
            // lblNoiCpass
            // 
            this.lblNoiCpass.AutoSize = true;
            this.lblNoiCpass.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiCpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoiCpass.ForeColor = System.Drawing.Color.Red;
            this.lblNoiCpass.Location = new System.Drawing.Point(198, 411);
            this.lblNoiCpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoiCpass.Name = "lblNoiCpass";
            this.lblNoiCpass.Size = new System.Drawing.Size(0, 17);
            this.lblNoiCpass.TabIndex = 23;
            // 
            // lblNoiPas
            // 
            this.lblNoiPas.AutoSize = true;
            this.lblNoiPas.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoiPas.ForeColor = System.Drawing.Color.Red;
            this.lblNoiPas.Location = new System.Drawing.Point(197, 282);
            this.lblNoiPas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoiPas.Name = "lblNoiPas";
            this.lblNoiPas.Size = new System.Drawing.Size(0, 17);
            this.lblNoiPas.TabIndex = 22;
            // 
            // lblNoiName
            // 
            this.lblNoiName.AutoSize = true;
            this.lblNoiName.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoiName.ForeColor = System.Drawing.Color.Red;
            this.lblNoiName.Location = new System.Drawing.Point(197, 216);
            this.lblNoiName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoiName.Name = "lblNoiName";
            this.lblNoiName.Size = new System.Drawing.Size(0, 17);
            this.lblNoiName.TabIndex = 21;
            // 
            // lblNoiUs
            // 
            this.lblNoiUs.AutoSize = true;
            this.lblNoiUs.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoiUs.ForeColor = System.Drawing.Color.Red;
            this.lblNoiUs.Location = new System.Drawing.Point(197, 139);
            this.lblNoiUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoiUs.Name = "lblNoiUs";
            this.lblNoiUs.Size = new System.Drawing.Size(0, 17);
            this.lblNoiUs.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // btn_Signup
            // 
            this.btn_Signup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Signup.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Signup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Signup.BorderRadius = 20;
            this.btn_Signup.BorderSize = 0;
            this.btn_Signup.FlatAppearance.BorderSize = 0;
            this.btn_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_Signup.ForeColor = System.Drawing.Color.White;
            this.btn_Signup.Location = new System.Drawing.Point(92, 411);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(179, 40);
            this.btn_Signup.TabIndex = 28;
            this.btn_Signup.Text = "Sign up";
            this.btn_Signup.TextColor = System.Drawing.Color.White;
            this.btn_Signup.UseVisualStyleBackColor = false;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Login.BorderRadius = 20;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(301, 411);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(192, 40);
            this.btn_Login.TabIndex = 29;
            this.btn_Login.Text = "Have account? Login";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // FrmRegis
            // 
            this.AcceptButton = this.btn_Signup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.ClientSize = new System.Drawing.Size(542, 572);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.txbCpass);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbUs);
            this.Controls.Add(this.lblNoiCpass);
            this.Controls.Add(this.lblNoiPas);
            this.Controls.Add(this.lblNoiName);
            this.Controls.Add(this.lblNoiUs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Name = "FrmRegis";
            this.Text = "FrmRegis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCpass;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbUs;
        private System.Windows.Forms.Label lblNoiCpass;
        private System.Windows.Forms.Label lblNoiPas;
        private System.Windows.Forms.Label lblNoiName;
        private System.Windows.Forms.Label lblNoiUs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private VBButton btn_Signup;
        private VBButton btn_Login;
    }
}