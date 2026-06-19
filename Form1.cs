namespace ExamWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = dbhelper.Execyteqery($"SELECT * FROM users WHERE login = '{textBox1.Text}' AND password = '{textBox2.Text}'");
                string fio = user.Rows[0]["fio"].ToString();
                string role = user.Rows[0]["role"].ToString();

                MessageBox.Show($"вы вошли как '{fio}'");
                if (role == "Администратор")
                { 
                Form3 form3 = new Form3(fio);
                form3.Show();
                Hide();
                
                
                }
                if (role == "Менеджер")
                { 
                Form5 form5 = new Form5(fio);
                form5.Show();
                Hide();
                
                
                }




            }
            catch { 
            
            
            
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("вы вошлт как гость ");
            Form2 form2 = new Form2();
            form2.Show();
          
            Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        
            
    }
}
