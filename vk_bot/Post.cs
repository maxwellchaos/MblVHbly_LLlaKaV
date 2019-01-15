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
    public partial class Post : Form
    {
        public string access_token;
        public Post()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                string request9 = "https://api.vk.com/method/likes.add?type=post&owner_id=" + 
                    listView1.SelectedItems[0].SubItems[1].Text + "&item_id=" + 
                    listView1.SelectedItems[0].SubItems[2].Text +  "&access_token=" + Form1.access_token + "&v=5.92";
                WebClient client1 = new WebClient();
                string answer8 = Encoding.UTF8.GetString(client1.DownloadData(request9));
            }

            string request = "https://api.vk.com/method/likes.add?owner_id=-142950151&item_id=41758&access_token=" + Form1.access_token + "&v=5.92";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));
        }

        private void Post_Load(object sender, EventArgs e)
        {
            try
            {
                string request2 = "https://api.vk.com/method/likes.add?type=post&owner_id=-142950151&item_id=43863&access_token=" + Form1.access_token + "&v=5.92";

                WebClient client = new WebClient();

                string answer = Encoding.UTF8.GetString(client.DownloadData(request2));//
                like li = JsonConvert.DeserializeObject<like>(answer);
                postt po;
                po = JsonConvert.DeserializeObject<postt>(answer);


                
            }
            catch (Exception ex)
            {
                label1.Text = "ошибка";
            }


            string request4 = "https://api.vk.com/method/wall.get?owner_id=-24299135&access_token=" + Form1.access_token + "&v=5.92 ";
            WebClient wct = new WebClient();
            string answer3 = Encoding.UTF8.GetString(wct.DownloadData(request4));
            like lis = JsonConvert.DeserializeObject<like>(answer3);

            postt gr;
            gr = JsonConvert.DeserializeObject<postt>(answer3);

            string request3 = "https://api.vk.com/method/wall.get?owner_id=-142950151&access_token=" + Form1.access_token + "&v=5.92";
            WebClient wc = new WebClient();
            string answer2 = Encoding.UTF8.GetString(wc.DownloadData(request3));
            like lik = JsonConvert.DeserializeObject<like>(answer2);

            for (int itemIndex = 0; itemIndex < gr.response.items.Length; itemIndex = itemIndex + 1)
            {
                string[] names = new string[3];
                names[0] = gr.response.items[itemIndex].text;
                names[1] = gr.response.items[itemIndex].owner_id.ToString();
                names[2] = gr.response.items[itemIndex].id.ToString();
                ListViewItem lvi = new ListViewItem(names, imageList1.Images.Count - 1);
                listView1.Items.Add(lvi);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
