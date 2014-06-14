using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PAWNProject
{
    public partial class PawnMainPage : PhoneApplicationPage
    {
        public PawnMainPage()
        {
            InitializeComponent();
        }
 

        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {

        }

    

        private void LogikaFormilBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TesLogikaFormilPage.xaml", UriKind.Relative));
        }

        private void LogikaAngkaBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TesLogikaAngkaPage.xaml", UriKind.Relative));
        }

        private void PadananKataBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TesPadananKataPage.xaml", UriKind.Relative));
        }

      
    }
}