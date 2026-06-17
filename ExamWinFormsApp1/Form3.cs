using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3(string fio)
        {
            InitializeComponent();
            label1.Text = fio;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbhelper.Execyteqery("SELECT * FROM products");
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                dbhelper.Execyteqery($"UPDATE products SET name ='{textBox2.Text}', ed = '{textBox3.Text}', cost = {textBox4.Text} , post = '{textBox5.Text}', proiz = '{textBox6.Text}', kateg = '{textBox7.Text}', sale = {textBox8.Text}, kolvo = {textBox9.Text} , opis = '{textBox10.Text}', foto = '{textBox11.Text}' WHERE art = '{textBox1.Text}';");
                dataGridView1.DataSource = dbhelper.Execyteqery("SELECT * FROM products");
            }
            catch



            {
                MessageBox.Show("не верный артикул");


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbhelper.Execyteqery($"DELETE FROM products WHERE art = '{textBox13.Text}';");
                dataGridView1.DataSource = dbhelper.Execyteqery("SELECT * FROM products;");
            }
            catch
            {


            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = dbhelper.Execyteqery($"SELECT * FROM products WHERE LOWER (name) LIKE '%{textBox12.Text.ToLower()}%'");
            }


            catch
            {
                MessageBox.Show("такого значения нет");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbhelper.Execyteqery($"SELECT * FROM products WHERE LOWER (post) LIKE '%{comboBox2.Text.ToLower()}%'");
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dbhelper.Execyteqery($"INSERT INTO products (art, name, ed, cost, post, proiz, kateg, sale, kolvo, opis, foto) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{textBox8.Text}','{textBox9.Text}','{textBox10.Text}','{textBox11.Text}')");
                dataGridView1.DataSource = dbhelper.Execyteqery("SELECT * FROM products");
            }
            catch
            {
                MessageBox.Show("игорёК");



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
