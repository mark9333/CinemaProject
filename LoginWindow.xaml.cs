using Cinema.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cinema
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            UserDbContext userDbContext = new UserDbContext();
            IEnumerable<User> queryUsers = userDbContext.Users;

            User user = new User();

            user.first_name = "Petra";
            user.last_name = "Ackerman";
            user.username = "AOTTTTI";
            user.password = "123456789";

            userDbContext.Users.Add(user);
            userDbContext.SaveChanges();
            var Window = new MainWindow();
            Window.Show();
            this.Close();
        }
    }
}
