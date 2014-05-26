using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PAWNProject.Resources;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PAWNProject
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PawnMainPage.xaml", UriKind.Relative));
        }

        private void RegisBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }
       

    }
}