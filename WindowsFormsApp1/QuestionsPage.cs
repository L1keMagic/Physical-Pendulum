using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuestionsPage : Form
    {
        double Treal, Lreal, Ireal; // Real value
        double Tuser, Luser, Iuser; // User's input value
        double Tpogr = 0.3, Lpogr = 0.3, Ipogr = 0.4; // Погрешности
        public QuestionsPage()
        {
            InitializeComponent();
        }

        public void QuestionsPage_Load(object sender, EventArgs e)
        {
            Treal = Convert.ToDouble(DataBank.T);
            Lreal = Convert.ToDouble(DataBank.L);
            Ireal = Convert.ToDouble(DataBank.I);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void OpenPend_Click(object sender, EventArgs e)
        {
            string Tstr = Tcheckf.Text;
            string Lstr = Lcheckf.Text;
            string Istr = Icheckf.Text;

            if (Tstr == "" || Lstr == "" || Istr == "" || 
                (No1.Checked == false && Yes1.Checked == false) || 
                (No2.Checked == false && Yes2.Checked == false) || 
                (No3.Checked == false && Yes3.Checked == false))
                    MessageBox.Show("Пожалуйста заполните все поля");
            else
            {

                if (Convert.ToString(Tcheckf.Text).Contains("."))
                    Tstr = Tcheckf.Text.Replace('.', ',');
                if (Convert.ToString(Lcheckf.Text).Contains("."))
                    Lstr = Lcheckf.Text.Replace('.', ',');
                if (Convert.ToString(Icheckf.Text).Contains("."))
                    Istr = Icheckf.Text.Replace('.', ',');

                Tuser = Convert.ToDouble(Tstr);
                Luser = Convert.ToDouble(Lstr);
                Iuser = Convert.ToDouble(Istr);

                if (Tuser > Treal - Tpogr && Tuser < Treal + Tpogr)
                {
                    check1.ForeColor = Color.Lime;
                    check1.Text = ("Верно");
                }

                else
                {
                    check1.ForeColor = Color.Red;
                    check1.Text = ("Неверно");
                }

                if (Luser > Lreal - Lpogr && Luser < Lreal + Lpogr)
                {
                    check2.ForeColor = Color.Lime;
                    check2.Text = ("Верно");
                }
                else
                {
                    check2.ForeColor = Color.Red;
                    check2.Text = ("Неверно");
                }

                if (Iuser > Ireal - Ipogr && Iuser < Ireal + Ipogr)
                {
                    check3.ForeColor = Color.Lime;
                    check3.Text = ("Верно");
                }
                else
                {
                    check3.ForeColor = Color.Red;
                    check3.Text = ("Неверно");
                }




                if (No1.Checked == true)
                {
                    check4.ForeColor = Color.Lime;
                    check4.Text = ("Верно");
                }
                else
                {
                    check4.ForeColor = Color.Red;
                    check4.Text = ("Неверно");
                }

                if (Yes2.Checked == true)
                {
                    check5.ForeColor = Color.Lime;
                    check5.Text = ("Верно");
                }
                else
                {
                    check5.Text = ("Неверно");
                    check5.ForeColor = Color.Red;
                }

                if (Yes3.Checked == true)
                {
                    check6.ForeColor = Color.Lime;
                    check6.Text = ("Верно");
                }
                else
                {
                    check6.ForeColor = Color.Red;
                    check6.Text = ("Неверно");
                }
            }
                
        }

        private void check5_Click(object sender, EventArgs e)
        {

        }
    }
}
