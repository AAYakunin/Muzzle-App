using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
    /// Логика взаимодействия для UserInfo.xaml
    /// </summary>
    public partial class UserInfo : Window
    {
        Client cl;
        string connectionString = @"server=DBSRV\SQL2021;database=sb2007_YakuninAA_Course;Trusted_Connection=True;";
        string sqlCommandString;
        public UserInfo(Client client)
        {
            InitializeComponent();

            sqlCommandString = $"select * from ClientService inner join [Service] on ClientService.ServiceID=[Service].ID where ClientID={client.id}";
            client.services = new List<Service>();
            cl = client;

            InitializeComponent();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection))
                {
                    try
                    {
                        DataTable services = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                        sqlConnection.Open();
                        dataAdapter.Fill(services);
                        sqlConnection.Close();

                        for (int i = 0; i < services.Rows.Count; i++)
                        {
                            var newService = new Service(Convert.ToInt32(services.Rows[i][0]), Convert.ToInt32(services.Rows[i][2]), services.Rows[i][6].ToString() ,services.Rows[i][3].ToString(), services.Rows[i][4].ToString());
                            client.services.Add(newService);
                        }
                        for (int i = 0; i < services.Rows.Count; i++)
                        {
                            Button newButton = new Button { Content = client.services[i].Title + " " + client.services[i].Date + " " + client.services[i].Comment, Height = 50 };
                            newButton.Background = new SolidColorBrush(Color.FromRgb(255, 228, 255));
                            newButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 74, 109));

                            scrollPanelServ.Children.Add(newButton);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //ФИО
            TextBlock newLabel = new TextBlock();
            newLabel.Text = "ФИО: ";
            newLabel.FontSize = 15;
            UserName.Children.Add(newLabel);
            newLabel = new TextBlock();
            newLabel.Text = client.lastName + " " + client.firstName + " " + client.patronymic;
            newLabel.FontSize = 15;
            UserName.Children.Add(newLabel);
            //Пол
            newLabel = new TextBlock();
            newLabel.Text = "Пол: ";
            newLabel.FontSize = 15;
            UserGender.Children.Add(newLabel);
            newLabel = new TextBlock();
            newLabel.Text = client.gender;
            newLabel.FontSize = 15;
            UserGender.Children.Add(newLabel);
            //Дата рождения
            newLabel = new TextBlock();
            newLabel.Text = "Дата рождения: ";
            newLabel.FontSize = 15;
            UserBirth.Children.Add(newLabel);
            newLabel = new TextBlock();
            newLabel.Text = client.birthday; 
            newLabel.FontSize = 15;
            UserBirth.Children.Add(newLabel);
            //Дата регистрации
            newLabel = new TextBlock();
            newLabel.Text = "Дата регистрации: ";
            newLabel.FontSize = 15;
            UserRegDate.Children.Add(newLabel);
            newLabel = new TextBlock();
            newLabel.Text = client.registrationDate;
            newLabel.FontSize = 15;
            UserRegDate.Children.Add(newLabel);
            //Email
            newLabel = new TextBlock();
            newLabel.Text = "Email адрес: ";
            newLabel.FontSize = 15;
            UserEmail.Children.Add(newLabel);
            newLabel = new TextBlock();
            newLabel.Text = client.email;
            newLabel.FontSize = 15;
            UserEmail.Children.Add(newLabel);
            //Телефон
            newLabel = new TextBlock();
            newLabel.Text = "Номер телефона: ";
            newLabel.FontSize = 15;
            UserPhone.Children.Add(newLabel);
            newLabel = new TextBlock();
            newLabel.Text = client.phone;
            newLabel.FontSize = 15;
            UserPhone.Children.Add(newLabel);

        }

        private void UserButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            UserEditWindow userEditWindow = new UserEditWindow(cl);
            userEditWindow.Show();
        }

        private void UserButtonAddVisit_Click(object sender, RoutedEventArgs e)
        {
            AddVisit addVisit = new AddVisit(cl);
            addVisit.Show();
        }
    }
}
