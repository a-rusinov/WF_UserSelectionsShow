namespace WF_UserListSelections
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserSel = new System.Windows.Forms.Label();
            this.buttonUserSelShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Список №1, Выбор №1",
            "Список №1, Выбор №2",
            "Список №1, Выбор №3",
            "Список №1, Выбор №4",
            "Список №1, Выбор №5"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 84);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Список №2, Выбор №1",
            "Список №2, Выбор №2",
            "Список №2, Выбор №3",
            "Список №2, Выбор №4",
            "Список №2, Выбор №5"});
            this.listBox2.Location = new System.Drawing.Point(207, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(201, 84);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваш выбор:";
            // 
            // labelUserSel
            // 
            this.labelUserSel.AutoSize = true;
            this.labelUserSel.Location = new System.Drawing.Point(517, 0);
            this.labelUserSel.Name = "labelUserSel";
            this.labelUserSel.Size = new System.Drawing.Size(0, 20);
            this.labelUserSel.TabIndex = 3;
            // 
            // buttonUserSelShow
            // 
            this.buttonUserSelShow.Location = new System.Drawing.Point(0, 105);
            this.buttonUserSelShow.Name = "buttonUserSelShow";
            this.buttonUserSelShow.Size = new System.Drawing.Size(408, 28);
            this.buttonUserSelShow.TabIndex = 4;
            this.buttonUserSelShow.Text = "Отобразить Мой Выбор";
            this.buttonUserSelShow.UseVisualStyleBackColor = true;
            this.buttonUserSelShow.Click += new System.EventHandler(this.buttonUserSelShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 159);
            this.Controls.Add(this.buttonUserSelShow);
            this.Controls.Add(this.labelUserSel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserSel;
        private System.Windows.Forms.Button buttonUserSelShow;
    }
}

