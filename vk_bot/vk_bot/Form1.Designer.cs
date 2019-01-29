namespace vk_bot
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();

            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.autoAnswerButton = new System.Windows.Forms.Button();
            this.AutoMessageButton = new System.Windows.Forms.Button();
            this.Prostoknopka = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EvilLabel = new System.Windows.Forms.Label();

            this.Pusia = new System.Windows.Forms.Button();
            this.sendphoto = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AButto = new System.Windows.Forms.Button();
            this.delete_friends = new System.Windows.Forms.Button();
            this.Likebutton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(822, 420);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=6410347&display=page&redirect_uri=https:" +
                    "//oauth.vk.com/blank.html&scope=messages&response_type=token&v=5.87&state=123456" +
                    "", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(38, 128);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(150, 140);
            this.AvatarPictureBox.TabIndex = 1;
            this.AvatarPictureBox.TabStop = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(100, 168);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(43, 16);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "нету";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameLabel.Location = new System.Drawing.Point(131, 189);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(43, 16);
            this.SecondNameLabel.TabIndex = 3;
            this.SecondNameLabel.Text = "нету";
            // 
            // autoAnswerButton
            // 
            this.autoAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoAnswerButton.Location = new System.Drawing.Point(233, 12);
            this.autoAnswerButton.Name = "autoAnswerButton";
            this.autoAnswerButton.Size = new System.Drawing.Size(187, 53);
            this.autoAnswerButton.TabIndex = 4;
            this.autoAnswerButton.Text = "Автокомментирование новых постов в группах";
            this.autoAnswerButton.UseVisualStyleBackColor = true;
            this.autoAnswerButton.Click += new System.EventHandler(this.autoAnswerButton_Click);
            // 
            // AutoMessageButton
            // 
            this.AutoMessageButton.Location = new System.Drawing.Point(38, 263);
            this.AutoMessageButton.Name = "AutoMessageButton";
            this.AutoMessageButton.Size = new System.Drawing.Size(75, 23);
            this.AutoMessageButton.TabIndex = 8;
            // 
            // Prostoknopka
            // 
            this.Prostoknopka.Location = new System.Drawing.Point(233, 230);
            this.Prostoknopka.Name = "Prostoknopka";
            this.Prostoknopka.Size = new System.Drawing.Size(187, 56);
            this.Prostoknopka.TabIndex = 6;
            this.Prostoknopka.Text = "Pusia";
            this.Prostoknopka.UseVisualStyleBackColor = true;
            this.Prostoknopka.Click += new System.EventHandler(this.Prostoknopka_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EvilLabel
            // 
            this.EvilLabel.AutoSize = true;
            this.EvilLabel.Location = new System.Drawing.Point(567, 294);
            this.EvilLabel.Name = "EvilLabel";
            this.EvilLabel.Size = new System.Drawing.Size(35, 13);
            this.EvilLabel.TabIndex = 7;
            this.EvilLabel.Text = "label1";
            // 
            // Pusia
            // 
            this.Pusia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pusia.Location = new System.Drawing.Point(233, 80);
            this.Pusia.Name = "Pusia";
            this.Pusia.Size = new System.Drawing.Size(187, 54);
            this.Pusia.TabIndex = 5;
            this.Pusia.Text = "Автоответ на сообщения";
            this.Pusia.UseVisualStyleBackColor = true;
            this.Pusia.Click += new System.EventHandler(this.AutoMessageButton_Click);
            // 
            // sendphoto
            // 
            this.sendphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendphoto.Location = new System.Drawing.Point(233, 151);
            this.sendphoto.Name = "sendphoto";
            this.sendphoto.Size = new System.Drawing.Size(187, 54);
            this.sendphoto.TabIndex = 6;
            this.sendphoto.Text = "Прислать любой мем/фото из поста заданного сообщества";
            this.sendphoto.UseVisualStyleBackColor = true;
            this.sendphoto.Click += new System.EventHandler(this.sendphoto_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(38, 367);
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(401, 41);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Загружаем ваши группы";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(472, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 9;
            // 
            // AButto
            // 
            this.AButto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AButto.Location = new System.Drawing.Point(465, 16);
            this.AButto.Name = "AButto";
            this.AButto.Size = new System.Drawing.Size(187, 54);
            this.AButto.TabIndex = 6;
            this.AButto.Text = "лайк постов";
            this.AButto.UseVisualStyleBackColor = true;
            this.AButto.Click += new System.EventHandler(this.AButton_Click);
            // 
            // delete_friends
            // 
            this.delete_friends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_friends.Location = new System.Drawing.Point(465, 80);
            this.delete_friends.Name = "delete_friends";
            this.delete_friends.Size = new System.Drawing.Size(187, 54);
            this.delete_friends.TabIndex = 6;
            this.delete_friends.Text = "Удаление друзей";
            this.delete_friends.UseVisualStyleBackColor = true;
            this.delete_friends.Click += new System.EventHandler(this.delete_friends_Click);
            // 
            // Likebutton
            // 
            this.Likebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Likebutton.Location = new System.Drawing.Point(465, 153);
            this.Likebutton.Name = "Likebutton";
            this.Likebutton.Size = new System.Drawing.Size(187, 53);
            this.Likebutton.TabIndex = 10;
            this.Likebutton.Text = "Лайканье постов на стене";
            this.ToolTip.SetToolTip(this.Likebutton, "Мой ДС: _HaKerHD93_#2979");
            this.Likebutton.UseVisualStyleBackColor = true;
            this.Likebutton.Click += new System.EventHandler(this.Likebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(445, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(12, 4);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(150, 150);
            this.AvatarPictureBox.TabIndex = 1;
            this.AvatarPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ваше имя :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ваша фамилия :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 420);
            this.Controls.Add(this.EvilLabel);
            this.Controls.Add(this.Prostoknopka);
            this.Controls.Add(this.AutoMessageButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Likebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sendphoto);
            this.Controls.Add(this.AButto);
            this.Controls.Add(this.delete_friends);
            this.Controls.Add(this.Pusia);

            this.Controls.Add(this.autoAnswerButton);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Button autoAnswerButton;

        private System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.Button Pusia;

        private System.Windows.Forms.Button sendphoto;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AButto;
        private System.Windows.Forms.Button delete_friends;
        private System.Windows.Forms.Button Likebutton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AutoMessageButton;
        private System.Windows.Forms.Button Prostoknopka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label EvilLabel;
    }
}

