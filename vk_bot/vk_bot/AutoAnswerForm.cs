using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.ObjectModel;

using Newtonsoft.Json;

namespace vk_bot
{
    public partial class AutoAnswerForm : Form
    {
        public string access_token;
        public string groupId;
        public string userId;
        public AutoAnswerForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormPreceous_Load(object sender, EventArgs e)
        {
            string request = "https://api.vk.com/method/groups.get?extended=1&access_token=" + access_token + "&v=5.87";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            Group gr;
            gr = JsonConvert.DeserializeObject<Group>(answer);

            try
            {
                for (int itemIndex = 0; itemIndex < gr.response.items.Length; itemIndex = itemIndex + 1)
                {
                    string[] names = new string[3];
                    names[0] = gr.response.items[itemIndex].name;
                    names[1] = gr.response.items[itemIndex].id.ToString();
                    names[2] = gr.response.items[itemIndex].photo_50;
                    pictureBox1.Load(gr.response.items[itemIndex].photo_50);
                    Application.DoEvents();
                    imageList1.Images.Add(pictureBox1.Image);
                    ListViewItem lvi = new ListViewItem(names, imageList1.Images.Count - 1);
                    listView1.Items.Add(lvi);

                }
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Возникла непредвиденная ошибка";
                ErrorLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                label1.Text = listView1.SelectedItems[0].SubItems[1].Text;

                PostsForm pfrm = new PostsForm();
                pfrm.access_token = access_token;
                pfrm.groupId = label1.Text;
                pfrm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collection<string> grIds = new Collection<string>();
            if (listView1.SelectedItems.Count > 0)
            {
                label1.Text = listView1.SelectedItems[0].SubItems[1].Text;

                foreach (ListViewItem str in listView1.SelectedItems)
                {
                    grIds.Add(str.SubItems[1].Text);
                }

                LastPostComment lpc = new LastPostComment();
                lpc.access_token = access_token;
                lpc.groupId = label1.Text;
                lpc.userId = userId;
                lpc.grIds = grIds;
                lpc.ShowDialog();
            }
        }
    }
}