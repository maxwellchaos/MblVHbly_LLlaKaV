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
// https://api.vk.com/method/wall.get?count=100&access_token=" + Form1.access_token + "&v=5.92
namespace vk_bot
{
    public partial class LikeForm : Form
    {
        public LikeForm()
        {
            InitializeComponent();
        }
        string id;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string request = "https://api.vk.com/method/likes.add?type=post&item_id=" + comboBox2.Text + "&owner_id=" + textBox2.Text + "&access_token=" + Form1.access_token + "&v=5.92 ";
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                textBox3.Text = answer;
            }
            catch (Exception)
            {
                label6.Visible = true;
                label7.Visible = true;
                label7.Text = "Невозможно поставить лайк на пост! Проверьте id или id поста! id поста самое последние в строке (3 цифры)";
            }
        }

        private void LikeForm_Load(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string request00 = "https://api.vk.com/method/friends.get?order=hints&offset=5&fields=photo_50&access_token=" + Form1.access_token + "&v=5.92";
                string answer = Encoding.UTF8.GetString(client.DownloadData(request00));
                Friends Friend = JsonConvert.DeserializeObject<Friends>(answer);
                for (int itemIndex = 0; itemIndex < Friend.response.count; itemIndex++)
                {
                    comboBox1.Items.Add(Friend.response.items[itemIndex].first_name + " " + Friend.response.items[itemIndex].last_name + " " + "id:" + " " + Friend.response.items[itemIndex].id);
                }
            }
            catch
            {
                label6.Visible = true;
                label7.Visible = true;
                label7.Text = "Невозможно вывести запрос! Повторите попытку позже!";
            }
            try
            {
                label5.Text = Form1.userId;
            }
            catch (Exception a)
            {
                label6.Visible = true;
                label7.Visible = true;
                label7.Text = "Невозможно вывести id пользователя! Повторите попытку позже!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("" + Form1.userId + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                textBox3.Text = "";
                label10.Text = "";
                button1.Enabled = false;
            }
            catch
            {
                label6.Visible = true;
                label7.Visible = true;
                label7.Text = "Невозможно очистить строки!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Data.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains("id: "))
            {
                id = comboBox1.Text;
                int pos = id.IndexOf("id: ");
                pos += "id: ".Length;
                id = id.Remove(0, pos);
                label10.Text = id;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("" + label10.Text + "");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox2.Text != "" &&  comboBox2.Text != "")
            {
                button1.Enabled = true;
            }
            string request123 = "https://api.vk.com/method/wall.get?owner_id=" + textBox2.Text + "&access_token=" + Form1.access_token + "&v=5.92 ";
            WebClient wct = new WebClient();
            string answer123 = Encoding.UTF8.GetString(wct.DownloadData(request123));
            like lis = JsonConvert.DeserializeObject<like>(answer123);

            postt gr;
            gr = JsonConvert.DeserializeObject<postt>(answer123);

            string request321 = "https://api.vk.com/method/wall.get?owner_id=" + textBox2.Text + "&access_token=" + Form1.access_token + "&v=5.92";
            WebClient wc = new WebClient();
            string answer312 = Encoding.UTF8.GetString(wc.DownloadData(request321));
            like lik = JsonConvert.DeserializeObject<like>(answer312);

            for (int itemIndex = 0; itemIndex < gr.response.items.Length; itemIndex = itemIndex + 1)
            {
                    string[] names = new string[3];
                    names[0] = gr.response.items[itemIndex].text;
                    names[2] = gr.response.items[itemIndex].id.ToString();
                comboBox2.Items.Add(gr.response.items[itemIndex].id);
                label14.Text = gr.response.items[itemIndex].text;
            }
        }
    }
}
