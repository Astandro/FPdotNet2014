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
    public partial class PsychotestMainPage : PhoneApplicationPage
    {
        List<string> listKetentuan = new List<string>();
        List<string> sourceList = new List<string>();

        public PsychotestMainPage()
        {
            InitializeComponent();

            listKetentuan.Add("1. Soal Psikotes terdiri dari 30 soal\n");
            listKetentuan.Add("2. Soal-soal terdiri dari 3 jenis yaitu tes\n   numerik, verbal, dan penalaran\n");
            listKetentuan.Add("3. Setiap soal memiliki nilai benar atau salah\n");
            listKetentuan.Add("4. Setelah menjawab satu soal, maka akan\n   dilanjutkan ke soal berikutnya\n");
            listKetentuan.Add("5. Soal yang telah dijawab tidak dapat\n   diganti jawabannya\n");
            listKetentuan.Add("6. Tidak ada durasi pengerjaan tiap soal\n");
            listKetentuan.Add("7. Hasil akhir dari psikotes ini adalah\n   persentase jawaban benar\n");

            for (int i = 0; i < 4; i++)
            {
                sourceList.Add(listKetentuan.ElementAt(i));
            }

            viewerListKetentuan.ItemsSource = null;
            viewerListKetentuan.ItemsSource = sourceList;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (btnNext.Content.Equals("Next"))
            {
                sourceList.Clear();
                for (int i = 4; i < 7; i++)
                {
                    sourceList.Add(listKetentuan.ElementAt(i));
                }
                viewerListKetentuan.ItemsSource = null;
                viewerListKetentuan.ItemsSource = sourceList;
                btnNext.Content = "Mulai tes";
            }
            else
            {

            }
        }
    }
}