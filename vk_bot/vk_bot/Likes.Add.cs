using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vk_bot
{
    public partial class Likes : Form
    {
        public Likes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string request = "https://api.vk.com/method/likes.add?owner_id=" + textBox1.Text + "&type=post&item_id=" + textBox3.Text + "&access_token=" + Form1.access_token + "&v=5.87";
            }
            catch (Exception ex)
            {
                label7.Text = "Error!" + ex.Message;
            }
        }

        private void Likes_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.idd;
        }
    }
}
