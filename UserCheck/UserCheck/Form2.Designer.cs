namespace UserCheck
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            BtnCheckUse = new Button();
            BtnGoBack = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(397, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 229);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 35);
            textBox1.TabIndex = 1;
            // 
            // BtnCheckUse
            // 
            BtnCheckUse.BackColor = Color.FromArgb(45, 48, 56);
            BtnCheckUse.Cursor = Cursors.Hand;
            BtnCheckUse.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCheckUse.ForeColor = Color.White;
            BtnCheckUse.Location = new Point(12, 335);
            BtnCheckUse.Name = "BtnCheckUse";
            BtnCheckUse.Size = new Size(397, 40);
            BtnCheckUse.TabIndex = 2;
            BtnCheckUse.Text = "User check";
            BtnCheckUse.UseVisualStyleBackColor = false;
            BtnCheckUse.Click += BtnCheckUse_Click;
            // 
            // BtnGoBack
            // 
            BtnGoBack.BackColor = Color.FromArgb(45, 48, 56);
            BtnGoBack.Cursor = Cursors.Hand;
            BtnGoBack.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGoBack.ForeColor = Color.White;
            BtnGoBack.Location = new Point(12, 399);
            BtnGoBack.Name = "BtnGoBack";
            BtnGoBack.Size = new Size(397, 40);
            BtnGoBack.TabIndex = 3;
            BtnGoBack.Text = "Go user add page";
            BtnGoBack.UseVisualStyleBackColor = false;
            BtnGoBack.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 4;
            label1.Text = "Find user list";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 32);
            ClientSize = new Size(421, 481);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGoBack);
            Controls.Add(BtnCheckUse);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button BtnCheckUse;
        private Button BtnGoBack;
        private Label label1;
        private Label label2;
    }
}