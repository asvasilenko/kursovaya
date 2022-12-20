
namespace kursovaya
{
    partial class login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Войти = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Войти
            // 
            this.Войти.Location = new System.Drawing.Point(114, 170);
            this.Войти.Name = "Войти";
            this.Войти.Size = new System.Drawing.Size(75, 23);
            this.Войти.TabIndex = 2;
            this.Войти.Text = "Войти";
            this.Войти.UseVisualStyleBackColor = true;
            this.Войти.Click += new System.EventHandler(this.Войти_Click);
            // 
            // log_in
            // 
            this.log_in.AutoSize = true;
            this.log_in.Location = new System.Drawing.Point(42, 75);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(38, 13);
            this.log_in.TabIndex = 3;
            this.log_in.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(42, 118);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(45, 13);
            this.password.TabIndex = 4;
            this.password.Text = "Пароль";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 247);
            this.Controls.Add(this.password);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.Войти);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Войти;
        private System.Windows.Forms.Label log_in;
        private System.Windows.Forms.Label password;
    }
}