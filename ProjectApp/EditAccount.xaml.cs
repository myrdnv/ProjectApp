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
using System.Windows.Shapes;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for EditAccount.xaml
    /// </summary>
    public partial class EditAccount : Window
    {
        public EditAccount()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settings dashboard = new Settings();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu dashboard = new MainMenu();
            dashboard.Show();
            this.Close();
        }
    }
}
