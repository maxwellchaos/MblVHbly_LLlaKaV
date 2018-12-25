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
    public partial class LastPostComment : Form
    {
        public string access_token;
        public string groupId;
        public string postId;
        public string userId;
        public int postTime;
        public Collection<string> grIds = new Collection<string>();

        public LastPostComment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems[0]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow;
            
            foreach (string groupId in grIds)
            {
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                string request = "https://api.vk.com/method/wall.get?owner_id=-" + groupId + "&count=2&extended=1&access_token=" + access_token + "&v=5.87";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                System.Threading.Thread.Sleep(30);//Ждать 30 мс
                Application.DoEvents();
                System.Threading.Thread.Sleep(30);//Ждать 100 мс
                Application.DoEvents();
                System.Threading.Thread.Sleep(30);//Ждать 100 мс

                Post po = new Post();
                po = JsonConvert.DeserializeObject<Post>(answer);

                if (answer.Contains("error"))
                {
                    continue;
                }

                if (po.response.items.Length != 0)
                {
                    if (po.response.items[0].is_pinned == 0)
                    {
                        postTime = po.response.items[0].date;
                        postId = po.response.items[0].id.ToString();
                    }
                    else
                    {
                        postTime = po.response.items[1].date;
                        postId = po.response.items[1].id.ToString();
                    }
                }

                string request3 = "https://api.vk.com/method/wall.getComments?owner_id=-" + groupId + "&post_id=" + postId + "&count=50&sort=desc&access_token=" + access_token + "&v=5.87";
                string answer3 = Encoding.UTF8.GetString(client.DownloadData(request3));

                Comments co = new Comments();
                co = JsonConvert.DeserializeObject<Comments>(answer3);
                Application.DoEvents();
                origin = origin.AddSeconds(postTime);
                bool fi = false;

                try
                {
                    foreach (Comments.Response.Item cm in co.response.items)
                    {
                        if (cm.from_id.ToString() == userId)
                        {
                            fi = true;
                        }
                    }
                }
                catch (Exception)
                {

                }
                Application.DoEvents();
                if (now < origin.AddMinutes(1) && fi == false)
                {
                    try
                    {
                        string request2 = "https://api.vk.com/method/wall.createComment?owner_id=-" + groupId + "&post_id=" + postId + "&message=" + listBox1.Text + "&access_token=" + access_token + "&v=5.87";
                        string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));

                        if (answer.Contains("error"))
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        CommentErrorForm cef = new CommentErrorForm();
                        cef.ShowDialog();
                        DialogResult res;
                        res = cef.ShowDialog();

                        if (res == DialogResult.OK)
                        {
                            cef.Close();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void LastPostComment_Load(object sender, EventArgs e)
        {
            
        }
    }
}
