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
   
    public partial class Pusia_ : Form
    {
        public static string access_token;
        string id;
        string[] answer = new string[7];
        string[] answer2 = new string[8];
        public Pusia_()
        {
            answer[0] = "Слушаю музыку, а ты?";
            answer[1] = "Играю в Osu, а ты?";
            answer[2] = "С тобой переписываюсь, а ты?";
            answer[3] = "Снимаю штаны и бегаю, а ты?";
            answer[4] = "Смотрю аниме, а ты?";
            answer[5] = "Смотрю Гиги За шаги 10 часов, а ты?";
            answer[6] = "Читаю, а ты?";

            answer2[1] = "Прекрасно, а у тебя?";
            answer2[2] = "Шик, а у тебя?";
            answer2[3] = "Bien, et toi?";
            answer2[4] = "Средненько, а у тебя?";
            answer2[5] = "Как-то не очень, а у тебя?";
            answer2[6] = "Mal, et toi?";
            answer2[7] = "Ужасно прооостооо~";
            
            
            InitializeComponent();
        }

        private void Pusia_Load(object sender, EventArgs e)
        {

            
            string request = "https://api.vk.com/method/messages.getConversations?filter=unread&access_token=" + access_token +"&v=5.87";
            WebClient stepagavno= new WebClient();
            string papeimachi = Encoding.UTF8.GetString(stepagavno.DownloadData(request));
            UnreadMessages msg = JsonConvert.DeserializeObject<UnreadMessages>(papeimachi);
            //foreach(UnreadMessages.Item itm in msg.response.items )
           // {
              //  listBox1.Items.Add(itm.last_message.text);
                //string request2 = "https://api.vk.com/method/messages.send?user_id="+ itm.last_message.from_id+"&message=О-ОтЛичНо&access_token=" + access_token + "&v=5.87";
                //WebClient cl = new WebClient();
                //string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
            //}
            

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //timer1.Enabled = false;
            string request = "https://api.vk.com/method/messages.getConversations?filter=unread&access_token=" + access_token + "&v=5.87";
            WebClient stepagavno = new WebClient();
            string papeimachi = Encoding.UTF8.GetString(stepagavno.DownloadData(request));
            UnreadMessages msg = JsonConvert.DeserializeObject<UnreadMessages>(papeimachi);

            foreach (UnreadMessages.Item itm in msg.response.items)
            {
                try
                {


                    if (itm.last_message.text.ToLower().Contains(textBox1.Text.ToLower()))
                    {

                        string name = "https://api.vk.com/method/users.get?user_id=" + itm.last_message.from_id + "&access_token=" + access_token + "&v=5.87";
                        WebClient lc = new WebClient();
                        string namesel = Encoding.UTF8.GetString(lc.DownloadData(name));
                        Namee named = JsonConvert.DeserializeObject<Namee>(namesel);
                        string text = textBox3.Text.Replace("@", named.response[0].first_name);
                        string request2 = "https://api.vk.com/method/messages.send?user_id=" + itm.last_message.from_id + "&message=" + text
 +"&access_token=" + access_token + "&v=5.87";
                        WebClient cl = new WebClient();
                        string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
                        if (mess.Contains("error"))
                        {
                            throw new Exception();
                        }
                    }
                    if (itm.last_message.text.ToLower().Contains(textBox2.Text.ToLower()))
                    {
                        Random ccc = new Random();
                        string request2 = "https://api.vk.com/method/messages.send?user_id=" + itm.last_message.from_id + "&message=" + answer2[ccc.Next(9)] + "&access_token=" + access_token + "&v=5.87";
                        WebClient cl = new WebClient();
                        string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
                        if (mess.Contains("error"))
                        {
                            throw new Exception();
                        }
                    }

                    if (itm.last_message.text.ToLower().Contains(textBox5.Text.ToLower()))
                    {
                        string request2 = "https://api.vk.com/method/messages.send?user_id=" + itm.last_message.from_id + "&message=" + textBox6.Text + "&access_token=" + access_token + "&v=5.87";
                        WebClient cl = new WebClient();
                        string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
                        if (mess.Contains("error"))
                        {
                            throw new Exception();
                        }
                    }
                    if (itm.last_message.text.ToLower().Contains(textBox7.Text.ToLower()))
                    {
                        Random aaa = new Random();


                        string request2 = "https://api.vk.com/method/messages.send?user_id=" + itm.last_message.from_id + "&message=" + answer[aaa.Next(6)] + "&access_token=" + access_token + "&v=5.87";
                        WebClient cl = new WebClient();
                        string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
                        if (mess.Contains("error"))
                        {
                            throw new Exception();
                        }
                    }
                    if (itm.last_message.text.ToLower().Contains(textBox9.Text.ToLower()))
                    {
                        string request2 = "https://api.vk.com/method/messages.send?user_id=" + itm.last_message.from_id + "&message=" + textBox10.Text + "&access_token=" + access_token + "&v=5.87";
                        WebClient cl = new WebClient();
                        string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
                        if (mess.Contains("error"))
                        {
                            throw new Exception();
                        }
                    }
                    if (itm.last_message.text.ToLower().Contains(textBox11.Text.ToLower()))
                    {
                        string request2 = "https://api.vk.com/method/messages.send?user_id=" + itm.last_message.from_id + "&message=" + textBox12.Text + "&access_token=" + access_token + "&v=5.87";
                        WebClient cl = new WebClient();
                        string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
                        if (mess.Contains("error"))
                        {
                            throw new Exception();
                        }



                    }

                    listBox1.Items.Add(itm.last_message.text);
                    //string request2 = "https://api.vk.com/method/messages.send?user_id=" + itm.last_message.from_id + "&message=О-ОтЛичНо&access_token=" + access_token + "&v=5.87";
                    //WebClient cl = new WebClient();
                    //string mess = Encoding.UTF8.GetString(cl.DownloadData(request2));
                    //timer1.Enabled = true;

                }
                catch (Exception)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Возникла ошибка!";
                    
                }
            }
        }
        public class Response
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
        }

        public class Namee
        {
            public List<Response> response { get; set; }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vhod forma = new Vhod();
            forma.Show();
        }
    }
}
