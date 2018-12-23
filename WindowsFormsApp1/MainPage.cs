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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenPend_Click(object sender, EventArgs e)
        {
            PendPage newform = new PendPage();
            newform.Show();
            this.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sdiscriptoin_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авторы данной программы:\nКарачев Артур https://vk.com/id141170156, \nИгорь Сахаров https://vk.com/igorman918\n" +
                "Научный руководитель: Демьянцева Наталья Григорьевна");
        }
    }
}
