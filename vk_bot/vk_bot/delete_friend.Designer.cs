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
            this.label1 = new System.Windows.Forms.Label();
            this.btclick = new System.Windows.Forms.Button();
            this.ttbox = new System.Windows.Forms.TextBox();
            this.timebox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idbox = new System.Windows.Forms.TextBox();
            this.sclab = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(441, 251);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(182, 113);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btclick
            // 
            this.btclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btclick.Location = new System.Drawing.Point(380, 78);
            this.btclick.Name = "btclick";
            this.btclick.Size = new System.Drawing.Size(167, 67);
            this.btclick.TabIndex = 2;
            this.btclick.Text = "применить";
            this.btclick.UseVisualStyleBackColor = true;
            this.btclick.Click += new System.EventHandler(this.button1_Click);
            // 
            // ttbox
            // 
            this.ttbox.Location = new System.Drawing.Point(229, 125);
            this.ttbox.Name = "ttbox";
            this.ttbox.Size = new System.Drawing.Size(100, 20);
            this.ttbox.TabIndex = 4;
            // 
            // timebox
            // 
            this.timebox.FormattingEnabled = true;
            this.timebox.Items.AddRange(new object[] {
            "часы",
            "дни",
            "секунды"});
            this.timebox.Location = new System.Drawing.Point(229, 78);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(121, 21);
            this.timebox.TabIndex = 5;
            this.timebox.Text = "время";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(229, 42);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 6;
            this.idbox.Text = "ваш id";
            // 
            // sclab
            // 
            this.sclab.AutoSize = true;
            this.sclab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sclab.Location = new System.Drawing.Point(210, 168);
            this.sclab.Name = "sclab";
            this.sclab.Size = new System.Drawing.Size(149, 25);
            this.sclab.TabIndex = 7;
            this.sclab.Text = "successfully!";
            this.sclab.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // delete_friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 376);
            this.Controls.Add(this.sclab);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.ttbox);
            this.Controls.Add(this.btclick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_friend";
            this.Text = "delete_friend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.delete_friend_FormClosing);
            this.Load += new System.EventHandler(this.delete_friend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btclick;
        private System.Windows.Forms.TextBox ttbox;
        private System.Windows.Forms.ComboBox timebox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label sclab;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}