using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace vk_bot
{
    public partial class LikeForm : Form
    {
        public LikeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string request = "https://api.vk.com/method/likes.add?type=post&item_id=" + textBox1.Text + "&owner_id=" + textBox2.Text + "&access_token=" +Form1.access_token+ "&v=5.92 ";
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));
            textBox3.Text = answer;
        }

        private void LikeForm_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.idd;
        }
    }
}
