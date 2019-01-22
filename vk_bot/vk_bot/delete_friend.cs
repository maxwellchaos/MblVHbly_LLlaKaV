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
using System.IO;
namespace vk_bot
{
    public partial class delete_friend : Form
    {
        public string access_token;
        double timestamp;
        int datr;
        int qwr;
        int a = 0;
        int tm = 0;
        int gh = 0;
        int sch = 0;
        int fr = 0;
        string mes;
        int asd = 0;
        string listmes;
        int num;
        bool rep = false;
        int q;
        String line;
        string numbermyid;
        public delete_friend()
        {
            InitializeComponent();
        }
        private void delete_friend_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\id.txt");
            line = sr.ReadLine();
            if (line == "1")
            { idbox.Text = "введите свой id"; }
            else
            {
                idbox.Text = line;
            }
            sr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            if (a == 10)
            {
                a = 1;
            }
                
                switch(a)
                {
                    case 1:
                        btclick.BackColor = Color.Blue;
                        break;
                    case 2:
                        btclick.BackColor = Color.Gold;
                        break;
                    case 3:
                        btclick.BackColor = Color.LemonChiffon;
                        break;

                    case 4:
                        btclick.BackColor = Color.Olive;
                        break;
                    case 5:
                        btclick.BackColor = Color.PaleGreen;
                        break;
                    case 6:
                        btclick.BackColor = Color.Pink;
                        break;
                    case 7:
                        btclick.BackColor = Color.SeaGreen;
                        break;
                    case 8:
                        btclick.BackColor = Color.Silver;
                        break;
                    case 9:
                        btclick.BackColor = Color.Snow;
                        break;
                }

            
            
                try
                {
                    if (timebox.Text == "часы")
                    {
                        string qwerty = ttbox.Text;
                        datr = Convert.ToInt32(qwerty);
                        datr = datr * 60 * 60;
                    }
                    else
                        if (timebox.Text == "секунды")
                        {
                            string qwerty = ttbox.Text;

                            datr = Convert.ToInt32(qwerty);
                        }
                        else
                            if (timebox.Text == "дни")
                            {
                                string qwerty = ttbox.Text;
                                datr = Convert.ToInt32(qwerty);
                                datr = datr * 60 * 60 * 24;
                            }
                   
                   
                }
                catch
                {
                    sclab.Visible = true;
                    sclab.Text = "ERROR!";
                    gh++;
                }

