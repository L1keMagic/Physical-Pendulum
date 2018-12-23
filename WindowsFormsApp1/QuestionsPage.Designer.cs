namespace WindowsFormsApp1
{
    partial class QuestionsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tcheckf = new System.Windows.Forms.TextBox();
            this.Lcheckf = new System.Windows.Forms.TextBox();
            this.Icheckf = new System.Windows.Forms.TextBox();
            this.No1 = new System.Windows.Forms.RadioButton();
            this.Yes1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.No2 = new System.Windows.Forms.RadioButton();
            this.Yes2 = new System.Windows.Forms.RadioButton();
            this.No3 = new System.Windows.Forms.RadioButton();
            this.Yes3 = new System.Windows.Forms.RadioButton();
            this.check1 = new System.Windows.Forms.Label();
            this.check2 = new System.Windows.Forms.Label();
            this.check3 = new System.Windows.Forms.Label();
            this.check4 = new System.Windows.Forms.Label();
            this.check5 = new System.Windows.Forms.Label();
            this.check6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OpenPend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период колебаний T, с:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина маятника L, м:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Момент инерции I, кг* м*м:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 84);
            this.label4.TabIndex = 3;
            this.label4.Text = "Зависит ли период колебаний стержня\r\nот его массы?\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 56);
            this.label5.TabIndex = 4;
            this.label5.Text = "Зависит ли период колебаний стержня\r\nот его длины?\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(44, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(471, 56);
            this.label6.TabIndex = 5;
            this.label6.Text = "Как изменится период колебаний стержня\r\n при увеличении его длины?";
            // 
            // Tcheckf
            // 
            this.Tcheckf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tcheckf.Location = new System.Drawing.Point(305, 54);
            this.Tcheckf.Name = "Tcheckf";
            this.Tcheckf.Size = new System.Drawing.Size(48, 31);
            this.Tcheckf.TabIndex = 8;
            // 
            // Lcheckf
            // 
            this.Lcheckf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lcheckf.Location = new System.Drawing.Point(305, 103);
            this.Lcheckf.Name = "Lcheckf";
            this.Lcheckf.Size = new System.Drawing.Size(48, 31);
            this.Lcheckf.TabIndex = 9;
            // 
            // Icheckf
            // 
            this.Icheckf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icheckf.Location = new System.Drawing.Point(364, 159);
            this.Icheckf.Name = "Icheckf";
            this.Icheckf.Size = new System.Drawing.Size(48, 31);
            this.Icheckf.TabIndex = 10;
            // 
            // No1
            // 
            this.No1.AutoSize = true;
            this.No1.Location = new System.Drawing.Point(92, 9);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(44, 17);
            this.No1.TabIndex = 1;
            this.No1.TabStop = true;
            this.No1.Text = "Нет";
            this.No1.UseVisualStyleBackColor = true;
            // 
            // Yes1
            // 
            this.Yes1.AutoSize = true;
            this.Yes1.Location = new System.Drawing.Point(13, 9);
            this.Yes1.Name = "Yes1";
            this.Yes1.Size = new System.Drawing.Size(40, 17);
            this.Yes1.TabIndex = 0;
            this.Yes1.TabStop = true;
            this.Yes1.Text = "Да";
            this.Yes1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // No2
            // 
            this.No2.AutoSize = true;
            this.No2.Location = new System.Drawing.Point(102, 12);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(44, 17);
            this.No2.TabIndex = 1;
            this.No2.TabStop = true;
            this.No2.Text = "Нет";
            this.No2.UseVisualStyleBackColor = true;
            // 
            // Yes2
            // 
            this.Yes2.AutoSize = true;
            this.Yes2.Location = new System.Drawing.Point(23, 12);
            this.Yes2.Name = "Yes2";
            this.Yes2.Size = new System.Drawing.Size(40, 17);
            this.Yes2.TabIndex = 0;
            this.Yes2.TabStop = true;
            this.Yes2.Text = "Да";
            this.Yes2.UseVisualStyleBackColor = true;
            // 
            // No3
            // 
            this.No3.AutoSize = true;
            this.No3.Location = new System.Drawing.Point(102, 9);
            this.No3.Name = "No3";
            this.No3.Size = new System.Drawing.Size(90, 17);
            this.No3.TabIndex = 1;
            this.No3.TabStop = true;
            this.No3.Text = "Уменьшится";
            this.No3.UseVisualStyleBackColor = true;
            // 
            // Yes3
            // 
            this.Yes3.AutoSize = true;
            this.Yes3.Location = new System.Drawing.Point(3, 9);
            this.Yes3.Name = "Yes3";
            this.Yes3.Size = new System.Drawing.Size(85, 17);
            this.Yes3.TabIndex = 0;
            this.Yes3.TabStop = true;
            this.Yes3.Text = "Увеличится";
            this.Yes3.UseVisualStyleBackColor = true;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check1.ForeColor = System.Drawing.Color.Lime;
            this.check1.Location = new System.Drawing.Point(367, 60);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(0, 25);
            this.check1.TabIndex = 14;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check2.ForeColor = System.Drawing.Color.Lime;
            this.check2.Location = new System.Drawing.Point(373, 109);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(0, 25);
            this.check2.TabIndex = 15;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check3.ForeColor = System.Drawing.Color.Lime;
            this.check3.Location = new System.Drawing.Point(439, 165);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(0, 25);
            this.check3.TabIndex = 16;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check4.ForeColor = System.Drawing.Color.Lime;
            this.check4.Location = new System.Drawing.Point(373, 253);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(0, 25);
            this.check4.TabIndex = 17;
            // 
            // check5
            // 
            this.check5.AutoSize = true;
            this.check5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check5.ForeColor = System.Drawing.Color.Lime;
            this.check5.Location = new System.Drawing.Point(373, 330);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(0, 25);
            this.check5.TabIndex = 18;
            this.check5.Click += new System.EventHandler(this.check5_Click);
            // 
            // check6
            // 
            this.check6.AutoSize = true;
            this.check6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check6.ForeColor = System.Drawing.Color.Lime;
            this.check6.Location = new System.Drawing.Point(570, 409);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(0, 25);
            this.check6.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.No1);
            this.panel1.Controls.Add(this.Yes1);
            this.panel1.Location = new System.Drawing.Point(217, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 32);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.No2);
            this.panel2.Controls.Add(this.Yes2);
            this.panel2.Location = new System.Drawing.Point(207, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 38);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.No3);
            this.panel3.Controls.Add(this.Yes3);
            this.panel3.Location = new System.Drawing.Point(355, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 34);
            this.panel3.TabIndex = 22;
            // 
            // OpenPend
            // 
            this.OpenPend.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenPend.Image = global::WindowsFormsApp1.Resource1.background;
            this.OpenPend.Location = new System.Drawing.Point(278, 440);
            this.OpenPend.Name = "OpenPend";
            this.OpenPend.Size = new System.Drawing.Size(256, 91);
            this.OpenPend.TabIndex = 7;
            this.OpenPend.Text = "Проверить";
            this.OpenPend.UseVisualStyleBackColor = true;
            this.OpenPend.Click += new System.EventHandler(this.OpenPend_Click);
            // 
            // QuestionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.check6);
            this.Controls.Add(this.check5);
            this.Controls.Add(this.check4);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.Icheckf);
            this.Controls.Add(this.Lcheckf);
            this.Controls.Add(this.Tcheckf);
            this.Controls.Add(this.OpenPend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuestionsPage";
            this.Text = "Маятник";
            this.Load += new System.EventHandler(this.QuestionsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenPend;
        private System.Windows.Forms.TextBox Tcheckf;
        private System.Windows.Forms.TextBox Lcheckf;
        private System.Windows.Forms.TextBox Icheckf;
        private System.Windows.Forms.RadioButton No1;
        private System.Windows.Forms.RadioButton Yes1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton No2;
        private System.Windows.Forms.RadioButton Yes2;
        private System.Windows.Forms.RadioButton No3;
        private System.Windows.Forms.RadioButton Yes3;
        private System.Windows.Forms.Label check1;
        private System.Windows.Forms.Label check2;
        private System.Windows.Forms.Label check3;
        private System.Windows.Forms.Label check4;
        private System.Windows.Forms.Label check5;
        private System.Windows.Forms.Label check6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}