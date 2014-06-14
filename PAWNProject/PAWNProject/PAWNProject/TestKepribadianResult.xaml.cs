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
    public partial class TestKepribadianResult : PhoneApplicationPage
    {
        public TestKepribadianResult()
        {
            InitializeComponent();
        }

         protected override void OnNavigatedTo(NavigationEventArgs e)
         {
             HasilKepribadian kepribadian = (HasilKepribadian) PhoneApplicationService.Current.State["kepribadian"];
             infoHasil.Text = kepribadian.Info_Kepribadian;
             keunggulan1.Text = kepribadian.Keunggulan1;
             keunggulan2.Text = kepribadian.Keunggulan2;
             keunggulan3.Text = kepribadian.Keunggulan3;
             kelemahan1.Text = kepribadian.Kelemahan1;
             kelemahan2.Text = kepribadian.Kelemahan2;
             kelemahan3.Text = kepribadian.Kelemahan3;
             profesiText.Text = kepribadian.Pekerjaan;
             BitmapImage tn = new BitmapImage();
             tn.SetSource(Application.GetResourceStream(new Uri(@"Assets/"+kepribadian.Nama_Kepribadian+".jpg", UriKind.Relative)).Stream);
             hasilImage.Source = tn;



         }

         private void Button_Click(object sender, RoutedEventArgs e)
         {
             NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
         }

    }

    
}