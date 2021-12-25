using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Muzzle_App
{
    /// <summary>
    /// Логика взаимодействия для AddVisit.xaml
    /// </summary>
    public partial class AddVisit : Window
    {
        Client cl;

        string connectionString = @"server=DBSRV\SQL2021;database=sb2007_YakuninAA_Course;Trusted_Connection=True;";

        string sqlCommandString;
        public AddVisit(Client client)
        {
            cl = client;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sqlCommandString = $"insert into [ClientService] values ({cl.id}, (select id from [Service] where Title='{ServiceType.Text}'), '{ServiceDate.Text}', '{ServiceComment.Text}')";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Визит назначен!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
