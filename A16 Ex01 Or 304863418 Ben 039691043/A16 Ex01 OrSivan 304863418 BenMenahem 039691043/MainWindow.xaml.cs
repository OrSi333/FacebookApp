using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Facebook;
using FacebookWrapper;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string s_AppId = "1687163321527087";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginResult result = FacebookService.Login(s_AppId, m_UserPermitions);
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                //Add a check that the user aprooved all permitions
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                m_IsLoggedIn = true;
                updateAllInfo();
                enableUIButtons();

            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

        }
        
    }
}
