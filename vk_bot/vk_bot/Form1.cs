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
    public partial class Form1 : Form
    {
        string access_token;

        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().Contains("access_token="))
            {
                webBrowser1.Visible = false;
                access_token = e.Url.ToString();
                int pos = access_token.IndexOf("access_token=");
                pos += "access_token=".Length;
                access_token = access_token.Remove(0, pos);
                pos = access_token.IndexOf("&");
                access_token = access_token.Remove(pos);
                string request = "https://api.vk.com/method/users.get?user_ids=56929156&fields=photo_100,bdate&access_token="  +access_token+ "&v=5.87";
                //string request2 = "https://api.vk.com/method/groups.get?user_id=56929156&fields=photo_100&extended=1&access_token=" + access_token + "&v=5.87";
                WebClient client = new WebClient();
                //string answer = client.DownloadString(request);
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                User user = JsonConvert.DeserializeObject<User>(answer);

                AvatarPictureBox.Load(user.response[0].photo_100);
                FirstNameLabel.Text = user.response[0].first_name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.BringToFront();
        }

        private void autoAnswerButton_Click(object sender, EventArgs e)
        {
            AutoAnswerForm frm = new AutoAnswerForm();
            frm.Show();
        }

        private void AutoMessageButton_Click(object sender, EventArgs e)
        {
            AutoMessageForm amfrm = new AutoMessageForm();
            amfrm.ShowDialog();
        }

        private void delete_friends_Click(object sender, EventArgs e)
        {
            delete_friend dlf = new delete_friend();
            dlf.access_token = access_token;
            dlf.ShowDialog();
        }
    }
}