                if (gh == 0)
                {
                    time2.Enabled = false;
                    sclab.Text = "successfully!";
                    sclab.Visible = true;
                    q = datr;
                    time1.Enabled = true;
                    btclick.Cursor = Cursors.No;
                    btclick.Text = "Wait";
                    btclick.Enabled = false;
                }
                gh = 0;
            }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            string reqest5 = "https://api.vk.com/method/messages.getConversations?count=100&extended=1&fields=id,first_name,friend_status&access_token=" + access_token + "&v=5.87";
            WebClient client5 = new WebClient();
            string answer5 = Encoding.UTF8.GetString(client5.DownloadData(reqest5));
            RootObject user;
            user = JsonConvert.DeserializeObject<RootObject>(answer5);

           
            try
            {
                if (answer5.Contains("error"))
                {
                    throw new Exception();
                }
            }
            catch
            {
                sclab.Text = "ERROR, CHECK INPUT";
            }
            int countmes = 0;
            if (user.response.count >= 20)
            {
                countmes = 20;
            }
            else
            {
                countmes = user.response.count;
            }
            mes = "";
            listmes = "";
            int remem = 0;
            for (int itemsind = 0; itemsind <countmes; itemsind++)
            {
                if (user.response.items[itemsind].conversation.peer.type == "user")
                { }
                else
                { remem++;  }

            }
            int fri = 0;
            for (int itemsind = 0; itemsind < countmes; itemsind++)
            {
                if (user.response.items[itemsind].last_message.peer_id.ToString() != idbox.Text)
                {
                    if (user.response.items[itemsind].conversation.peer.type == "user")
                    {
                        //if (user.response.profiles[itemsind].friend_status.ToString() == "3")
                        //      {
                        if ((user.response.items[itemsind].last_message.@out.ToString() == "1"))
                        {
                            for (int i = 0; i < 300; i++)
                            {
                                if (user.response.items[itemsind].last_message.peer_id == user.response.profiles[i].id)
                                {
                                    fri = i;
                                    break;
                                }
                            }
                            if (user.response.profiles[fri].friend_status.ToString() == "3")
                            {
                               // ListViewItem lm1 = new ListViewItem("     " + user.response.items[itemsind].last_message.text.ToString() + "                \n   ");
                                //list.Items.Add(lm1);
                                Int64 dat = user.response.items[itemsind].last_message.date;
                                long epoch = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
                                Int64 itog = epoch - dat;
                                asd++;
                                if (itog > q)
                                {
                                    sch++;
                                    mes = mes + sch + ")@id" + user.response.items[itemsind].last_message.peer_id.ToString() + " ";
                                    for (int i = 0; i < 300; i++)
                                    {
                                        if (user.response.items[itemsind].last_message.peer_id == user.response.profiles[i].id)
                                        {
                                            fr = i;
                                            break;
                                        }
                                    }
                                    listmes ="\n"+ listmes  + user.response.profiles[fr].first_name+"  "+user.response.profiles[fr].last_name+ "\n\n ";
                                    ListViewItem lm1 = new ListViewItem(listmes);
                                    list.Items.Add(lm1);
                                    listmes = "";
                                }
                            }
                        }
                    }
                }
            }
            fr = 0;
            if (sch == 0)
            {
                mes = "Малоактивных пользователей нет!";
            }
            remem = 0;
            //}
           // sch = 0;
            string reqest51 = "https://api.vk.com/method/messages.getConversations?extended=1&fields=id,first_name,friend_status,&access_token=" + access_token + "&v=5.87";
            WebClient client51 = new WebClient();
            string answer51 = Encoding.UTF8.GetString(client51.DownloadData(reqest51));
            RootObject user1;
            user1 = JsonConvert.DeserializeObject<RootObject>(answer51);
            try
            {
                if (answer51.Contains("error"))
                {
                    throw new Exception();
                }
            }
            catch
            {
                sclab.Text = "ERROR, CHECK INPUT";
            }
            Random id = new Random();                                                                                                                //////id_bota//////
            int ids = id.Next(1000, 100000);
            if (sch > 0)
            {
                string reqest6 = "https://api.vk.com/method/messages.send?user_id=" + idbox.Text + "&random_id=" + ids + "&peer_id=" + idbox.Text + "&message= каких людей удалить? Напишите букву 'у',\n затем без пробелов номера людей, которых надо удалить, \nесли таковых нет то напишите 'нет' \n " + mes + "&payload=500&dont_parse_links=1&access_token=" + access_token + "&v=5.87";
                string answer6 = Encoding.UTF8.GetString(client51.DownloadData(reqest6));
                 
                try
                {
                    if (answer6.Contains("error"))
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    sclab.Text = "ERROR, CHECK INPUT";
                }
            }
            else
            {
                string reqest6 = "https://api.vk.com/method/messages.send?user_id=" + idbox.Text + "&random_id=" + ids + "&peer_id=" + idbox.Text + "&message=" + mes + "&payload=500&dont_parse_links=1&access_token=" + access_token + "&v=5.87";
                string answer6 = Encoding.UTF8.GetString(client51.DownloadData(reqest6));
                remem = 0;
                sch = 0;
                btclick.Enabled = true;
                btclick.Text = "применить";
                time1.Enabled = false;
                try
                {
                    if (answer6.Contains("error"))
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    sclab.Text = "ERROR, CHECK INPUT";
                }
            }
            sch = 0;
           
            
            time2.Enabled = true;
            time1.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            string reqest5 = "https://api.vk.com/method/messages.getConversations?extended=1&fields=id,first_name,freind_status&access_token=" + access_token + "&v=5.87";
            WebClient client5 = new WebClient();
            string answer5 = Encoding.UTF8.GetString(client5.DownloadData(reqest5));
          
            RootObject user;
            user = JsonConvert.DeserializeObject<RootObject>(answer5);
            try
            {
                if (answer5.Contains("error"))
                {
                    throw new Exception();
                }
            }
            catch
            {
                sclab.Text = "ERROR, CHECK INPUT";
            }
            //if (qwr == 0)
            string msg = ""; string mes2 = mes; // people delete
            
