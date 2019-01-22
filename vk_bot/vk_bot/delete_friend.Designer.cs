namespace vk_bot
{
    partial class delete_friend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_friend));
            this.list = new System.Windows.Forms.ListView();
            this.qwerty = new System.Windows.Forms.Label();
            this.btclick = new System.Windows.Forms.Button();
            this.ttbox = new System.Windows.Forms.TextBox();
            this.timebox = new System.Windows.Forms.ComboBox();
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.idbox = new System.Windows.Forms.TextBox();
            this.sclab = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Timer(this.components);
            this.time3 = new System.Windows.Forms.Timer(this.components);
            this.lb = new System.Windows.Forms.Label();
            this.picrelax = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.but = new System.Windows.Forms.Button();
            this.boxt = new System.Windows.Forms.ComboBox();
            this.dfg = new System.Windows.Forms.Label();
            this.ert = new System.Windows.Forms.Label();
            this.sos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picrelax)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.Location = new System.Drawing.Point(23, 218);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(270, 160);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Tile;
            // 
            // qwerty
            // 
            this.qwerty.AutoSize = true;
            this.qwerty.Location = new System.Drawing.Point(187, 5);
            this.qwerty.Name = "qwerty";
            this.qwerty.Size = new System.Drawing.Size(0, 13);
            this.qwerty.TabIndex = 1;
            // 
            // btclick
            // 
            this.btclick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btclick.Location = new System.Drawing.Point(419, 96);
            this.btclick.Name = "btclick";
            this.btclick.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btclick.Size = new System.Drawing.Size(179, 97);
            this.btclick.TabIndex = 2;
            this.btclick.Text = "отправить";
            this.btclick.UseVisualStyleBackColor = false;
            this.btclick.Click += new System.EventHandler(this.button1_Click);
            // 
            // ttbox
            // 
            this.ttbox.Location = new System.Drawing.Point(51, 192);
            this.ttbox.Multiline = true;
            this.ttbox.Name = "ttbox";
            this.ttbox.Size = new System.Drawing.Size(121, 20);
            this.ttbox.TabIndex = 4;
            this.ttbox.Text = "введите время";
            this.ttbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbox_KeyPress);
            // 
            // timebox
            // 
            this.timebox.FormattingEnabled = true;
            this.timebox.Items.AddRange(new object[] {
            "дни",
            "секунды"});
            this.timebox.Location = new System.Drawing.Point(51, 155);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(121, 21);
            this.timebox.TabIndex = 5;
            this.timebox.Text = "часы";
            // 
            // time1
            // 
            this.time1.Interval = 10000;
            this.time1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(229, 12);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 6;
            this.idbox.Text = "ваш id";
            // 
            // sclab
            // 
            this.sclab.AutoSize = true;
            this.sclab.BackColor = System.Drawing.Color.White;
            this.sclab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sclab.ForeColor = System.Drawing.Color.Red;
            this.sclab.Location = new System.Drawing.Point(490, 235);
            this.sclab.Name = "sclab";
            this.sclab.Size = new System.Drawing.Size(149, 25);
            this.sclab.TabIndex = 7;
            this.sclab.Text = "successfully!";
            this.sclab.Visible = false;
            // 
            // time2
            // 
            this.time2.Interval = 10000;
            this.time2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // time3
            // 
            this.time3.Interval = 10000;
            this.time3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.Location = new System.Drawing.Point(34, 78);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(313, 40);
            this.lb.TabIndex = 8;
            this.lb.Text = "поставте время, через которое\r\n человек считается малоактивным ";
            // 
            // picrelax
            // 
            this.picrelax.Image = global::vk_bot.Properties.Resources.море;
            this.picrelax.Location = new System.Drawing.Point(-200, -400);
            this.picrelax.Name = "picrelax";
            this.picrelax.Size = new System.Drawing.Size(732, 401);
            this.picrelax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrelax.TabIndex = 11;
            this.picrelax.TabStop = false;
            this.picrelax.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(485, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "режим ожидания";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // but
            // 
            this.but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but.Location = new System.Drawing.Point(709, 412);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(10, 10);
            this.but.TabIndex = 13;
            this.but.Text = "отправить прямо сейчас";
            this.but.UseVisualStyleBackColor = true;
            this.but.Visible = false;
            this.but.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // boxt
            // 
            this.boxt.FormattingEnabled = true;
            this.boxt.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.boxt.Location = new System.Drawing.Point(38, 3210);
            this.boxt.Name = "boxt";
            this.boxt.Size = new System.Drawing.Size(10, 21);
            this.boxt.TabIndex = 10;
            this.boxt.Text = "выберите время";
            this.boxt.Visible = false;
            this.boxt.SelectedIndexChanged += new System.EventHandler(this.boxt_SelectedIndexChanged);
            // 
            // dfg
            // 
            this.dfg.AutoSize = true;
            this.dfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dfg.Location = new System.Drawing.Point(34, 358);
            this.dfg.Name = "dfg";
            this.dfg.Size = new System.Drawing.Size(0, 20);
            this.dfg.TabIndex = 9;
            this.dfg.Visible = false;
            this.dfg.Click += new System.EventHandler(this.label3_Click);
            // 
            // ert
            // 
            this.ert.AutoSize = true;
            this.ert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ert.Location = new System.Drawing.Point(47, 12);
            this.ert.Name = "ert";
            this.ert.Size = new System.Drawing.Size(164, 20);
            this.ert.TabIndex = 14;
            this.ert.Text = "введите ваш id =>";
            // 
            // sos
            // 
            this.sos.AutoSize = true;
            this.sos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sos.Location = new System.Drawing.Point(368, 239);
            this.sos.Name = "sos";
            this.sos.Size = new System.Drawing.Size(102, 20);
            this.sos.TabIndex = 15;
            this.sos.Text = "состояние:";
            // 
            // delete_friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 434);
            this.Controls.Add(this.picrelax);
            this.Controls.Add(this.sos);
            this.Controls.Add(this.ert);
            this.Controls.Add(this.but);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.boxt);
            this.Controls.Add(this.dfg);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.sclab);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.ttbox);
            this.Controls.Add(this.btclick);
            this.Controls.Add(this.qwerty);
            this.Controls.Add(this.list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_friend";
            this.Text = "delete_friend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.delete_friend_FormClosing);
            this.Load += new System.EventHandler(this.delete_friend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picrelax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Label qwerty;
        private System.Windows.Forms.Button btclick;
        private System.Windows.Forms.TextBox ttbox;
        private System.Windows.Forms.ComboBox timebox;
        private System.Windows.Forms.Timer time1;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label sclab;
        private System.Windows.Forms.Timer time2;
        private System.Windows.Forms.Timer time3;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.PictureBox picrelax;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.ComboBox boxt;
        private System.Windows.Forms.Label dfg;
        private System.Windows.Forms.Label ert;
        private System.Windows.Forms.Label sos;
    }
}