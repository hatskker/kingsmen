using System.Windows;

namespace wp
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }


        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            AuthWindow.RegisteredLogin = LoginBox.Text.Trim();
            AuthWindow.RegisteredPassword = PasswordBox.Password;

            MessageBox.Show("Регистрация прошла успешно!");

            MainWindow main = new MainWindow();
            main.Show();

            Close();
        }

      
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();

            Close();
        }
    }
}