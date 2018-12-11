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

namespace VkBot
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
                access_token = e.Url.ToString();
                int pos = access_token.IndexOf("access_token=");
                pos += "access_token=".Length;
                access_token = access_token.Remove(0, pos);
                pos = access_token.IndexOf("&");
                access_token = access_token.Remove(pos);
                string request = "https://api.vk.com/method/users.get?user_ids=509563461&fields=photo_100&access_token=" + access_token + "&v=5.87";

                WebClient client = new WebClient();
                ///string answer = client.DownloadString(request);
                string answer = Encoding.UTF8.GetString( client.DownloadData(request));
                User user = JsonConvert.DeserializeObject<User>(answer);

                pictureBox1.Load(user.response[0].photo_100);
                label1.Text = user.response[0].first_name;



                string request2 = "https://api.vk.com/method/messages.getConversations?offset=0&count=200&filter=all&extended=1&start_message_id=0&access_token=" + access_token + "&v=5.87";

                WebClient client2 = new WebClient();
                string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));
                User user2 = JsonConvert.DeserializeObject<User>(answer2);

                








            }
        }
    }
}
