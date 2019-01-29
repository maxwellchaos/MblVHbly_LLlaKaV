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
    public partial class AButton : Form
    {
        public string access_token;
        public string userIdd;
        public AButton()
        {
            InitializeComponent();
        }

        private void AButton_Load(object sender, EventArgs e)
        {
            string request2 = "https://api.vk.com/method/groups.get?user_id=" + userIdd + "&fields=photo_100&extended=1&access_token=" + access_token + "&v=5.87";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request2));


            groupsGet gr;
            gr = JsonConvert.DeserializeObject<groupsGet>(answer);

            for (int itemIndex = 0; itemIndex < gr.response.items.Length; itemIndex = itemIndex + 1)
            {
                string [] names = new string[4];
                names[0] = gr.response.items[itemIndex].name;
                names[1] = gr.response.items[itemIndex].id.ToString();
                names[2] = gr.response.items[itemIndex].photo_100;
                names[3] = @"https://vk.com/"+gr.response.items[itemIndex].screen_name;
                pictureBox1.Load(gr.response.items[itemIndex].photo_100);
                Application.DoEvents();
                imageList1.Images.Add(pictureBox1.Image);
                ListViewItem lvi = new ListViewItem(names, imageList1.Images.Count-1);
                listView1.Items.Add(lvi);
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                label1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                label3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                linkLabel1.Text = listView1.SelectedItems[0].SubItems[3].Text;
                pictureBox1.Visible = true;
                pictureBox1.Image = imageList1.Images[listView1.SelectedItems[0].ImageIndex];
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Post pos = new Post();
            pos.group_id = listView1.SelectedItems[0].SubItems[1].Text; ;

            pos.ShowDialog();
            

        }
    }
}
