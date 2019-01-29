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
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.autoAnswerButton = new System.Windows.Forms.Button();
            this.AutoMessageButton = new System.Windows.Forms.Button();
            this.Prostoknopka = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EvilLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.FirstNameLabel.Location = new System.Drawing.Point(71, 9);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(35, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "label1";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(71, 69);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(35, 13);
            this.SecondNameLabel.TabIndex = 3;
            this.SecondNameLabel.Text = "label2";
            // 
            // autoAnswerButton
            // 
            this.autoAnswerButton.Location = new System.Drawing.Point(252, 17);
            this.autoAnswerButton.Name = "autoAnswerButton";
            this.autoAnswerButton.Size = new System.Drawing.Size(187, 53);
            this.autoAnswerButton.TabIndex = 4;
            this.autoAnswerButton.Text = "Автоответ на комментарий";
            this.autoAnswerButton.UseVisualStyleBackColor = true;
            this.autoAnswerButton.Click += new System.EventHandler(this.autoAnswerButton_Click);
            // 
            // AutoMessageButton
            // 
            this.AutoMessageButton.Location = new System.Drawing.Point(252, 100);
            this.AutoMessageButton.Name = "AutoMessageButton";
            this.AutoMessageButton.Size = new System.Drawing.Size(187, 54);
            this.AutoMessageButton.TabIndex = 5;
            this.AutoMessageButton.Text = "Автоответ на сообщения";
            this.AutoMessageButton.UseVisualStyleBackColor = true;
            this.AutoMessageButton.Click += new System.EventHandler(this.AutoMessageButton_Click);
            // 
            // Prostoknopka
            // 
            this.Prostoknopka.Location = new System.Drawing.Point(252, 186);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Купите программу в группе \"Мыльный Бот\"";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(113, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "https://vk.com/mbllhuybot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EvilLabel);
            this.Controls.Add(this.Prostoknopka);
            this.Controls.Add(this.AutoMessageButton);
            this.Controls.Add(this.autoAnswerButton);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button AutoMessageButton;
        private System.Windows.Forms.Button Prostoknopka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label EvilLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

