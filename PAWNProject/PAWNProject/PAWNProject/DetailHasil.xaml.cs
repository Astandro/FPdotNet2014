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
    public partial class DetailHasil : PhoneApplicationPage
    {
        public DetailHasil()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //base.OnNavigatedTo(e);
            List<Jawaban> jawabanUser = new List<Jawaban>();
            List<SoalPsikotes> listSoal = new List<SoalPsikotes>();

            jawabanUser = (List<Jawaban>)PhoneApplicationService.Current.State["Jawaban"];
            listSoal = (List<SoalPsikotes>)PhoneApplicationService.Current.State["Soal"];

            soal1.Text = listSoal.ElementAt(0).Isi_Soal.ToString();
            if (listSoal.ElementAt(0).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(0).ToString()))
            {
                jawab1.Text = "Benar";
            }
            else
            {
                jawab1.Text = "Salah";
            }
        }
    }
}