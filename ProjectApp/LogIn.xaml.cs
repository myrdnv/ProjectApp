using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
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




                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM LogIn_Details Where Username=@Username and Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", username.Text);
                sqlCmd.Parameters.AddWithValue("@Password", password.Password);

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainMenu dashboard = new MainMenu();
                    dashboard.Username.Content = username.Text;
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password are not correct!");
                }


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
    }
}
