namespace WindowsFormsApp1
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Stitle = new System.Windows.Forms.Label();
            this.Sdiscriptoin = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.OpenPend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stitle
            // 
            this.Stitle.AutoSize = true;
            this.Stitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stitle.Location = new System.Drawing.Point(201, 9);
            this.Stitle.Name = "Stitle";
            this.Stitle.Size = new System.Drawing.Size(672, 84);
            this.Stitle.TabIndex = 1;
            this.Stitle.Text = "Экспериментальная задача на тему:\r\nВращательное движение твердого тела";
            this.Stitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sdiscriptoin
            // 
            this.Sdiscriptoin.AutoSize = true;
            this.Sdiscriptoin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sdiscriptoin.Location = new System.Drawing.Point(25, 117);
            this.Sdiscriptoin.Name = "Sdiscriptoin";
            this.Sdiscriptoin.Size = new System.Drawing.Size(947, 240);
            this.Sdiscriptoin.TabIndex = 2;
            this.Sdiscriptoin.Text = resources.GetString("Sdiscriptoin.Text");
            this.Sdiscriptoin.Click += new System.EventHandler(this.Sdiscriptoin_Click);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(1037, 639);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(35, 13);
            this.about.TabIndex = 3;
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // OpenPend
            // 
            this.OpenPend.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenPend.Image = global::WindowsFormsApp1.Resource1.background;
            this.OpenPend.Location = new System.Drawing.Point(325, 406);
            this.OpenPend.Name = "OpenPend";
            this.OpenPend.Size = new System.Drawing.Size(345, 135);
            this.OpenPend.TabIndex = 0;
            this.OpenPend.Text = "Начать";
            this.OpenPend.UseVisualStyleBackColor = true;
            this.OpenPend.Click += new System.EventHandler(this.OpenPend_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1080, 657);
            this.Controls.Add(this.about);
            this.Controls.Add(this.Sdiscriptoin);
            this.Controls.Add(this.Stitle);
            this.Controls.Add(this.OpenPend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "Маятник";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenPend;
        private System.Windows.Forms.Label Stitle;
        private System.Windows.Forms.Label Sdiscriptoin;
        private System.Windows.Forms.Label about;
    }
}

