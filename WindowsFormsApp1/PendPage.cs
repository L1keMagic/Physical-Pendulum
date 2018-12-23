using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApp1
{
    public partial class PendPage : Form
    {
        public Bitmap Ust = Resource1.ustanovka;
        public int x = 0, y = 0;
        Graphics g;
        public Pend pend1;
        double xs, ys, xf, yf, x0, y0;
        public int Nguess = 1;
        DateTime date;
        QuestionsPage qform = new QuestionsPage();
        bool Nyes = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            //Ncount.Text = Convert.ToString(N); // Проверка числа колебаний if you want check it then uncomment it
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopwatch = new DateTime();
            stopwatch = stopwatch.AddTicks(tick);
            Ptimer.Text = String.Format("{0:ss:ff}", stopwatch); // вывод времени

            double tmalaya = (stopwatch.Second * 1000 + stopwatch.Millisecond) / 1000; // сремя в секундах
            double angle = pend1.count();

            if (angle < 30 && angle > 24 && isN == true)
            {
                N++;
                isN = false;
            }

            if (angle > -30 && angle < -24)
                isN = true;
        }

        public int N = 0;
        public bool isN = false;

        private void Ncount_Click(object sender, EventArgs e)
        {

        }

        private void PendPage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Ust, new Rectangle(100, 0, 100, 100)); // отрисовывает установку
            // отрисовка маятника
            double angle = pend1.count(); // тут все норм не трогай
            double angleRadian = angle * Math.PI / 180;
            double buf = xs;
            // поворот фигуры xs ys координаты начала (верхухи) 
            float xss = (float)((xs - x0) * Math.Cos(angleRadian) - (ys - y0) * Math.Sin(angleRadian) + x0);
            float yss = (float)((buf - x0) * Math.Sin(angleRadian) + (ys - y0) * Math.Cos(angleRadian) + y0);

            float xfs = (float)((xf - x0) * Math.Cos(angleRadian) - (yf - y0) * Math.Sin(angleRadian) + x0);
            float yfs = (float)((xf - x0) * Math.Sin(angleRadian) + (yf - y0) * Math.Cos(angleRadian) + y0);

            g.DrawLine(new Pen(Brushes.Red, 5), new Point((int)xss, (int)yss), new Point((int)xfs, (int)yfs)); // отрисовка маятника
            g.DrawEllipse(new Pen(Brushes.Black, 5), (int)x0 - 2, (int)y0 - 2, 5, 5);
        }

        private void stop_button_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void CheckN_Click_1(object sender, EventArgs e)
        {
            for(int i =0; i< 200; i++)
            {
                if (Convert.ToString(Ntextbox.Text) == Convert.ToString(i))
                    Nyes = true;
                //break;
            }
            if (timer1.Enabled == true)
                MessageBox.Show("Сперва остановите таймер");
            if (string.IsNullOrEmpty(Ntextbox.Text))
                MessageBox.Show("Для чистоты эксперимента измерьте период мимимум 10 колебаний");
            if(!string.IsNullOrEmpty(Ntextbox.Text) && Nyes == true)
            {
                if (Convert.ToInt32(Ntextbox.Text) < 10 )
                    MessageBox.Show("Для чистоты эксперимента измерьте период мимимум 10 колебаний");

                if (timer1.Enabled == false && Convert.ToInt32(Ntextbox.Text) >= 10)
                {
                    int Nuser = Convert.ToInt32(Ntextbox.Text);
                    if (Nuser == N)
                    {
                        DataBank.L = Math.Round((pend1.l / 100) , 1);
                        DataBank.T = pend1.T /10;
                        DataBank.I = pend1.I / 10000;
                        MessageBox.Show("Все верно");
                        qform.Show();

                    }
                    else
                    {
                        Nguess++;
                        MessageBox.Show("Ответ неверный, пожалуйста повторите попытку");
                    }

                }
            }
        }

        private void start_button_Click_1(object sender, EventArgs e)
        {
            date = DateTime.Now;
            N = 0;
            timer1.Start();
        }



        public PendPage()
        {
            pend1 = new Pend();
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void PendPage_Load(object sender, EventArgs e)
        {
            xs = 150;
            ys = 40 - pend1.a;
            xf = 150;
            yf = 40 + pend1.l;
            x0 = 150;
            y0 = 40;
        }
    }
}
