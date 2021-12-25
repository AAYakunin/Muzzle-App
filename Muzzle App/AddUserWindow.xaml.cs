using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
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
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        //string connectionString = "server=LAPTOP-4FDJEO5B;database=ms;Trusted_Connection=True;";
        string connectionString = @"server=DBSRV\SQL2021;database=sb2007_YakuninAA_Course;Trusted_Connection=True;";

        string sqlCommandString;
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string last = UserLastname.Text;
            string first = UserFirstname.Text;
            string patr = UserPatr.Text;
            string gender = "Мужской";
            if (UserGender.Text.ToLower() == "ж" || UserGender.Text.ToLower() == "женский" || UserGender.Text.ToLower() == "female" || UserGender.Text.ToLower() == "f")
                gender = "Женский";
            string birthday = UserBirth.Text;
            string regDate = "25.12.2021"; //время сейчас
            string email = UserEmail.Text;
            string phone = UserPhone.Text;

            sqlCommandString = $"insert into Client values ('{first}', '{last}', '{patr}', '{birthday}', '{regDate}', '{email}', '{phone}', {gender}, '')";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Пользователь успешно добавлен!");
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
