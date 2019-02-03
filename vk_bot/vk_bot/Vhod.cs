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
    public partial class Vhod : Form
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "z81k1y")
            {
                label1.Visible = false;
                Rassilka formas = new Rassilka();
                formas.Show();
            }
            else
            {
                label2.Visible = true;
            }


        }
      
    }  
    public class Response
        {
            public int count { get; set; }
            public List<int> items { get; set; }
        }

        public class SpisokUchasnikov
        {
            public Response response { get; set; }
        }
}
