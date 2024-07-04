namespace TrainTicketsWithDB
{
    partial class SignUpForm
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
            label1 = new Label();
            reg_Button = new Button();
            textBox_password = new TextBox();
            textBox_login = new TextBox();
            textBox_password2 = new TextBox();
            textBox_secureCode = new TextBox();
            textBox_name = new TextBox();
            textBox_surname = new TextBox();
            textBox_father = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(393, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 35);
            label1.TabIndex = 11;
            label1.Text = "РЕЄСТРАЦІЯ";
            // 
            // reg_Button
            // 
            reg_Button.FlatStyle = FlatStyle.Flat;
            reg_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            reg_Button.Location = new Point(259, 208);
            reg_Button.Name = "reg_Button";
            reg_Button.Size = new Size(413, 33);
            reg_Button.TabIndex = 8;
            reg_Button.Text = "Зареєструвати";
            reg_Button.UseVisualStyleBackColor = true;
            reg_Button.Click += reg_Button_Click;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.Location = new Point(53, 130);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.PlaceholderText = "Пароль...";
            textBox_password.Size = new Size(413, 33);
            textBox_password.TabIndex = 7;
            textBox_password.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_login.Location = new Point(53, 88);
            textBox_login.Name = "textBox_login";
            textBox_login.PlaceholderText = "Ім'я користувача";
            textBox_login.Size = new Size(413, 33);
            textBox_login.TabIndex = 6;
            textBox_login.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_password2
            // 
            textBox_password2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password2.Location = new Point(53, 169);
            textBox_password2.Name = "textBox_password2";
            textBox_password2.PasswordChar = '*';
            textBox_password2.PlaceholderText = "Повторити пароль...";
            textBox_password2.Size = new Size(413, 33);
            textBox_password2.TabIndex = 12;
            textBox_password2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_secureCode
            // 
            textBox_secureCode.BorderStyle = BorderStyle.FixedSingle;
            textBox_secureCode.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_secureCode.Location = new Point(259, 264);
            textBox_secureCode.Name = "textBox_secureCode";
            textBox_secureCode.PasswordChar = '*';
            textBox_secureCode.PlaceholderText = "Secure code";
            textBox_secureCode.Size = new Size(413, 22);
            textBox_secureCode.TabIndex = 13;
            textBox_secureCode.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_name
            // 
            textBox_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(486, 88);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "(ПІБ) Ім'я";
            textBox_name.Size = new Size(413, 33);
            textBox_name.TabIndex = 14;
            textBox_name.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_surname
            // 
            textBox_surname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_surname.Location = new Point(486, 130);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.PlaceholderText = "(ПІБ) Прізвище";
            textBox_surname.Size = new Size(413, 33);
            textBox_surname.TabIndex = 15;
            textBox_surname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_father
            // 
            textBox_father.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_father.Location = new Point(486, 169);
            textBox_father.Name = "textBox_father";
            textBox_father.PlaceholderText = "(ПІБ) По-батькові";
            textBox_father.Size = new Size(413, 33);
            textBox_father.TabIndex = 16;
            textBox_father.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.uz;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 332);
            Controls.Add(pictureBox2);
            Controls.Add(textBox_father);
            Controls.Add(textBox_surname);
            Controls.Add(textBox_name);
            Controls.Add(textBox_secureCode);
            Controls.Add(textBox_password2);
            Controls.Add(label1);
            Controls.Add(reg_Button);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація користувача";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button reg_Button;
        private TextBox textBox_password;
        private TextBox textBox_login;
        private TextBox textBox_password2;
        private TextBox textBox_secureCode;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_father;
        private PictureBox pictureBox2;
    }
}