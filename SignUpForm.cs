using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTicketsWithDB.Entities;

namespace TrainTicketsWithDB
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void reg_Button_Click(object sender, EventArgs e)
        {
            if(textBox_login.Text == string.Empty || 
                textBox_password.Text == string.Empty)
            {
                MessageBox.Show("Заповніть всі поля", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if(textBox_password.Text != textBox_password2.Text)
            {
                MessageBox.Show("Паролі у полях не сходяться", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(textBox_password.Text.Length < 10)
            {
                MessageBox.Show("Пароль має містити від 10 символів!");
                return;
            }

            int role = 1;

            if (!string.IsNullOrWhiteSpace(textBox_secureCode.Text))
            {
                using(TrainDbContext context = new TrainDbContext())
                {
                    CodeEntity? code = context.Codes.FirstOrDefault(x => x.code == textBox_secureCode.Text);
                    if (code != null) role = code.role;
                }
            }
            
            if(role == 1)
            {
                if(textBox_name.Text == string.Empty ||
                textBox_surname.Text == string.Empty ||
                textBox_father.Text == string.Empty)
                {
                    MessageBox.Show("Заповніть всі поля", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                using (TrainDbContext context = new TrainDbContext())
                {

                    if (context.Users.Any(x => x.login == textBox_login.Text))
                    {
                        MessageBox.Show("Такий логін вже використовується", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    UserEntity user = new UserEntity
                    {
                        login = textBox_login.Text,
                        password = textBox_password.Text,
                        name = textBox_name.Text,
                        surname = textBox_surname.Text,
                        father = textBox_father.Text,
                        role = role
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                }

                MessageBox.Show("User added");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
