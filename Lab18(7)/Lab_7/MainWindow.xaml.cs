using System.IO;
using System.Windows;

namespace Lab_7
{
    public partial class MainWindow : Window
    {
        static string link = @"C:\Dir";
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show($"Your current path: {link}");
        }
        static void CreateDirRecursive(int i = 0)
        {
            if (i < 100)
            {
                var directory = new DirectoryInfo(link);
                directory.CreateSubdirectory($"Folder_{i}");
                link += @$"\Folder_{i}";
                CreateDirRecursive(i + 1);
            }
            else return;
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            CreateDirRecursive();
            MessageBox.Show($"Max of created folders 100!");
            link = @"C:\Dir";
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            var directory_clear = new DirectoryInfo(link);
            directory_clear.Delete(true);
            MessageBox.Show($"Dir has been deleted!");
        }
    }
}
