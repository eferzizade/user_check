namespace UserCheck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            registration_date = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnAddUser = new Button();
            BtnGoToCheckForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(40, 44, 52);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { username, password, registration_date });
            dataGridView1.GridColor = Color.FromArgb(55, 58, 65);
            dataGridView1.Location = new Point(13, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(397, 122);
            dataGridView1.TabIndex = 0;
            // 
            // username
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            username.DefaultCellStyle = dataGridViewCellStyle1;
            username.HeaderText = "Username";
            username.Name = "username";
            username.Width = 118;
            // 
            // password
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            password.DefaultCellStyle = dataGridViewCellStyle2;
            password.HeaderText = "Password";
            password.Name = "password";
            password.Width = 118;
            // 
            // registration_date
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            registration_date.DefaultCellStyle = dataGridViewCellStyle3;
            registration_date.HeaderText = "Registration date";
            registration_date.Name = "registration_date";
            registration_date.Width = 118;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(398, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 3;
            label1.Text = "User add";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 243);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // BtnAddUser
            // 
            BtnAddUser.BackColor = Color.FromArgb(45, 48, 56);
            BtnAddUser.BackgroundImageLayout = ImageLayout.None;
            BtnAddUser.Cursor = Cursors.Hand;
            BtnAddUser.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddUser.ForeColor = Color.White;
            BtnAddUser.Location = new Point(12, 356);
            BtnAddUser.Name = "BtnAddUser";
            BtnAddUser.Size = new Size(398, 41);
            BtnAddUser.TabIndex = 6;
            BtnAddUser.Text = "User add";
            BtnAddUser.UseVisualStyleBackColor = false;
            BtnAddUser.Click += button1_Click;
            // 
            // BtnGoToCheckForm
            // 
            BtnGoToCheckForm.BackColor = Color.FromArgb(45, 48, 56);
            BtnGoToCheckForm.Cursor = Cursors.Hand;
            BtnGoToCheckForm.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGoToCheckForm.ForeColor = Color.White;
            BtnGoToCheckForm.Location = new Point(13, 414);
            BtnGoToCheckForm.Name = "BtnGoToCheckForm";
            BtnGoToCheckForm.Size = new Size(397, 37);
            BtnGoToCheckForm.TabIndex = 7;
            BtnGoToCheckForm.Text = "Go User check page";
            BtnGoToCheckForm.UseVisualStyleBackColor = false;
            BtnGoToCheckForm.Click += BtnGoToCheckForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 32);
            ClientSize = new Size(421, 481);
            Controls.Add(BtnGoToCheckForm);
            Controls.Add(BtnAddUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "User add";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn registration_date;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnAddUser;
        private Button BtnGoToCheckForm;
    }
}
