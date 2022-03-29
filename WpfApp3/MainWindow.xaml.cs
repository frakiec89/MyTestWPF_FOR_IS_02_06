using System;
using System.Collections.Generic;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btRegistration_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("в разработке");
        }

        private void btAuttorization_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text =="admin" && tbPassword.Text =="123")
            {
                MyWindows.MenuWindows menuWindows = new MyWindows.MenuWindows();
                menuWindows.Show();
                Close();
            }
            else
            {
                MessageBox.Show("неверный  логин  или пароль");
            }
            
        }
    }
}
