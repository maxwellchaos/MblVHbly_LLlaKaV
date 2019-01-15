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
                label7.Text = "Не возможно поставить лайк на пост! Проверьте id или id поста! id поста самое последние в строке (3 цифры)";
            }
        }

        private void LikeForm_Load(object sender, EventArgs e)
        {
            try
            {
                label5.Text = Form1.idd;
            }
            catch (Exception a)
            {
                label6.Visible = true;
                label7.Visible = true;
                label7.Text = "Не возможно вывести id пользователя! Повторите попытку позже!";
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
                textBox3.Text = "";
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
            saveFileDialog.Filter = "Data.txt|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
