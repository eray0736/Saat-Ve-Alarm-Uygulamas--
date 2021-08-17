using System;
using System.Windows.Forms;
using System.Media;

namespace alarm_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Gün ay ve yıl adında zaman değişkenlerini oluşturuyor.
        DateTime zaman;
        int gün, ay, yıl;
        //System.Media adlı kütüphanedeki SounPlayer sınıfından bir nesne oluşturup 'ses.wav' dosyasına eşitliyor.
        SoundPlayer ses = new SoundPlayer("ses.wav");
        int ertelemesüresi = 0;
        //Formumuzdaki labelde güncel zamanı gösterebilmek DateTime sınıfından güncel zamanı çekip timer1 e eşitliyor.
        private void Form1_Load(object sender, EventArgs e)
        {
            IBIgüncel_zaman.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }
        //Kullanıcı tarafından belirlenen alarm zamanını güncel zamana eşit olduğunda ses dosyasını çalıştırıyor.
        private void timer1_Tick(object sender, EventArgs e)
        {
            IBIgüncel_zaman.Text = DateTime.Now.ToLongTimeString();
            if (IBIgüncel_zaman.Text==txtAlarmZamanı.Text)
            {
                ses.Play();
            }
            //Gün ay ve yıl değerlerine güncel değerlerini atıyor.
            zaman = DateTime.Now;
            gün = zaman.Day;
            ay = zaman.Month;
            yıl = zaman.Year;
            labelTARİH.Text = string.Format("{0:00}.{1:00}.{2:0000}", gün, ay, yıl);
        }
        //DateTime tipinde zaman nesnesi oluşturarak alarm kurma işlemini gerçekleştiriyor.
        private void BTNalarmKur_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime zaman = Convert.ToDateTime(txtAlarmZamanı.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli zamanı giriniz");
                txtAlarmZamanı.Focus();
                txtAlarmZamanı.SelectAll();
                return;
            }
        }
        //Butona bastığımızda timer2 yardımıyla alarmı 5 saniye erteliyor.
        private void BTNalarmErteleme_Click(object sender, EventArgs e)
        {
            ertelemesüresi = 5;
            timer2.Enabled = true;
            ses.Stop();
        
        }
        //Erteleme süresini kontrol edip 0'a geldiğinde alarmı tekrar çalıştırıyor.
        private void timer2_Tick(object sender, EventArgs e)
        {
            while (ertelemesüresi==0)
            {
                ses.Play();
                timer1.Enabled = true;
                timer2.Enabled = false;
                label2.Text = "kalkma zamanı";
                return;
            }
            ertelemesüresi--;
            label2.Text = ertelemesüresi.ToString() + "saniye sonra alarm çalacak";
        }
        //Butona bastığımızda alarmı durduruyor.
        private void BtnAlarmSustur_Click(object sender, EventArgs e)
        {
            ses.Stop();
            timer2.Stop();
            label2.Text = "";
        }
        //'alarm saatini giriniz' ifadesini içeren label.
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alarm saatini giriniz");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtAlarmZamanı_TextChanged(object sender, EventArgs e)
        {

        }

        private void IBIgüncel_zaman_Click(object sender, EventArgs e)
        {
            
        }

        private void labelTARİH_Click(object sender, EventArgs e)
        {

        }
    }
}
