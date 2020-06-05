using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Вы ввели верный пароль!");
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
