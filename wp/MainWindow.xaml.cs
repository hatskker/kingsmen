using System.Windows;

namespace wp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Главная -> Edit Service
        private void Services_Click(object sender, RoutedEventArgs e)
        {
            EditServiceWindow service = new EditServiceWindow();

            service.Owner = this;

            service.ShowDialog();
        }

        // Кнопка сотрудников
        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "В презентации отдельного окна сотрудников нет.");
        }

        // Кнопка клиентов
        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "В презентации отдельного окна клиентов нет.");
        }

    }
}