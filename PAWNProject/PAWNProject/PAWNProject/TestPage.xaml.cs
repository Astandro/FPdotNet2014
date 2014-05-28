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
    public partial class TestPage : PhoneApplicationPage
    {         
        List<SoalPsikotes> soal = new List<SoalPsikotes>();
        public TestPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SoalContext sContext = new SoalContext(SoalContext.ConnectionString);
            sContext.CreateIfNotExists();
            sContext.LogDebug = true;
            try
            {
                soal = sContext.SoalPsikotes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            texBlockSoal.Text = soal.ElementAt(0).IsiSoal;
            btnA.Content = soal.ElementAt(0).JawabanA;
            btnB.Content = soal.ElementAt(0).JawabanB;
            btnC.Content = soal.ElementAt(0).JawabanC;
        }

        private void btnLanjut_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}