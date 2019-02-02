﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.ObjectModel;
using System.IO;

using Newtonsoft.Json;

namespace vk_bot
{
    public partial class LastPostComment : Form
    {
        public string access_token;
        public string groupId;
        public string postId;
        public string userId;
        public string photoId;
        public int postTime;
        public int AlbumId;
        public Collection<string> grIds = new Collection<string>();
        string path = Application.StartupPath + "//comments.txt";

        public LastPostComment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                timer1.Enabled = true;
                button2.Enabled = true;

                DialogResult res;
                res = MessageBox.Show("Автокомментирование новых постов успешно начато", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != " ")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";

                DialogResult res;
                res = MessageBox.Show("Ваш комментарий успешно добавлен в список", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);

                DialogResult res;
                res = MessageBox.Show("Ваш комментарий успешно удалён из списка", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow;

            foreach (string groupId in grIds)
            {
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                string request = "https://api.vk.com/method/wall.get?owner_id=-" + groupId + "&count=2&extended=1&access_token=" + access_token + "&v=5.92";
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                System.Threading.Thread.Sleep(30);//Ждать 30 мс
                Application.DoEvents();
                System.Threading.Thread.Sleep(30);//Ждать 30 мс
                Application.DoEvents();
                System.Threading.Thread.Sleep(30);//Ждать 30 мс

                PostR po;
                po = JsonConvert.DeserializeObject<PostR>(answer);

                if (answer.Contains("error"))
                {
                    continue;
                }

                if (po.response.items.Length != 0)
                {
                    if (po.response.items[0].is_pinned == 0)
                    {
                        postTime = po.response.items[0].date;
                        postId = po.response.items[0].id.ToString();
                    }
                    else
                    {
                        postTime = po.response.items[1].date;
                        postId = po.response.items[1].id.ToString();
                    }
                }

                string request3 = "https://api.vk.com/method/wall.getComments?owner_id=-" + groupId + "&post_id=" + postId + "&count=50&sort=desc&access_token=" + access_token + "&v=5.92";
                string answer3 = Encoding.UTF8.GetString(client.DownloadData(request3));

                Comments co = new Comments();
                co = JsonConvert.DeserializeObject<Comments>(answer3);
                Application.DoEvents();
                origin = origin.AddSeconds(postTime);
                bool fi = false;

                try
                {
                    foreach (Comments.Response.Item cm in co.response.items)
                    {
                        if (cm.from_id.ToString() == userId)
                        {
                            fi = true;
                        }
                    }
                }
                catch (Exception)
                {

                }
                Application.DoEvents();
                if (now < origin.AddMinutes(2) && fi == false)
                {
                    try
                    {
                        if (PicRelatedMin.Visible == false)
                        {
                            string request2 = "https://api.vk.com/method/wall.createComment?owner_id=-" + groupId + "&post_id=" + postId + "&message=" + listBox1.Text + "&access_token=" + access_token + "&v=5.92";
                            string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));

                            if (answer.Contains("error"))
                            {
                                throw new Exception();
                            }
                        }
                        else
                        {
                            string request0 = "https://api.vk.com/method/photos.getUploadServer?album_id=" + AlbumId + "&access_token=" + access_token + "&v=5.92";
                            string answer0 = Encoding.UTF8.GetString(client.DownloadData(request0));

                            UploadServer us = new UploadServer();
                            us = JsonConvert.DeserializeObject<UploadServer>(answer0);

                            string answer20 = Encoding.UTF8.GetString(client.UploadFile(us.response.upload_url, openFileDialog1.FileName));

                            PostRequest pr = new PostRequest();
                            pr = JsonConvert.DeserializeObject<PostRequest>(answer20);

                            string server = pr.server.ToString();
                            string PhotosList = pr.photos_list;
                            string hash = pr.hash;

                            string request20 = "https://api.vk.com/method/photos.save?album_id=" + AlbumId + "&server=" + server + "&photos_list=" + PhotosList + "&hash=" + hash + "&access_token=" + access_token + "&v=5.92";
                            string answer30 = Encoding.UTF8.GetString(client.DownloadData(request20));

                            Photos ph = new Photos();
                            ph = JsonConvert.DeserializeObject<Photos>(answer30);

                            photoId = ph.response[0].id.ToString();


                            string request2 = "https://api.vk.com/method/wall.createComment?owner_id=-" + groupId + "&post_id=" + postId + "&message=" + listBox1.Text + "&attachments=photo" + userId + "_" + photoId + "&access_token=" + access_token + "&v=5.92";
                            string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));

                            if (answer.Contains("error"))
                            {
                                throw new Exception();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось отправить комментарий", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button2.Enabled = false;

                DialogResult res;
                res = MessageBox.Show("Автокомментирование новых постов успешно завершено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LastPostComment_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251)))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
        }

        private void LastPostComment_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines(path, listBox1.Items.OfType<string>(), Encoding.GetEncoding(1251));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            PicRelatedLabel.Text = openFileDialog1.SafeFileName;
            PicRelatedMin.Image = Image.FromFile(openFileDialog1.FileName);
            PicRelatedMin.Visible = true;
            button6.Visible = true;
            button6.Enabled = true;

            string request = "https://api.vk.com/method/photos.getAlbums?owner_id=" + userId + "&access_token=" + access_token + "&v=5.92";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            Albums al = new Albums();
            al = JsonConvert.DeserializeObject<Albums>(answer);

            bool exist = false;
            foreach (Albums.Response.Item itm in al.response.items)
            {
                if (itm.title == "vk_bot")
                {
                    AlbumId = itm.id;
                    exist = true;
                }
            }

            if (!exist)
            {
                string request2 = "https://api.vk.com/method/photos.createAlbum?title=vk_bot&privacy_view=nobody&access_token=" + access_token + "&v=5.92";
                string answer2 = Encoding.UTF8.GetString(client.DownloadData(request2));

                CreateAlbum cral = new CreateAlbum();
                cral = JsonConvert.DeserializeObject<CreateAlbum>(answer2);

                AlbumId = cral.response.id;
            }

            openFileDialog1.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PicRelatedLabel.Text = "Загрузите фотографию";
            PicRelatedMin.Visible = false;
            button6.Visible = false;
            button6.Enabled = false;
        }
    }
}
