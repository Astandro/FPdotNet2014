using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

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
            textBlockJumlahSalah.Text = "Jumlah Salah :" + " " + msg.JawabSalah.ToString();
            textBlockJumlahBenar.Text = "Jumlah Benar :" + " " + msg.JawabBenar.ToString();
            textBlockJumlahSoal.Text = "Jumlah Soal :" + " " + msg.JumlahSoal.ToString();
            if ((double)msg.Skor==100)
            {
                BitmapImage tn = new BitmapImage();
                tn.SetSource(Application.GetResourceStream(new Uri(@"Assets/100.png", UriKind.Relative)).Stream);
                resultface.Source = tn;
                Pesanresult.Text = "Sempurna! anda berhasil menjawab semua pertanyaan dengan benar";
            }
            else if ((double)msg.Skor >= 70 && (double)msg.Skor < 100)
            {
                BitmapImage tn = new BitmapImage();
                tn.SetSource(Application.GetResourceStream(new Uri(@"Assets/70more.png", UriKind.Relative)).Stream);
                resultface.Source = tn;
                Pesanresult.Text = "Hebat! anda mendapatkan skor yang memuaskan";
            }
            else if ((double)msg.Skor >= 40 && (double)msg.Skor <70)
            {
                BitmapImage tn = new BitmapImage();
                tn.SetSource(Application.GetResourceStream(new Uri(@"Assets/40more.png", UriKind.Relative)).Stream);
                resultface.Source = tn;
                Pesanresult.Text = "Selamat! anda berhasil melewati tes";
            }
            else if ((double)msg.Skor <40)
            {
                BitmapImage tn = new BitmapImage();
                tn.SetSource(Application.GetResourceStream(new Uri(@"Assets/less40.png", UriKind.Relative)).Stream);
                resultface.Source = tn;
                Pesanresult.Text = "Maaf anda belum berhasil melewati tes";
            }
        }

        private void btnSelesai_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailHasil.xaml", UriKind.Relative));
        }

        private void btnCobaLagi_Click(object sender, RoutedEventArgs e)
        {
            string tipesoal = ((Container)PhoneApplicationService.Current.State["Message"]).tipeSoal;
            if(tipesoal.Equals("Formil"))
                NavigationService.Navigate(new Uri("/TesLogikaFormilPage.xaml", UriKind.Relative));
            else if(tipesoal.Equals("Angka"))
                NavigationService.Navigate(new Uri("/TesLogikaAngkaPage.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/TesPadananKataPage.xaml", UriKind.Relative));
        }
    }
}