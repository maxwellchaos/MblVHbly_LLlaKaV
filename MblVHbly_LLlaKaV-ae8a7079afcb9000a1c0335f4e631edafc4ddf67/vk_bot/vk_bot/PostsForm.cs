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
    public partial class PostsForm : Form
    {
        public string access_token;
        public string groupId;

        public PostsForm()
        {
            InitializeComponent();
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
            string request2 = "https://api.vk.com/method/wall.get?owner_id=-" + groupId + "&count=20&access_token=" + access_token + "&v=5.87";

            WebClient client = new WebClient();
            string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));

            PostR po;
            po = JsonConvert.DeserializeObject<PostR>(answer2);

            try
            {
                listView1.Clear();
                for (int textIndex = 0; textIndex < po.response.items.Length; textIndex = textIndex + 1)
                {
                    if (po.response.items[textIndex].marked_as_ads == 0)
                    {
                        string[] texts = new string[3];
                        texts[0] = po.response.items[textIndex].text;
                        texts[1] = po.response.items[textIndex].id.ToString();
                        if (po.response.items[textIndex].attachments != null && po.response.items[textIndex].attachments[0].photo != null)
                        {
                            texts[2] = po.response.items[textIndex].attachments[0].photo.sizes[0].url;
                            pictureBox1.Load(po.response.items[textIndex].attachments[0].photo.sizes[0].url);
                            Application.DoEvents();
                            imageList1.Images.Add(pictureBox1.Image);
                        }

                        
                        
                        if (po.response.items[textIndex].attachments != null)
                        {
                            if (po.response.items[textIndex].attachments[0].photo == null)
                            {
                                ListViewItem lvi = new ListViewItem(texts);
                                listView1.Items.Add(lvi);
                            }
                            else
                            {
                                ListViewItem lvi = new ListViewItem(texts, imageList1.Images.Count - 1);
                                listView1.Items.Add(lvi);
                            }
                        }
                        else
                        {
                            ListViewItem lvi = new ListViewItem(texts);
                            listView1.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Возникла непредвиденная ошибка";
                ErrorLabel.Visible = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                CommentForm cfrm = new CommentForm();
                cfrm.access_token = access_token;
                cfrm.groupId = groupId;
                cfrm.postId = listView1.SelectedItems[0].SubItems[1].Text;
                cfrm.ShowDialog();
            }
        }
    }
}
