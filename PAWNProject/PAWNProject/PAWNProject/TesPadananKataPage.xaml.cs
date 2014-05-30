using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PAWNProject.Resources;

namespace PAWNProject
{
    public partial class TesPadananKataPage : PhoneApplicationPage
    {
        List<SoalPsikotes> listSoal = new List<SoalPsikotes>();
        List<Jawaban> jawabanUser = new List<Jawaban>();
        int nomor = 1;
        public TesPadananKataPage()
        {
            InitializeComponent();
           
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            jawabanUser.Clear();
            using (DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString))
            {
                db.CreateIfNotExists();
                db.LogDebug = true;
                listSoal = db.SoalPsikotes.ToList();
                nomorSoal.Text = "Soal nomor " + nomor + "/"+listSoal.Count;
                texBlockSoal.Text = listSoal.ElementAt(0).Isi_Soal;
                btnA.Content = listSoal.ElementAt(0).JawabanA;
                btnB.Content = listSoal.ElementAt(0).JawabanB;
                btnC.Content = listSoal.ElementAt(0).JawabanC;
                btnD.Content = listSoal.ElementAt(0).JawabanD;
            }
        }

        private void btnLanjut_Click(object sender, RoutedEventArgs e)
        {
            Jawaban temp = new Jawaban();
            bool check=false;
            if (btnA.IsChecked==true)
            {
                temp.jawaban = "A";
                check = true;
            }
            else if (btnB.IsChecked == true)
            {
                temp.jawaban = "B";
                check = true;
            }
            else if (btnC.IsChecked == true)
            {
                temp.jawaban = "C";
                check = true;
            }
            else if (btnD.IsChecked == true)
            {
                temp.jawaban = "D";
                check = true;
            }
            else
            {
                MessageBox.Show("Pilihlah salah satu jawaban !");
            }

            if (btnLanjut.Content.Equals("Selesai"))
            {
                temp.kodeSoal = listSoal.ElementAt(nomor - 1).Kode_Soal;
                jawabanUser.Add(temp);

                check = false;
                int benar = 0;
                foreach (Jawaban item in jawabanUser)
                {
                    foreach (SoalPsikotes soal in listSoal)
                    {
                        if (item.jawaban.ToArray().First() == soal.JawabanBenar.ToArray().First() && item.kodeSoal.Equals(soal.Kode_Soal))
                        {
                            benar++;
                        }
                    }
                }

                MessageBox.Show("Nilai Anda : "+((double)benar/listSoal.Count)*100+"%");
                NavigationService.Navigate(new Uri("/PsikotesMainPage.xaml", UriKind.Relative));
            }

            if (check)
            {
                temp.kodeSoal = listSoal.ElementAt(nomor-1).Kode_Soal;
                jawabanUser.Add(temp);

                if (nomor == listSoal.Count-1)
                {
                    btnLanjut.Content = "Selesai";
                }

                if (nomor < listSoal.Count)
                {
                    texBlockSoal.Text = listSoal.ElementAt(nomor).Isi_Soal;
                    btnA.Content = listSoal.ElementAt(nomor).JawabanA;
                    btnB.Content = listSoal.ElementAt(nomor).JawabanB;
                    btnC.Content = listSoal.ElementAt(nomor).JawabanC;
                    btnD.Content = listSoal.ElementAt(nomor).JawabanD;
                    btnA.IsChecked = false;
                    btnB.IsChecked = false;
                    btnC.IsChecked = false;
                    btnD.IsChecked = false;
                    nomor++;
                    nomorSoal.Text = "Soal nomor " + nomor + "/" + listSoal.Count;
                }            
            }
        }
    }
}