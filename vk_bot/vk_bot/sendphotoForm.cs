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

    public partial class sendphotoForm : Form
    {
        public string access_token;
        public Form1 parentForm;
        groups allusergroups;


        public sendphotoForm()
        {
            InitializeComponent();
        }

        private void sendphotoForm_Load(object sender, EventArgs e)
        {

            WebClient client = new WebClient();



            string request2 = "https://api.vk.com/method/groups.get?user_id=" + Form1.idd + "&fields=name,photo_100&extended=1&access_token=" + access_token + "&v=5.87";
            string answer = Encoding.UTF8.GetString(client.DownloadData(request2));
            pictureBox1.Visible = false;
            listView1.Clear();



            //ListViewItem lvi = new ListViewItem("test1");
            //listView1.Items.Add(lvi);
            allusergroups = JsonConvert.DeserializeObject<groups>(answer);

            int valuegroups = 0;



            for (int itemIndex = 0; itemIndex < allusergroups.response.items.Length; itemIndex = itemIndex + 1)
            {
                try
                {
                    string[] names = new string[3];


                    








                    valuegroups = valuegroups + 1;

                    names[0] = allusergroups.response.items[itemIndex].name;
                    names[1] = allusergroups.response.items[itemIndex].id.ToString();
                    names[2] = allusergroups.response.items[itemIndex].photo_100;
                    pictureBox1.Load(allusergroups.response.items[itemIndex].photo_100);
                    Application.DoEvents();
                    imageList1.Images.Add(pictureBox1.Image);
                    parentForm.progressBar1.Maximum = allusergroups.response.items.Length;
                    parentForm.progressBar1.Value = valuegroups;








                    ListViewItem lvi = new ListViewItem(names, imageList1.Images.Count - 1);
                    listView1.Items.Add(lvi);

                    if (parentForm.progressBar1.Value == parentForm.progressBar1.Maximum)
                    {

                        parentForm.progressBar1.Visible = false;
                        parentForm.label1.Visible = false;

                    }
                }
                catch (Exception)
                {
                    label2.Text = "Возникла ошибка !";
                }
            }


        }

















        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                label1.Text = listView1.SelectedItems[0].SubItems[1].Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            WebClient client = new WebClient();

            int countphoto = (int)numericUpDown1.Value;
            listView1.Select();
            
            for (; countphoto > 0; )
            {


                for (int index = 0; index < listView1.SelectedItems.Count; index = index + 1)
                {
                    Random photorandom = new Random();
                    int id1 = photorandom.Next(20);
                    string stena = "https://api.vk.com/method/wall.get?owner_id=-" + allusergroups.response.items[listView1.SelectedIndices[0]].id + "&fields=attachments&access_token=" + access_token + "&v=5.87";

                    string wall = Encoding.UTF8.GetString(client.DownloadData(stena));
                    Wall stenka = JsonConvert.DeserializeObject<Wall>(wall);
                    int id = stenka.response.items[id1].attachments[0].photo.id;
                    int ownerid = stenka.response.items[id1].attachments[0].photo.owner_id;
                    if (countphoto > stenka.response.items[id1].attachments[0].photo.owner_id)
                    if (stenka.response.items != null)
                        if (stenka.response.items[id1].attachments != null)
                            if (stenka.response.items[id1].attachments[0] != null)
                                if (stenka.response.items[id1].attachments[0].photo != null)
                                {
                                    
                                    string otpravka = "https://api.vk.com/method/messages.send?user_id=" + Form1.idd + "&attachment=photo" + ownerid + "_" + id + "&access_token=" + access_token + "&v=5.87";
                                    string mess = Encoding.UTF8.GetString(client.DownloadData(otpravka));
                                    Message message = JsonConvert.DeserializeObject<Message>(mess);
                                    System.Threading.Thread.Sleep(700);
                                    countphoto = countphoto - 1;
                                }

                }
            }
    }

    }
}