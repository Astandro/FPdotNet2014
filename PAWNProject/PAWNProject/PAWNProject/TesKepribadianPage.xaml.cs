﻿using System;
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
    public partial class TesKepribadianPage : PhoneApplicationPage
    {
        List<SoalKepribadian> listSoal = new List<SoalKepribadian>();
        List<Jawaban> jawabanUser = new List<Jawaban>();
        int nomor = 1;
        HasilKepribadian pribadi = new HasilKepribadian();
        DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString);
        public TesKepribadianPage()
        {
            InitializeComponent();
        }

        private void LoadSoal()
        {   
                listSoal = Control.loadsoalKepribadianFromDB(db);
                jenisSoal.Text = listSoal.ElementAt(0).Jenis_Soal;
                txtBtnA.Text = listSoal.ElementAt(0).JawabanA;
                txtBtnB.Text = listSoal.ElementAt(0).JawabanB;
                txtBtnC.Text = listSoal.ElementAt(0).JawabanC;
                txtBtnD.Text = listSoal.ElementAt(0).JawabanD;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            jawabanUser.Clear();
            LoadSoal();
        }

        private void btnLanjut_Click(object sender, RoutedEventArgs e)
        {
            Jawaban temp = new Jawaban();
            bool check = false;
            if (btnA.IsChecked == true)
            {
                temp.jawaban = "A";
                check = true;
                jawabanUser.Add(temp);
            }
            else if (btnB.IsChecked == true)
            {
                temp.jawaban = "B";
                check = true;
                jawabanUser.Add(temp);
            }
            else if (btnC.IsChecked == true)
            {
                temp.jawaban = "C";
                check = true;
                jawabanUser.Add(temp);
            }
            else if (btnD.IsChecked == true)
            {
                temp.jawaban = "D";
                check = true;
                jawabanUser.Add(temp);
            }
            else
            {
                MessageBox.Show("Pilihlah salah satu jawaban !");
            }

            if (btnLanjut.Content.Equals("Selesai"))
            {
                check = false;
                int hasil;
                hasil = Control.HasilKepribadian(jawabanUser);
                pribadi = Control.LoadHasilKepribadian(db, hasil);
                PhoneApplicationService.Current.State["kepribadian"] = pribadi;
                NavigationService.Navigate(new Uri("/TestKepribadianResult.xaml", UriKind.Relative));
            }

            if (check)
            {
                temp.kodeSoal = listSoal.ElementAt(nomor - 1).Kode_Soal;
                
                if (nomor == listSoal.Count - 1)
                {
                    btnLanjut.Content = "Selesai";
                }

                if (nomor < listSoal.Count)
                {
                    jenisSoal.Text = listSoal.ElementAt(nomor).Jenis_Soal;
                    txtBtnA.Text = listSoal.ElementAt(nomor).JawabanA;
                    txtBtnB.Text = listSoal.ElementAt(nomor).JawabanB;
                    txtBtnC.Text = listSoal.ElementAt(nomor).JawabanC;
                    txtBtnD.Text = listSoal.ElementAt(nomor).JawabanD;
                    btnA.IsChecked = false;
                    btnB.IsChecked = false;
                    btnC.IsChecked = false;
                    btnD.IsChecked = false;
                    nomor++;
                }
            }
        }
    }
}