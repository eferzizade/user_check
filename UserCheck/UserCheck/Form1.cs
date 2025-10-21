using System.Data;

namespace UserCheck
{
    public partial class Form1 : Form
    {
        public static DataTable usersTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            if (usersTable.Columns.Count == 0)
            {
                usersTable.Columns.Add("Username");
                usersTable.Columns.Add("Password");
                usersTable.Columns.Add("Date");
            }
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = usersTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string user_name = textBox1.Text;
                string pass_word = textBox2.Text;
                string date_now = DateTime.Now.ToString();

                usersTable.Rows.Add(user_name, pass_word, date_now);

                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void BtnGoToCheckForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }
    }
}
