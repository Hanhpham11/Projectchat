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

namespace Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        //Kết nối tới Server
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 2021);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 2021);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }

            });

            Listen.IsBackground = true;
            Listen.Start();
        }
        //Đóng kết nối hiện thời 
        void Close()
        {
            server.Close();
        }
        //Gửi tin
        void Send(Socket client)
        {
            if (client != null && txtMessenger.Text != string.Empty)
            {
                client.Send(Serialize("Server:" + txtMessenger.Text));
            }
        }
        //Nhận tin
        int id = -1;

        void Receive(object obj)
        {

            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    obj = Deserialize(data);
                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            if (obj.GetType().ToString() == "System.String")
                            {
                                item.Send(data);
                                DateTime dt = DateTime.Now;
                                lVChat.Items.Add((String)obj + " " + "(" + dt.Hour + ":" + dt.Minute + ")");
                            }
                            else if (obj.GetType().ToString() == "System.Drawing.Bitmap")
                            {
                                id++;
                                Image image = (Image)Deserialize(data);
                                imageL.Images.Add(id + "", image);
                                ListViewItem it = new ListViewItem();
                                it.ImageKey = id + "";
                                item.Send(data);
                                lVChat.Items.Add(it);

                            }
                            lVChat.EnsureVisible(lVChat.Items.Count - 1);
                        }
                    }

                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
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
        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        //Add message vào khung chat
        void AddMessage(string s)
        {
            DateTime dt = DateTime.Now;
            lVChat.Items.Add(new ListViewItem() { Text =  s + " " + "(" + dt.Hour + ":" + dt.Minute + ")" });
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send( item);
            }
            AddMessage(txtMessenger.Text);
            txtMessenger.Clear();
        }
        // them hinh anh vao khung chat
        void addImg(string p)
        {
            id++;
            imageL.Images.Add(Image.FromFile(p));
            ListViewItem item = new ListViewItem();
            item.ImageIndex = id;
            lVChat.Items.Add(item);

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"";
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
                Image image = Image.FromFile(path);
                byte[] data = new byte[1024 * 2000];
                FileInfo fi = new FileInfo(path);
                data = Serialize(image);
                if (fi.Length > data.Length)
                {
                    MessageBox.Show("Allowed 2MB file upload");
                    return;
                }
                else
                {
                    foreach (Socket item in clientList)
                    {
                        item.Send(data);
                        addImg(path);
                    }
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
                lVChat.Items[chonItem].Text = "Đã Xóa";
                lVChat.Items[chonItem].ImageKey = "";
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
