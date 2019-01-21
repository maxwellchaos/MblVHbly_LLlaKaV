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
    public partial class MainMenu : Form
    {
        string access_token;
        public string userId;

        public MainMenu()
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
                string request = "https://api.vk.com/method/users.get?fields=photo_100,bdate&access_token=" + access_token + "&v=5.87";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString( client.DownloadData(request));
                User user = JsonConvert.DeserializeObject<User>(answer);

                try
                {
                    AvatarPictureBox.Load(user.response[0].photo_100);
                    NameLabel.Text = user.response[0].first_name + " " + user.response[0].last_name;
                    userId = user.response[0].id;
                }
                catch (Exception)
                {
                    ErrorLabel.Text = "Возникла непредвиденная ошибка";
                    ErrorLabel.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.BringToFront();
        }

        private void autoAnswerButton_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;

            AutoAnswerForm frm = new AutoAnswerForm();
            frm.access_token = access_token;
            frm.userId = userId;
            frm.mainform = this;
            frm.Show();
        }

        private void AutoMessageButton_Click(object sender, EventArgs e)
        {
            AutoMessageForm amfrm = new AutoMessageForm();
            amfrm.ShowDialog();
        }
    }
}
