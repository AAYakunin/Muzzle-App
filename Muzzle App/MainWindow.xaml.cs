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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Muzzle_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string connectionString = "server=LAPTOP-4FDJEO5B;database=ms;Trusted_Connection=True;";
        string connectionString = @"server=DBSRV\SQL2021;database=sb2007_YakuninAA_Course;Trusted_Connection=True;";
        
        string sqlCommandString = "select * from Client";

        List<Client> clientList;

        public MainWindow()
        {
            InitializeComponent();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection))
                {
                    try
                    {
                        DataTable clients = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                        sqlConnection.Open();
                        dataAdapter.Fill(clients);
                        sqlConnection.Close();

                        clientList = new List<Client>();

                        for (int i = 0; i < clients.Rows.Count; i++)
                        {
                            var newClient = new Client(Convert.ToInt32(clients.Rows[i][0]), clients.Rows[i][1].ToString(), 
                                                        clients.Rows[i][2].ToString(), clients.Rows[i][3].ToString(), 
                                                        clients.Rows[i][4].ToString(), clients.Rows[i][5].ToString(), 
                                                        clients.Rows[i][6].ToString(), clients.Rows[i][7].ToString(), 
                                                        Convert.ToInt32(clients.Rows[i][8]));
                            clientList.Add(newClient);
                        }

                        for (int i = 0; i < clients.Rows.Count; i++)
                        {
                            Button newButton = new Button { Content = clients.Rows[i][2] + " " + clients.Rows[i][1], Height = 50 };
                            newButton.Click += ClientButton_Click;
                            newButton.Tag = clients.Rows[i][0];
                            newButton.Background = new SolidColorBrush(Color.FromRgb(255, 228, 255));
                            newButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 74, 109));
                            
                            scrollPanel.Children.Add(newButton);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void ClientButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var value = Convert.ToInt32(button.Tag);
            for (int i = 0; i < clientList.Count; i++)
            {
                if (value == clientList[i].id)
                {
                    UserInfo userInfo = new UserInfo(clientList[i]);
                    userInfo.Show();
                }
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.Show();
        }

        private void UpdateList_Click(object sender, RoutedEventArgs e) //обнову сделать
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
