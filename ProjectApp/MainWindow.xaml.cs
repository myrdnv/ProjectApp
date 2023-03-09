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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal object label;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC16\LOCALHOST; Initial Catalog=SemesterProject2; Integrated Security=True");

            
            try
            {
                sqlCon.Open();

                string query = "INSERT INTO LogIn_Details(Username,Email,Password)values ('" + username.Text + "','" + email.Text + "','" + password.Password + "') ";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully registered");

                LogIn lg = new LogIn();
                lg.Show();
                this.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlCon.Close();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Close();
        }
    }
}