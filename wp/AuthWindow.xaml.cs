using System.Windows;

namespace wp
{
    public partial class AuthWindow : Window
    {
        // Данные зарегистрированного пользователя
        public static string RegisteredLogin = "";
        public static string RegisteredPassword = "";

        public AuthWindow()
        {
            InitializeComponent();
        }

        // Авторизация -> Главная
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                MessageBox.Show("Заполните логин и пароль!");
                return;
            }

            if (RegisteredLogin == "")
            {
                MessageBox.Show("Сначала зарегистрируйтесь!");
                return;
            }

            if (LoginBox.Text.Trim() != RegisteredLogin ||
                PasswordBox.Password != RegisteredPassword)
            {
                MessageBox.Show("Неверный логин или пароль!");
                return;
            }

            MainWindow main = new MainWindow();
            main.Show();

            Close();
        }

        // Авторизация -> Регистрация
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registration =
                new RegistrationWindow();

            registration.Show();

            Close();
        }
    }
}