﻿using System;
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
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TesLogikaAngkaPage.xaml", UriKind.Relative));
        }

      
    }
}