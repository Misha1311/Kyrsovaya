using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Kyrsovaya
{
    public partial class input : Form
    {
        public input()
        {
            InitializeComponent();
        }

        public void inp()
        {
            try
            {
                //data newdata = new data();
                //newdata.NameShop = OupNameShop.Text.ToString();
                //newdata.Address = OupAddress.Text.ToString();
                //newdata.Code = Convert.ToInt32(OupCode.Text);
                //newdata.ProductName = OupProductName.Text.ToString();
                //newdata.Quantity = Convert.ToInt32(OupQuantity.Text);
                //newdata.Price = Convert.ToInt32(OupPrice.Text);
                //newdata.Sum = Convert.ToInt32(OupSum.Text);

                //dateb.AddDate(newdata);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start star = new start();
            star.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inp();

            OupNameShop.Text = "";
            OupAddress.Text = "";
            OupCode.Text = "";
            OupProductName.Text = "";
            OupQuantity.Text = "";
            OupPrice.Text = "";
            OupSum.Text = "";
        }
    }
}