            for (int itemsind = 0; itemsind < 20; itemsind++)
            {
                if ((user.response.items[itemsind].last_message.peer_id.ToString() == idbox.Text) && (user.response.items[itemsind].last_message.text[0].ToString() == "у"))
                {
                    int countm = user.response.items[itemsind].last_message.text.Length;
                    string ms = user.response.items[itemsind].last_message.text.ToString();
                    for (int sc = 1; sc < countm; sc++)
                    {
                        msg = msg + ms[sc];
                    }
                }
                else if ((user.response.items[itemsind].last_message.peer_id.ToString() == idbox.Text) && (user.response.items[itemsind].last_message.text[0].ToString() == "н"))
                {
                    msg = ""; mes2 = ""; mes = "";
                    sch = 0;
                    Random id = new Random();                                                                                                                //////id_bota//////
                    int ids = id.Next(1000, 100000);
                    string reqest6 = "https://api.vk.com/method/messages.send?user_id=" + idbox.Text + "&random_id=" + ids + "&peer_id=" + idbox.Text + "&message= Хорошо! Обращайтесь!&payload=500&dont_parse_links=1&access_token=" + access_token + "&v=5.87";
                    string answer6 = Encoding.UTF8.GetString(client5.DownloadData(reqest6));
                    btclick.Enabled = true;
                    btclick.Text = "применить";
                    btclick.Cursor = Cursors.Default;
                    time2.Enabled = false;
                }
                if ((user.response.items[itemsind].last_message.peer_id.ToString() == idbox.Text) && (user.response.items[itemsind].last_message.text[0].ToString() == "у"))
                {
                    for (int i = 0; i < msg.Length; i++)
                    {
                        mes = mes2;
                        int pos2 = mes.IndexOf(msg[i] + ")");
                        mes = mes.Remove(pos2);
                        int len = mes.Length;
                        mes = mes2;
                        mes = mes.Remove(0, len);
                        int pos = mes.IndexOf(" ");
                        mes = mes.Remove(pos);
                        mes = mes.Remove(0, 5);
                        string reqest2 = "https://api.vk.com/method/friends.delete?user_id=" + mes + "&access_token=" + access_token + "&v=5.87";
                        WebClient client2 = new WebClient();
                        string answer2 = Encoding.UTF8.GetString(client2.DownloadData(reqest2));
                        try
                        {
                            if (answer2.Contains("error"))
                            {
                                throw new Exception();
                            }
                        }
                        catch
                        {
                            sclab.Text = "ERROR, CHECK INPUT";
                        }
                    }
                    Random id = new Random();
                    int ids = id.Next(1000, 100000);
                    string reqest6 = "https://api.vk.com/method/messages.send?user_id=" + idbox.Text + "&random_id=" + ids + "&peer_id=" + idbox.Text + "&message=Успешно!&payload=500&dont_parse_links=1&access_token=" + access_token + "&v=5.87";
                    string answer6 = Encoding.UTF8.GetString(client5.DownloadData(reqest6));
                    msg = ""; mes2 = ""; mes = "";
                    sch = 0;
                    btclick.Enabled = true;
                    time2.Enabled = false;
                }
            
            }
           
           // timer2.Enabled = false;
        }
        private void delete_friend_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.id = idbox.Text;

            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\id.txt");
            sw.WriteLine(idbox.Text);
            sw.Close();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
               
                DateTime time = new DateTime();
                string tm = boxt.Text;
                string tm2 = boxt.Text;
                int pos = tm.IndexOf(":");
                    tm = tm.Remove(pos);
                MessageBox.Show("ежедневно в "+tm2+" вам\nбудет присылаться статистика","сообщение!");
                if (time.Hour.ToString() == tm)
                {
                    
                    time1.Enabled = true;
                    time3.Enabled = false;
                   
                }
            }
            catch
            {
                sclab.Text = "ERROR, CHECK INPUT";
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                picrelax.Visible = true;
            }
            else
            {
                picrelax.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void boxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            but.Visible = false;
            btclick.Visible = true;

        }

        private void ttbox_KeyPress(object sender, KeyPressEventArgs e)
        {
char number = e.KeyChar;
if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
{
    e.Handled = true;
}
        }
    }
}
 