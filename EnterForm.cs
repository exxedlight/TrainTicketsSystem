using TrainTicketsWithDB.Entities;

namespace TrainTicketsWithDB
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void enter_Button_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Заповніть всі поля");
                return;
            }

            UserEntity? user;

            using (TrainDbContext context = new TrainDbContext())
            {
                user = context.Users.Where(x => x.login == login && x.password == password).ToList().FirstOrDefault();
            }
            
            if (user == null)
            {
                MessageBox.Show("Дані не належать жодному користувачу", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (user.role == 2)
            {
                CashierForm cform = new();
                cform.ShowDialog();
                return;
            }
            if(user.role == 3)
            {
                AdminForm adminForm = new();
                adminForm.ShowDialog();
                return;
            }

            UserForm uform = new UserForm(user);
            uform.ShowDialog();

            //  TODO: USER FORM
        }

        private void enterWithoutLogin_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserForm uForm = new UserForm();
            uForm.ShowDialog();
        }

        private void registration_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new();
            signUpForm.ShowDialog();
        }
    }
}