using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            /*SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC16\LOCALHOST; Initial Catalog=SemesterProject2; Integrated Security=True");

            sqlCon.Open();

            string query = "SELECT Username FROM LogIn_Details";

            SqlCommand cmd = new SqlCommand(query, sqlCon);

            cmd.ExecuteNonQuery();
            Username.Content = */
        }

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Settings dashboard = new Settings();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditAccount dashboard = new EditAccount();
            dashboard.Show();
            this.Close();
        }
    }
}
