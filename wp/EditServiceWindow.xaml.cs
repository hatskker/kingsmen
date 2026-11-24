using System.Windows;
using Microsoft.Win32;

namespace wp
{
    public partial class EditServiceWindow : Window
    {
        private string selectedImage = "";

        public EditServiceWindow()
        {
            InitializeComponent();
        }

        // Выбор изображения
        private void ChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == true)
            {
                selectedImage = dialog.FileName;

                MessageBox.Show("Изображение выбрано!");
            }
        }

        // Сохранение изменений
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изменения сохранены!");
        }

        // Возврат на главную
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();

            Close();
        }

        private void DescriptionBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}