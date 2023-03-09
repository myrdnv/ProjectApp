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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LogIn lg = new LogIn();
            MainMenu dashboard = new MainMenu();
            dashboard.Username.Content = lg.username.Text;
            dashboard.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalInfo dashboard = new PersonalInfo();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AccountInfo dashboard = new AccountInfo();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Status dashboard = new Status();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            LogInDetails dashboard = new LogInDetails();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OrderInfo dashboard = new OrderInfo();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            UserAndDeviceDetails dashboard = new UserAndDeviceDetails();
            dashboard.Show();
            this.Close();
        }
    }
}
