using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace vk_bot
{
    public partial class Rassilka : Form
    {
        public Rassilka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zapros = "https://api.vk.com/method/friends.get?&access_token=" + Pusia_.access_token + "&v=5.87";
            WebClient clientt = new WebClient();
            string spisok = Encoding.UTF8.GetString(clientt.DownloadData(zapros));
            SpisokDruzei msg = JsonConvert.DeserializeObject<SpisokDruzei>(spisok);

            string zapross = "https://api.vk.com/method/groups.getMembers?group_id=177471057&access_token=" + Pusia_.access_token + "&v=5.87";
            WebClient clienttt = new WebClient();
            string spisokk = Encoding.UTF8.GetString(clienttt.DownloadData(zapross));
            SpisokUchasnikov msgf = JsonConvert.DeserializeObject<SpisokUchasnikov>(spisokk);
            //класс SpisokUchastnikov во Vhod

            foreach (int itm in msg.response.items)
            {
                string ein = "https://api.vk.com/method/messages.send?user_id=" + itm.ToString() + "&message=" + textBox1.Text + "&access_token=" + Pusia_.access_token + "&v=5.87";
                WebClient zwei = new WebClient();
                string drei = Encoding.UTF8.GetString(zwei.DownloadData(ein));
                System.Threading.Thread.Sleep(5000);
                Application.DoEvents();
            }
            label2.Visible = true;

            
            //SpisokUchasnikov vier = JsonConvert.DeserializeObject<SpisokUchasnikov>(drei);


        }

        public class Response
        {
            public int count { get; set; }
            public List<int> items { get; set; }
        }

        public class SpisokDruzei
        {
            public Response response { get; set; }
        }
        
        

    }
}
