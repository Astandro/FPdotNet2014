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


        private void PsikotesBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PsikotesMainPage.xaml", UriKind.Relative));
        }

        private void KepribadianBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TesKepribadianMainPage.xaml", UriKind.Relative));

        }

        private void TipsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TipsMainPage.xaml", UriKind.Relative));
        }

        private void RegisBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

      
      

     

   

        
       

    }
}