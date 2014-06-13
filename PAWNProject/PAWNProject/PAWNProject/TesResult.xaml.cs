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
            Container msg = new Container();
            msg = (Container)PhoneApplicationService.Current.State["Message"];
            msg.Skor = Math.Round((Double)msg.Skor);
            textBlockSkor.Text = "Skor Anda " + msg.Skor.ToString() + "%";
            textBlockJumlahSalah.Text += " " + msg.JawabSalah.ToString();
            textBlockJumlahBenar.Text += " " + msg.JawabBenar.ToString();
            textBlockJumlahSoal.Text += " " + msg.JumlahSoal.ToString();

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