namespace WindowsFormsApp1
{
    partial class PendPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendPage));
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Ntextbox = new System.Windows.Forms.TextBox();
            this.CheckN = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.Ptimer = new System.Windows.Forms.Label();
            this.Ncount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(101, 283);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 47;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите N:";
            // 
            // Ntextbox
            // 
            this.Ntextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ntextbox.Location = new System.Drawing.Point(220, 331);
            this.Ntextbox.Name = "Ntextbox";
            this.Ntextbox.Size = new System.Drawing.Size(37, 20);
            this.Ntextbox.TabIndex = 11;
            // 
            // CheckN
            // 
            this.CheckN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckN.Location = new System.Drawing.Point(101, 366);
            this.CheckN.Name = "CheckN";
            this.CheckN.Size = new System.Drawing.Size(156, 35);
            this.CheckN.TabIndex = 12;
            this.CheckN.Text = "Проверить";
            this.CheckN.UseVisualStyleBackColor = true;
            this.CheckN.Click += new System.EventHandler(this.CheckN_Click_1);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(182, 283);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 8;
            this.stop_button.Text = "Стоп";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click_1);
            // 
            // Ptimer
            // 
            this.Ptimer.AutoSize = true;
            this.Ptimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ptimer.Location = new System.Drawing.Point(135, 220);
            this.Ptimer.Name = "Ptimer";
            this.Ptimer.Size = new System.Drawing.Size(102, 39);
            this.Ptimer.TabIndex = 9;
            this.Ptimer.Text = "00:00";
            // 
            // Ncount
            // 
            this.Ncount.AutoSize = true;
            this.Ncount.Location = new System.Drawing.Point(512, 34);
            this.Ncount.Name = "Ncount";
            this.Ncount.Size = new System.Drawing.Size(0, 13);
            this.Ncount.TabIndex = 13;
            this.Ncount.Click += new System.EventHandler(this.Ncount_Click);
            // 
            // PendPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.Ncount);
            this.Controls.Add(this.CheckN);
            this.Controls.Add(this.Ntextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ptimer);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PendPage";
            this.Text = "Маятник";
            this.Load += new System.EventHandler(this.PendPage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PendPage_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ntextbox;
        private System.Windows.Forms.Button CheckN;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label Ptimer;
        private System.Windows.Forms.Label Ncount;
    }
}