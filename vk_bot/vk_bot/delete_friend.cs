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
using System.Data;
using System.IO;
namespace vk_bot
{
    public partial class delete_friend : Form
    {
        public string access_token;
        double timestamp;
        int datr;
        int qwr;
        int tm = 0;
        int gh = 0;
        int sch = 0;
        string mes;
        int asd = 0;
        int num;
        int q; 
        String line;
        string numbermyid;
        public delete_friend()
        {
            InitializeComponent();
        }

       
        private void delete_friend_Load(object sender, EventArgs e)
        {
            idbox.Text = Properties.Settings.Default.id.ToString();
           

           
                //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(Application.StartupPath + "\\id.txt"); 

                //Read the first line of text
                line = sr.ReadLine();
                if (line == "1")
                { }
                else
                {
                    idbox.Text = line;
                }

                sr.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                        if (timebox.Text == "время")
                        {
                            string qwerty = ttbox.Text;


                           
                                datr = Convert.ToInt32(qwerty);

                           
                        }
                        else
                        {
                            sclab.Text = "successfuly!";
                            sclab.Visible = true;


                            if (timebox.Text == "часы")
                            {
                                string qwerty = ttbox.Text;
                               
                                    datr = Convert.ToInt32(qwerty);
                                    datr = datr / 60 / 60;
                                


                            }
                            if (timebox.Text == "секунды")
                            {
                                string qwerty = ttbox.Text;
                               
                                    datr = Convert.ToInt32(qwerty);

                                
                            }
                            if (timebox.Text == "дни")
                            {
                                string qwerty = ttbox.Text;
                               
                                    datr = Convert.ToInt32(qwerty);
                                    datr = datr / 60 / 60 / 24;
                               

                            }
                            if (timebox.Text == "время")
                            {
                                string qwerty = ttbox.Text;

                                datr = Convert.ToInt32(qwerty);
                                datr = 10800;


                            }
                        }
            }
            catch
            {
                sclab.Text = "ERROR!";
                gh++;
            }

                if (gh == 0)
                {
                    sclab.Text = "successfully!";
                    sclab.Visible = true;
                    q = datr;
                    timer1.Enabled = true;
                    timer3.Enabled = true;
                }
                gh = 0;
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            string reqest5 = "https://api.vk.com/method/messages.getConversations?extended=0&fields=id,first_name&access_token=" + access_token + "&v=5.87";
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
            for (int itemsind = 0; itemsind < 20; itemsind++)
            {

               
                if ((user.response.items[itemsind].last_message.@out.ToString() == "1") && (user.response.items[itemsind].last_message.peer_id.ToString() != idbox.Text))
                {
                    ListViewItem lm1 = new ListViewItem("     " + user.response.items[itemsind].last_message.text.ToString() + "                \n   ");
                    list.Items.Add(lm1);
                    Int64 dat = user.response.items[itemsind].last_message.date;
                    long epoch = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
                    Int64 itog = epoch - dat;
                    asd++;
                    if (itog > datr)
                    {
                        sch++;
                        mes = mes +sch+  ")@id"+ user.response.items[itemsind].last_message.peer_id.ToString() + " ";
                    }
                      
                }
            }

            string reqest51 = "https://api.vk.com/method/messages.getConversations?extended=0&fields=id,first_name&access_token=" + access_token + "&v=5.87";
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

            Random id = new Random();

                            int ids = id.Next(1000, 100000);
                            string reqest6 = "https://api.vk.com/method/messages.send?user_id=" + idbox.Text + "&random_id=" + ids + "&peer_id=" + idbox.Text + "&message= каких людей удалить? Напишите букву 'у',\n затем без пробелов номера людей, которых надо удалить \n " + mes + "&payload=500&dont_parse_links=1&access_token=" + access_token + "&v=5.87";
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
                            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string reqest5 = "https://api.vk.com/method/messages.getConversations?extended=0&fields=id,first_name&access_token=" + access_token + "&v=5.87";
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
                  
                  if ((user.response.items[itemsind].last_message.peer_id.ToString() == idbox.Text) && (user.response.items[itemsind].last_message.text[0].ToString() == "у"))
                  {
                      for (int i = 0; i < msg.Length ; i++)
                      {
                          mes = mes2; 
                          int pos2 = mes.IndexOf(msg[i]+")");
                          mes = mes.Remove(pos2);
                          int len = mes.Length;
                          mes = mes2;
                          mes = mes.Remove(0, len);
                          int pos = mes.IndexOf(" ");
                          mes = mes.Remove(pos);
                          mes = mes.Remove(0, 5);
                           string reqest2 = "https://api.vk.com/method/friends.delete?user_id="+mes+"&access_token=" + access_token + "&v=5.87";
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
                      break;
                  }
              }
            timer3.Enabled = true;
              
              
        }

        private void delete_friend_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.id = idbox.Text;
            if (line == "1")
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\id.txt"); 
                sw.WriteLine(idbox.Text);
                sw.Close();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime time = new DateTime();

            if (time.Hour.ToString() == "19")
            {
                timer1.Enabled = true;
                timer3.Enabled = false;
            }
        }
    }
}
      
    





