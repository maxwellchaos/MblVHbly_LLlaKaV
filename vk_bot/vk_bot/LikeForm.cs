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
                string request = "https://api.vk.com/method/likes.add?type=post&item_id=" + textBox1.Text + "&owner_id=" + textBox2.Text + "&access_token=" + Form1.access_token + "&v=5.92 ";
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
                string request00 = "https://api.vk.com/method/friends.get?order=hints&offset=5&fields=photo_50&access_token=" + Form1.access_token + "&v=5.92";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request00));
                Friends Friend = JsonConvert.DeserializeObject<Friends>(answer);
            }
            catch
            {
                label6.Visible = true;
                label7.Visible = true;
                label7.Text = "Невозможно вывести запрос! Повторите попытку позже!";
            }
            try
            {
                label5.Text = Form1.idd;
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
            Clipboard.SetText("" + Form1.idd + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
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
            if (textBox2.Text != "" &&  textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            if (textBox2.Text == "" && textBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LikeHelp LP = new LikeHelp();
            LP.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label10.Text != "Нет")
            {
            string request5 = "https://api.vk.com/method/wall.get?owner_id=" + label10.Text + "&access_token=" + Form1.access_token + "&v=5.92";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request5));
            }
        }
    }
}
