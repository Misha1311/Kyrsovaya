using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovaya
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        double a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (data d in dateb.newData.ToArray())
            {
                a = Convert.ToInt32(delet.Text);
                if (a == d.Price)
                {
                    int index6 = dateb.newData.FindIndex(a => a.Price == d.Price);

                    dateb.newData.RemoveAt(index6);
                }
            }
            MessageBox.Show("Успешно удалено!");
        }
    }
}
