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
    /// Логика взаимодействия для UserEditWindow.xaml
    /// </summary>
    public partial class UserEditWindow : Window
    {
        Client cl;

        string connectionString = @"server=DBSRV\SQL2021;database=sb2007_YakuninAA_Course;Trusted_Connection=True;";

        string sqlCommandString;

        public UserEditWindow(Client client)
        {
            InitializeComponent();
            cl = client;
            UserLastname.Text = client.lastName;
            UserFirstname.Text = client.firstName;
            UserPatr.Text = client.patronymic;
            UserGender.Text = client.gender;
            UserBirth.Text = client.birthday;
            UserEmail.Text = client.email;
            UserPhone.Text = client.phone;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int genCode;

            if (cl.gender == "Мужской")
                genCode = 0;
            else
                genCode = 1;

            sqlCommandString = $"update Client set FirstName='{UserFirstname.Text}', LastName='{UserLastname.Text}', Patronymic='{UserPatr.Text}', Birthday='{UserBirth.Text}', GenderCode={genCode}, Email='{UserEmail.Text}', Phone='{UserPhone.Text}' where ID={cl.id}";



            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Данные обновлены!");
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
