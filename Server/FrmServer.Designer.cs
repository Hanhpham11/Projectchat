namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageL = new System.Windows.Forms.ImageList(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saoChépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnTiếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMessenger = new System.Windows.Forms.TextBox();
            this.lVChat = new System.Windows.Forms.ListView();
            this.btn_send = new Client.VBButton();
            this.btnImage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 492);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(0, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 39);
            this.label6.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Image = global::Server.Properties.Resources.logo;
            this.label2.Location = new System.Drawing.Point(1, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 55);
            this.label2.TabIndex = 11;
            // 
            // imageL
            // 
            this.imageL.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageL.ImageSize = new System.Drawing.Size(190, 180);
            this.imageL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.xóaToolStripMenuItem.Text = "Thu hồi";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.saoChépToolStripMenuItem,
            this.chuyểnTiếpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            // 
            // saoChépToolStripMenuItem
            // 
            this.saoChépToolStripMenuItem.Name = "saoChépToolStripMenuItem";
            this.saoChépToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saoChépToolStripMenuItem.Text = "Sao chép";
            // 
            // chuyểnTiếpToolStripMenuItem
            // 
            this.chuyểnTiếpToolStripMenuItem.Name = "chuyểnTiếpToolStripMenuItem";
            this.chuyểnTiếpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.chuyểnTiếpToolStripMenuItem.Text = "Chuyển tiếp";
            // 
            // txtMessenger
            // 
            this.txtMessenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMessenger.Location = new System.Drawing.Point(69, 448);
            this.txtMessenger.Multiline = true;
            this.txtMessenger.Name = "txtMessenger";
            this.txtMessenger.Size = new System.Drawing.Size(374, 50);
            this.txtMessenger.TabIndex = 19;
            // 
            // lVChat
            // 
            this.lVChat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lVChat.BackgroundImage = global::Server.Properties.Resources.bg;
            this.lVChat.BackgroundImageTiled = true;
            this.lVChat.ContextMenuStrip = this.contextMenuStrip1;
            this.lVChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVChat.HideSelection = false;
            this.lVChat.LargeImageList = this.imageL;
            this.lVChat.Location = new System.Drawing.Point(69, 6);
            this.lVChat.MaximumSize = new System.Drawing.Size(515, 442);
            this.lVChat.Name = "lVChat";
            this.lVChat.Size = new System.Drawing.Size(515, 442);
            this.lVChat.SmallImageList = this.imageL;
            this.lVChat.TabIndex = 18;
            this.lVChat.UseCompatibleStateImageBehavior = false;
            this.lVChat.View = System.Windows.Forms.View.SmallIcon;
            this.lVChat.SelectedIndexChanged += new System.EventHandler(this.lVChat_SelectedIndexChanged);
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
            this.btn_send.Image = global::Server.Properties.Resources.send;
            this.btn_send.Location = new System.Drawing.Point(511, 448);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(73, 53);
            this.btn_send.TabIndex = 22;
            this.btn_send.TextColor = System.Drawing.Color.White;
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.White;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.Location = new System.Drawing.Point(441, 448);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(65, 52);
            this.btnImage.TabIndex = 20;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // FrmServer
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 506);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.txtMessenger);
            this.Controls.Add(this.lVChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(605, 545);
            this.Name = "FrmServer";
            this.Text = "SERVER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageL;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtMessenger;
        private System.Windows.Forms.ListView lVChat;
        private Client.VBButton btn_send;
        private System.Windows.Forms.ToolStripMenuItem saoChépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnTiếpToolStripMenuItem;
    }
}