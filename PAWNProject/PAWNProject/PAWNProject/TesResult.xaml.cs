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
    public partial class testResult : PhoneApplicationPage
    {
        public testResult()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Container msg = new Container();
            msg = (Container)PhoneApplicationService.Current.State["Message"];
            textBlockSkor.Text = "Skor Anda : " + msg.Skor + "%";

        }

        private void btnSelesai_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PsikotesMainPage.xaml", UriKind.Relative));
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailHasil.xaml", UriKind.Relative));
        }
    }
}