using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime;

namespace Client
{
    public partial class FrmClient : Form
    {
        public FrmClient(string Fullname)
        {
            InitializeComponent();
            lblFullname.Text = Fullname;
            CheckForIllegalCrossThreadCalls = false;

            Connect();

        }
        IPEndPoint IP;
        Socket client;

        //Kết nối tới Server
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2021);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối Server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        //Đóng kết nối hiện thời 
        private void Close()
        {
            client.Close();
        }
        //Gửi tin
        void Send()
        {
            if (txtMessenger.Text != string.Empty)
            {
                client.Send(Serialize(lblFullname.Text+ ":" + txtMessenger.Text));
            }
            else{
	             MessageBox.Show("Không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DateTime dt = DateTime.Now;
        //Nhận tin
        void Receive()
        {
            /*acc = new AccessData();
            SqlDataReader dta = acc.ExecuteReader("select* from [C_user]");*/
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    object obj = Deserialize(data);
                    if (obj.GetType().ToString() == "System.String")
                    {

                        lVChat.Items.Add((String)obj + " " + "(" + dt.Hour + ":" + dt.Minute + ")");

                    }
                    else
                        if (obj.GetType().ToString() == "System.Drawing.Bitmap")
                    {

                        id++;
                        Image image = (Image)Deserialize(data);
                        imageL.Images.Add(id + "", image);
                        ListViewItem item = new ListViewItem();
                        item.ImageKey = id + "";
                        lVChat.Items.Add(item);
                    }
                    lVChat.EnsureVisible(lVChat.Items.Count - 1);
                }
            }
            catch
            {
                Close();
            }
        }
        //Phân mảnh
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        //Gom mảnh lại
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        private void FrmClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        //Add message vào khung chat
        void AddMessage(string s)
        {

            lVChat.Items.Add(new ListViewItem() { Text = lblFullname.Text + ":"+ s + " " + "(" + dt.Hour + ":" + dt.Minute + ")" });
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txtMessenger.Text);
            txtMessenger.Clear();
        }
        int id = -1;
        // them hinh anh vao khung chat
        void addImg(string p)
        {
            id++;
            imageL.Images.Add(Image.FromFile(p));
            ListViewItem item = new ListViewItem();
            item.ImageIndex = id;
            lVChat.Items.Add(item);
            

        }

        private void bntImage_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"";
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
                Image image = Image.FromFile(path);
                byte[] data = new byte[1024 * 9000];//~2MB
                data = Serialize(image);
                FileInfo fi = new FileInfo(path);
                if (fi.Length > data.Length)
                {
                    MessageBox.Show("Allowed 2MB file upload");
                    return;
                }
                else
                {
                    client.Send(data);
                    addImg(path);
                }

            }
            catch (Exception)
            {
            }
        }
        int chonItem = -1;

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (chonItem == -1)
                    return;
                lVChat.Items[chonItem].Text = "Tin nhắn đã được thu hồi";
                lVChat.Items[chonItem].ImageKey = "Tin nhắn đã được thu hồi";
            }
            catch
            {
            }
        }

        private void lVChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chonItem = lVChat.SelectedIndices[0];
            }
            catch
            {
            }
        }
    }
}
