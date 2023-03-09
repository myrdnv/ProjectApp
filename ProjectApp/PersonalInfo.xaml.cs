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
    /// Interaction logic for PersonalInfo.xaml
    /// </summary>
    public partial class PersonalInfo : Window
    {
        public PersonalInfo()
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC16\LOCALHOST; Initial Catalog=SemesterProject2; Integrated Security=True");


            try
            {
                sqlCon.Open();

                string query = "INSERT INTO Personal_Info(Mobile_Number,First_Name,Last_Name,Gender)values ('" + mobile.Text + "','" + firstName.Text + "','" + lastName.Text + "','" + gender.Text + "') ";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully added");

                MainMenu lg = new MainMenu();
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
    }
}
