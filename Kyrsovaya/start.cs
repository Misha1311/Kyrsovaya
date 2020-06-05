using System;
using System.Windows.Forms;

namespace Kyrsovaya
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }


        private void start_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (password.Text == "0000")
            {
                this.Hide();
                inputt inp = new inputt();
                inp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы ввели не верный пароль!");
            }
        }
    }
}
