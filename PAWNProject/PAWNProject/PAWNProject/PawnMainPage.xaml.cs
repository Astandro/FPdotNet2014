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

        private void Panorama_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TestPage.xaml", UriKind.Relative));
        }
    }
}