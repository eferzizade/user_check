using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCheck
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.Show(); // eyni Form1-i geri gətiririk
            this.Hide();     // Form2-ni gizlədirik
        }

        private void BtnCheckUse_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            bool found = false;

            // Form1-dəki eyni cədvəli yoxlayırıq
            foreach (DataRow row in Form1.usersTable.Rows)
            {
                if (row["Username"].ToString() == username)
                {
                    richTextBox1.Text = "Username: " + row["Username"].ToString() + "\n" +
                                        "Password: " + row["Password"].ToString() + "\n" +
                                        "Date: " + row["Date"].ToString();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                richTextBox1.Text = "User not found!";
            }
        }
    }
}
