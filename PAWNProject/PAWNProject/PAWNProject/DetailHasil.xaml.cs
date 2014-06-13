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
            if (listSoal.ElementAt(0).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(0).jawaban.ToString()))
            {
                jawab1.Text = "Benar";
            }
            else
            {
                jawab1.Text = "Salah";
            }
            soal2.Text = listSoal.ElementAt(1).Isi_Soal.ToString();
            if (listSoal.ElementAt(1).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(1).jawaban.ToString()))
            {
                jawab2.Text = "Benar";
            }
            else
            {
                jawab2.Text = "Salah";
            }
            soal3.Text = listSoal.ElementAt(2).Isi_Soal.ToString();
            if (listSoal.ElementAt(2).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(2).jawaban.ToString()))
            {
                jawab3.Text = "Benar";
            }
            else
            {
                jawab3.Text = "Salah";
            }
            soal4.Text = listSoal.ElementAt(3).Isi_Soal.ToString();
            if (listSoal.ElementAt(3).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(3).jawaban.ToString()))
            {
                jawab4.Text = "Benar";
            }
            else
            {
                jawab4.Text = "Salah";
            }
            soal5.Text = listSoal.ElementAt(4).Isi_Soal.ToString();
            if (listSoal.ElementAt(4).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(4).jawaban.ToString()))
            {
                jawab5.Text = "Benar";
            }
            else
            {
                jawab5.Text = "Salah";
            }
            soal6.Text = listSoal.ElementAt(5).Isi_Soal.ToString();
            if (listSoal.ElementAt(5).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(5).jawaban.ToString()))
            {
                jawab6.Text = "Benar";
            }
            else
            {
                jawab6.Text = "Salah";
            }
            soal7.Text = listSoal.ElementAt(6).Isi_Soal.ToString();
            if (listSoal.ElementAt(6).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(6).jawaban.ToString()))
            {
                jawab7.Text = "Benar";
            }
            else
            {
                jawab7.Text = "Salah";
            }
            soal8.Text = listSoal.ElementAt(7).Isi_Soal.ToString();
            if (listSoal.ElementAt(7).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(7).jawaban.ToString()))
            {
                jawab8.Text = "Benar";
            }
            else
            {
                jawab8.Text = "Salah";
            }
            soal9.Text = listSoal.ElementAt(8).Isi_Soal.ToString();
            if (listSoal.ElementAt(8).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(8).jawaban.ToString()))
            {
                jawab9.Text = "Benar";
            }
            else
            {
                jawab9.Text = "Salah";
            }
            soal10.Text = listSoal.ElementAt(9).Isi_Soal.ToString();
            if (listSoal.ElementAt(9).JawabanBenar.ToString().Equals(jawabanUser.ElementAt(9).jawaban.ToString()))
            {
                jawab10.Text = "Benar";
            }
            else
            {
                jawab10.Text = "Salah";
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}