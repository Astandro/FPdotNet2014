using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PAWNProject;
using System.Collections.Generic;


namespace TestApp1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void LoadSoalFromDBTest()
        {

            PAWNProject.DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString);
            List<SoalPsikotes> listSoal = Control.LoadSoalFromDB(db);
            int expectedResult = 30;
            int result = listSoal.Count;
            Assert.AreEqual(expectedResult, result, "The result should be 30 .");
        }

        [TestMethod]
        public void LoadSoalKepribadianFromDBTest()
        {

            PAWNProject.DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString);
            List<SoalKepribadian> listSoal = Control.loadsoalKepribadianFromDB(db);
            int expectedResult = 40;
            int result = listSoal.Count;
            Assert.AreEqual(expectedResult, result, "The result should be 40 .");
        }

        [TestMethod]
        public void LoadSoalLogikaAngkaFromDBTest()
        {

            DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString);
            List<SoalPsikotes> listSoal = Control.LoadSoalLogikaAngkaFromDB(db);
            int expectedResult = 10;
            int result = listSoal.Count;
            Assert.AreEqual(expectedResult, result, "The result should be 10 .");
        }

        [TestMethod]
        public void LoadSoalLogikaFormilFromDBTest()
        {

            DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString);
            List<SoalPsikotes> listSoal = Control.LoadSoalLogikaFormilFromDB(db);
            int expectedResult = 10;
            int result = listSoal.Count;
            Assert.AreEqual(expectedResult, result, "The result should be 10 .");
        }

        [TestMethod]
        public void LoadSoalPadananKataFromDBTest()
        {

            DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString);
            List<SoalPsikotes> listSoal = Control.LoadSoalPadananKataFromDB(db);
            int expectedResult = 10;
            int result = listSoal.Count;
            Assert.AreEqual(expectedResult, result, "The result should be 10 .");
        }

        [TestMethod]
        public void LoadSoalHasilKepribadianTest()
        {
            DBSoalContext db = new DBSoalContext(DBSoalContext.ConnectionString);
            HasilKepribadian hk = Control.LoadHasilKepribadian(db, 0);
            string expectedResult = "Sanguinis";
            string result = hk.Nama_Kepribadian;
            Assert.AreEqual(expectedResult, result, "The result should be Sanguinis ,result is = " + result);
        }

        [TestMethod]
        public void HitungSkorTest()
        {
            SoalPsikotes dummy1 = new SoalPsikotes();
            SoalPsikotes dummy2 = new SoalPsikotes();
            SoalPsikotes dummy3 = new SoalPsikotes();
            dummy1.JawabanBenar = "A";
            dummy2.JawabanBenar = "B";
            dummy3.JawabanBenar = "C";
            dummy1.Kode_Soal = "1";
            dummy2.Kode_Soal = "2";
            dummy3.Kode_Soal = "3";

            Jawaban jawaban1 = new Jawaban();
            Jawaban jawaban2 = new Jawaban();
            Jawaban jawaban3 = new Jawaban();
            jawaban1.jawaban = "A";
            jawaban2.jawaban = "B";
            jawaban3.jawaban = "C";
            jawaban1.kodeSoal = "1";
            jawaban2.kodeSoal = "2";
            jawaban3.kodeSoal = "3";

            List<SoalPsikotes> sp = new List<SoalPsikotes>();
            sp.Add(dummy1);
            sp.Add(dummy2);
            sp.Add(dummy3);
            List<Jawaban> jwb = new List<Jawaban>();
            jwb.Add(jawaban1);
            jwb.Add(jawaban2);
            jwb.Add(jawaban3);

            int result = Control.HitungBenar(jwb, sp);
            int expectedResult = 3;

            Assert.AreEqual(expectedResult, result, "The result should be 3");

        }

        [TestMethod]
        public void HasilKepribadianTest()
        {
            Jawaban jawaban1 = new Jawaban();
            Jawaban jawaban2 = new Jawaban();
            Jawaban jawaban3 = new Jawaban();
            Jawaban jawaban4 = new Jawaban();
            jawaban1.jawaban = "B";
            jawaban2.jawaban = "C";
            jawaban3.jawaban = "C";
            jawaban4.jawaban = "C";

            List<Jawaban> lj = new List<Jawaban>();
            lj.Add(jawaban1);
            lj.Add(jawaban2);
            lj.Add(jawaban3);
            lj.Add(jawaban4);

            int result = Control.HasilKepribadian(lj);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, result, "The result should be 1");

        }
    }
}

