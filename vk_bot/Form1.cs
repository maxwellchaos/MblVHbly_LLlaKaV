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
        public static int index;

        public static string idd;
        public static string access_token;
        public string userId;
        public string userIdd;

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

                if (e.Url.ToString().Contains("user_id="))
                {

                    idd = e.Url.ToString();
                    int poss = idd.IndexOf("user_id=");
                    poss += "user_id=".Length;
                    idd = idd.Remove(0, poss);
                    poss = idd.IndexOf("&");
                    idd = idd.Remove(poss);
                    try
                    {

                        string request = "https://api.vk.com/method/users.get?user_ids=" + idd + "&fields=photo_100,bdate&access_token=" + access_token + "&v=5.92";
                        //string request2 = "https://api.vk.com/method/groups.get?user_id=56929156&fields=photo_100&extended=1&access_token=" + access_token + "&v=5.87";
                        WebClient client = new WebClient();
                        //string answer = client.DownloadString(request);
                        
                        string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                    
                        

                        

                        User user = JsonConvert.DeserializeObject<User>(answer);

                        string allgroups = "https://api.vk.com/method/groups.get?user_id=" + idd + "&fields=name&extended=1&access_token=" + access_token + "&v=5.92";

                        string answerallgroups = Encoding.UTF8.GetString(client.DownloadData(allgroups));
                        groups allusergroups = JsonConvert.DeserializeObject<groups>(answerallgroups);



                        webBrowser1.Visible = false;

                        AvatarPictureBox.Load(user.response[0].photo_100);
                        FirstNameLabel.Text = user.response[0].first_name;
                        SecondNameLabel.Text = user.response[0].last_name;

                        userIdd = user.response[0].id.ToString();
                    }
                    catch (Exception)
                    {
                        EvilLabel.Text = "Возникла ошибка !";
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.BringToFront();
                string request2 = "https://api.vk.com/method/messages.send?user_id=251202664&message=пАВуК&access_token=" + access_token + "&v=5.87";
                WebClient stepagavno2 = new WebClient();
                string papeimachi2 = Encoding.UTF8.GetString(stepagavno2.DownloadData(request2));
                if (papeimachi2.Contains("error"))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                EvilLabel.Text = "Возникла ошибка!";
            }
        }

        private void autoAnswerButton_Click(object sender, EventArgs e)
        {
            AutoAnswerForm frm = new AutoAnswerForm();
            label1.Visible = true;
            frm.access_token = access_token;
            frm.userId = userId;
            frm.mainform = this;
            frm.Show();
        }

        private void AutoMessageButton_Click(object sender, EventArgs e)
        {
            Pusia amfrm = new Pusia();
            amfrm.access_token = access_token;
            amfrm.ShowDialog();
        }



        private void sendphoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для начала введи в специальное поле ID получателя цифрами. Далее выбери кол-во фото и группу из списка. Осталось нажать на кнопку 'Прислать' ", "Ознакомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                label1.Visible = true;
                progressBar1.Visible = true;
                if (progressBar1.Value == 100)
                {
                    pictureBox1.Visible = true;
                }
                sendphotoForm spf = new sendphotoForm();
                spf.parentForm = this;
                spf.access_token = access_token;
                spf.ShowDialog();
            }
            catch (Exception)
            {
                label2.Text = "Возникла ошибка !";
            }
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            AButton frm = new AButton();
            frm.access_token = access_token;           
            frm.userIdd = userIdd;
            frm.ShowDialog();
        }



        private void delete_friends_Click(object sender, EventArgs e)
        {
            delete_friend dlf = new delete_friend();
            dlf.access_token = access_token;
            dlf.ShowDialog();
        }

        private void Prostoknopka_Click(object sender, EventArgs e)
        {
            Pusia frm = new Pusia();
            frm.access_token = access_token;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void Likebutton_Click(object sender, EventArgs e)
        {
            //LikeForm LF = new LikeForm();
            //LF.Show();
        }
    }
}

