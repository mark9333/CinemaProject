using System.Windows;


namespace Cinema
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(); 
        }
    }
}
