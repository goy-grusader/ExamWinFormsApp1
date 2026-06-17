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
                var user = dbhelper.Execyteqery($"SELECT * FROM users WHERE login = '{textBox1.Text}' AND password = '{textBox2.Text}';");
                string fio = user.Rows[0]["fio"].ToString();
                string role = user.Rows[0]["role"].ToString();

                MessageBox.Show($"вы зашли как {role}");

                Form3 form3 = new Form3(fio);
                form3.Show();
                Hide();
            }
            catch 
            {
                MessageBox.Show("неверный логин или пароль");
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
