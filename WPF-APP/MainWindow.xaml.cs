using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_APP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string _username = ConfigurationManager.AppSettings["username"];
        public MainWindow()
        {
            InitializeComponent();
            UpdateLabelText();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MainResources.WelcomeMessagePlaceholder + _username);
        }

        private void OnWindowClosed(object sender, EventArgs e)
        {
            MessageBox.Show(MainResources.FarewellMessagePlaceholder + _username);
        }
        private void Window_SizeChanged1(object sender, SizeChangedEventArgs e)
        {
            UpdateLabelText();
        }
        private void UpdateLabelText()
        {
            MainLabel.Content = $"width: {Width} height: {Height}";
        }
    }
}
