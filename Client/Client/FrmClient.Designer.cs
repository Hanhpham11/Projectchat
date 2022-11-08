namespace Client
{
    partial class FrmClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClient));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessenger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageL = new System.Windows.Forms.ImageList(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntImage = new System.Windows.Forms.Button();
            this.lVChat = new System.Windows.Forms.ListView();
            this.lblFullname = new System.Windows.Forms.Label();
            this.btn_send = new Client.VBButton();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(0, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 39);
            this.label7.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(0, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 39);
            this.label5.TabIndex = 14;
            // 
            // txtMessenger
            // 
            this.txtMessenger.Location = new System.Drawing.Point(67, 448);
            this.txtMessenger.Multiline = true;
            this.txtMessenger.Name = "txtMessenger";
            this.txtMessenger.Size = new System.Drawing.Size(382, 50);
            this.txtMessenger.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(0, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 39);
            this.label4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 39);
            this.label1.TabIndex = 10;
            // 
            // imageL
            // 
            this.imageL.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageL.ImageSize = new System.Drawing.Size(130, 130);
            this.imageL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 509);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(0, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 39);
            this.label6.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 56);
            this.label2.TabIndex = 11;
            this.label2.Text = " ";
            // 
            // bntImage
            // 
            this.bntImage.BackColor = System.Drawing.Color.White;
            this.bntImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImage.Image = ((System.Drawing.Image)(resources.GetObject("bntImage.Image")));
            this.bntImage.Location = new System.Drawing.Point(450, 448);
            this.bntImage.Name = "bntImage";
            this.bntImage.Size = new System.Drawing.Size(65, 52);
            this.bntImage.TabIndex = 21;
            this.bntImage.UseVisualStyleBackColor = false;
            this.bntImage.Click += new System.EventHandler(this.bntImage_Click);
            // 
            // lVChat
            // 
            this.lVChat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lVChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lVChat.BackgroundImage")));
            this.lVChat.ContextMenuStrip = this.contextMenuStrip1;
            this.lVChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVChat.HideSelection = false;
            this.lVChat.Location = new System.Drawing.Point(67, 26);
            this.lVChat.Name = "lVChat";
            this.lVChat.Size = new System.Drawing.Size(519, 422);
            this.lVChat.SmallImageList = this.imageL;
            this.lVChat.TabIndex = 19;
            this.lVChat.UseCompatibleStateImageBehavior = false;
            this.lVChat.View = System.Windows.Forms.View.SmallIcon;
            this.lVChat.SelectedIndexChanged += new System.EventHandler(this.lVChat_SelectedIndexChanged);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFullname.Location = new System.Drawing.Point(69, 1);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(0, 24);
            this.lblFullname.TabIndex = 24;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_send.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_send.BorderRadius = 20;
            this.btn_send.BorderSize = 1;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Image = ((System.Drawing.Image)(resources.GetObject("btn_send.Image")));
            this.btn_send.Location = new System.Drawing.Point(515, 449);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(71, 51);
            this.btn_send.TabIndex = 23;
            this.btn_send.TextColor = System.Drawing.Color.White;
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // FrmClient
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 506);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtMessenger);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntImage);
            this.Controls.Add(this.lVChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClient";
            this.Text = "CLIENT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClient_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessenger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageL;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntImage;
        private System.Windows.Forms.ListView lVChat;
        private VBButton btn_send;
        private System.Windows.Forms.Label lblFullname;
    }
}