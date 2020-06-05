using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Data;


namespace Kyrsovaya
{
    [Serializable]
    public partial class inputt : Form
    {
        data da = new data();

        public inputt()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        public void inp()
        {
            try
            {
                data newdata = new data();
                newdata.NameShop = OupNameShop.Text.ToString();
                newdata.Address = OupAddress.Text.ToString();
                newdata.Code = Convert.ToDouble(OupCode.Text);
                newdata.ProductName = OupProductName.Text.ToString();
                newdata.Quantity = Convert.ToDouble(OupQuantity.Text);
                newdata.Price = Convert.ToDouble(OupPrice.Text);
                newdata.Sum = Convert.ToDouble(OupSum.Text);

                dateb.AddDate(newdata);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void outp()
        {
            var table = new DataTable("Магазин");

            var name = new DataColumn("Название Магазина");
            var address = new DataColumn("Адрес");
            var code = new DataColumn("артикул");
            var nameshop = new DataColumn("Название продукта");
            var quantity = new DataColumn("Количество");
            var price = new DataColumn("Цена за еденицу");
            var sum = new DataColumn("Сумма");

            table.Columns.Add(name);
            table.Columns.Add(address);
            table.Columns.Add(code);
            table.Columns.Add(nameshop);
            table.Columns.Add(quantity);
            table.Columns.Add(price);
            table.Columns.Add(sum);

            foreach (data d in dateb.newData)
            {
                DataRow row = table.NewRow();
                row["Название Магазина"] = d.NameShop.ToString();
                row["Адрес"] = d.Address.ToString();
                row["артикул"] = d.Code;
                row["Название продукта"] = d.ProductName.ToString();
                row["Количество"] = d.Quantity;
                row["Цена за еденицу"] = d.Price;
                row["Сумма"] = d.Sum;

                table.Rows.Add(row);
            }
            dataGridView1.DataSource = table;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Hide();
            inp();

            outp();

            OupNameShop.Text = "";
            OupAddress.Text = "";
            OupCode.Text = "";
            OupProductName.Text = "";
            OupQuantity.Text = "";
            OupPrice.Text = "";
            OupSum.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            start star = new start();
            star.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
            dateb.newData.RemoveAt(ind);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog1.FileName;
            File.WriteAllText(path, da.Serialize());
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            da.Deserialize(File.ReadAllText(path));
            outp();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            sumQuantity();
            sumPrice();
            lowsum();
            richTextBox1.Show();
        }

        void sumQuantity()
        {
            double sum = 0;
            foreach (data d in dateb.newData)
            {
                if (Search.Text == d.ProductName)
                {
                    if (d.ProductName == d.ProductName)
                    {
                        sum += d.Quantity;

                        richTextBox1.Text += $"Количество заданого товара : {sum}";
                    }
                }
            }
        }

        void sumPrice()
        {
            double sum = 0;
            foreach (data d in dateb.newData)
            {
                if (Search.Text == d.ProductName)
                {
                    if (d.ProductName == d.ProductName)
                    {
                        sum += d.Price;

                        richTextBox1.Text += $"\nСумарная стоимость товаров : {sum}";
                    }
                }
            }
        }
        void lowsum()
        {
            foreach (data d in dateb.newData)
            {
                if (Search.Text == d.ProductName)
                {
                    if (d.ProductName == d.ProductName)
                    {
                        d.Min = dateb.newData.Min(x => x.Quantity);

                        int index = dateb.newData.FindIndex(a => a.Min == d.Min);
          
                        richTextBox1.Text += $"\nСамый дешёвый товар по адресу : {dateb.newData.ElementAt(index).Address}";
                    }
                }
            }
        }

        private void inputt_Load(object sender, EventArgs e)
        {
            outp();
            richTextBox1.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.ShowDialog();
        }

        private void удалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.ShowDialog();
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}