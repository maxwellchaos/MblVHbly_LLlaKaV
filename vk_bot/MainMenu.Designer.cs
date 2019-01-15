namespace vk_bot
{
    partial class MainMenu
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.autoAnswerButton = new System.Windows.Forms.Button();
            this.AutoMessageButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.webBrowser1.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=6410346&display=page&redirect_uri=https:" +
                    "//oauth.vk.com/blank.html&scope=friends,wall,groups&response_type=token&v=5.87&s" +
                    "tate=123456", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(39, 56);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(150, 140);
            this.AvatarPictureBox.TabIndex = 1;
            this.AvatarPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(33, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 31);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // autoAnswerButton
            // 
            this.autoAnswerButton.Location = new System.Drawing.Point(252, 56);
            this.autoAnswerButton.Name = "autoAnswerButton";
            this.autoAnswerButton.Size = new System.Drawing.Size(187, 53);
            this.autoAnswerButton.TabIndex = 4;
            this.autoAnswerButton.Text = "Автоответ на комментарий";
            this.autoAnswerButton.UseVisualStyleBackColor = true;
            this.autoAnswerButton.Click += new System.EventHandler(this.autoAnswerButton_Click);
            // 
            // AutoMessageButton
            // 
            this.AutoMessageButton.Location = new System.Drawing.Point(252, 142);
            this.AutoMessageButton.Name = "AutoMessageButton";
            this.AutoMessageButton.Size = new System.Drawing.Size(187, 54);
            this.AutoMessageButton.TabIndex = 5;
            this.AutoMessageButton.Text = "Автоответ на сообщения";
            this.AutoMessageButton.UseVisualStyleBackColor = true;
            this.AutoMessageButton.Click += new System.EventHandler(this.AutoMessageButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.Location = new System.Drawing.Point(534, 271);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(74, 31);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 385);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(781, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 420);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.AutoMessageButton);
            this.Controls.Add(this.autoAnswerButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.webBrowser1);
            this.Name = "MainMenu";
            this.Text = "VK Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button autoAnswerButton;
        private System.Windows.Forms.Button AutoMessageButton;
        private System.Windows.Forms.Label ErrorLabel;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}

