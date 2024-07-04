namespace TrainTicketsWithDB
{
    partial class EnterForm
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
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            enter_Button = new Button();
            registration_link = new LinkLabel();
            enterWithoutLogin_link = new LinkLabel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_login.Location = new Point(53, 88);
            textBox_login.Name = "textBox_login";
            textBox_login.PlaceholderText = "Ім'я користувача...";
            textBox_login.Size = new Size(413, 33);
            textBox_login.TabIndex = 0;
            textBox_login.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.Location = new Point(53, 130);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.PlaceholderText = "Пароль...";
            textBox_password.Size = new Size(413, 33);
            textBox_password.TabIndex = 1;
            textBox_password.TextAlign = HorizontalAlignment.Center;
            // 
            // enter_Button
            // 
            enter_Button.FlatStyle = FlatStyle.Flat;
            enter_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            enter_Button.Location = new Point(53, 169);
            enter_Button.Name = "enter_Button";
            enter_Button.Size = new Size(413, 33);
            enter_Button.TabIndex = 2;
            enter_Button.Text = "Вхід";
            enter_Button.UseVisualStyleBackColor = true;
            enter_Button.Click += enter_Button_Click;
            // 
            // registration_link
            // 
            registration_link.AutoSize = true;
            registration_link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registration_link.Location = new Point(379, 205);
            registration_link.Name = "registration_link";
            registration_link.Size = new Size(87, 21);
            registration_link.TabIndex = 3;
            registration_link.TabStop = true;
            registration_link.Text = "Реєстрація";
            registration_link.LinkClicked += registration_link_LinkClicked;
            // 
            // enterWithoutLogin_link
            // 
            enterWithoutLogin_link.AutoSize = true;
            enterWithoutLogin_link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enterWithoutLogin_link.Location = new Point(53, 205);
            enterWithoutLogin_link.Name = "enterWithoutLogin_link";
            enterWithoutLogin_link.Size = new Size(175, 21);
            enterWithoutLogin_link.TabIndex = 4;
            enterWithoutLogin_link.TabStop = true;
            enterWithoutLogin_link.Text = "Продовжити без входу";
            enterWithoutLogin_link.LinkClicked += enterWithoutLogin_link_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 35);
            label1.TabIndex = 5;
            label1.Text = "ВІТАЄМО!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.uz;
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 255);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(enterWithoutLogin_link);
            Controls.Add(registration_link);
            Controls.Add(enter_Button);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EnterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизація";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button enter_Button;
        private LinkLabel registration_link;
        private LinkLabel enterWithoutLogin_link;
        private Label label1;
        private PictureBox pictureBox2;
    }
}