using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Form ilk açıldığında çalışan metottur. Burada form açıldığında datagridview'ler doldurulur,listelenir ve ekrana basılır.
        private void Form1_Load(object sender, EventArgs e)
        {
            using (OgrenciKayitEntities db = new OgrenciKayitEntities())
            {
                //Sol Alttaki DataGridView'i dolduracak
                dvOgrenci.DataSource = db.Ogrenci.ToList();


                //Sağ taraftaki ComboBox'ı(Drop Down List'i) Dolduracak.
                cbOgrenciSec.DataSource = db.Ogrenci.ToList();
                cbOgrenciSec.ValueMember = "OgrenciId";
                cbOgrenciSec.DisplayMember = "OgrenciAdi";

            }

        }


        //Kaydet butonuna tıklayınca çalışacak metottur.
        private void btnKayit_Click(object sender, EventArgs e)
        {


            using (OgrenciKayitEntities db = new OgrenciKayitEntities())
            {

                //Butona tıkladığımızda kayıt işlemi yapıcak kodlar 
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Adres = txtAdres.Text;
                ogrenci.CepNo = txtOgrenciCepNo.Text;
                ogrenci.OgrenciAdi = txtOgrenciAdiSoyadi.Text;

                //Burada Cinsiyet kadın olarak seçilmiş ise cinsiyete true atıyoruz.
                if (radioKadın.Checked == true)
                {
                    ogrenci.Cinsiyet = true;

                }
                //Burada Cinsiyet erkek olarak seçilmiş ise cinsiyete true atıyoruz.
                else if (radioErkek.Checked == true)
                {
                    ogrenci.Cinsiyet = false;
                }
                ogrenci.TCNo = txtOgrenciTCNO.Text;

                db.Ogrenci.Add(ogrenci);
                db.SaveChanges();
                MessageBox.Show("Öğrenci başarılı bir şekilde kayıt edildi");

                //Kayıt işlemi bittikten sonra tekrar DataGridView Dolduruluyor.
                dvOgrenci.DataSource = db.Ogrenci.ToList();

            }
        }



        // Ogrenci DataGridView'i içerisinde ki satırlara tıklandığında çalışacak metottur.
        // Burada ki class'ta ki tüm metotlarda kullanabilmek için tanımlıyoruz.Çünkü bu değişkene göre kayıt günelleme ve silme yapılacaktır.

        int OgrenciId = 0;
        private void dvOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bu karar mekanizmasında sadece satırlara tıklama sartı uyguladık,tıklanan satır işlem yap denildi.
            if (dvOgrenci.Rows.Count > 0)
            {

                //Aşağıdaki kodlarda,tıklanan dataGridView'ler satırlarından istenilen sütunnlara textboxlara aktarıyoruz.
                txtOgrenciAdiSoyadi.Text = dvOgrenci.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtOgrenciCepNo.Text = dvOgrenci.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtOgrenciTCNO.Text = dvOgrenci.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAdres.Text = dvOgrenci.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (dvOgrenci.Rows[e.RowIndex].Cells[4].Value.ToString() == "true")
                {
                    radioKadın.Checked = true;
                }
                else
                {
                    radioErkek.Checked = true;
                }


                OgrenciId = Convert.ToInt32(dvOgrenci.Rows[e.RowIndex].Cells[0].Value.ToString());

                // Bu DataGridView'den Ogrenci Seçildiği zaman sağda ki dataGridView'e devamsızlık bilgilerinin getirilmesini sağlayan kod yapısını yazıyoruz.


                using (OgrenciKayitEntities db = new OgrenciKayitEntities())
                {
                    dtDevamsizlik.DataSource = db.Devamsizlik.Where(x => x.OgrenciId == OgrenciId).OrderBy(c => c.Gun).ToList();

                    //Listeleme yaparken hem ogrenci Idsini baz alsın hem de küçükten büyüğe sıralasın.
                }



            }




        }

        // Güncelle butonuna tıklandığında çalışan metottur.

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            using (OgrenciKayitEntities db = new OgrenciKayitEntities())
            {

                //Daha once yukarıda tanımlamıs oldugumuz OgrenciId'sine göre güncelleme işlemini başlatıyoruz.

                Ogrenci ogrenci = db.Ogrenci.Find(OgrenciId);
                ogrenci.Adres = txtAdres.Text;
                ogrenci.CepNo = txtOgrenciCepNo.Text;
                ogrenci.OgrenciAdi = txtOgrenciAdiSoyadi.Text;
                if (radioKadın.Checked == true)
                {
                    ogrenci.Cinsiyet = true;

                }
                //Burada Cinsiyet erkek olarak seçilmiş ise cinsiyete true atıyoruz.
                else if (radioErkek.Checked == true)
                {
                    ogrenci.Cinsiyet = false;
                }
                ogrenci.TCNo = txtOgrenciTCNO.Text;

                db.Ogrenci.Add(ogrenci);
                db.SaveChanges();
                MessageBox.Show("Öğrenci başarılı bir şekilde güncellendi.");

                //Kayıt işlemi bittikten sonra tekrar DataGridView Dolduruluyor.
                dvOgrenci.DataSource = db.Ogrenci.ToList();

                cbOgrenciSec.DataSource = db.Ogrenci.ToList();
                cbOgrenciSec.ValueMember = "OgrenciId";
                cbOgrenciSec.DisplayMember = "OgnreciAdi";
            }


        }


        //Sil butonuna tıklandığında çalışacak metot
        private void btnSil_Click(object sender, EventArgs e)
        {
            //Eğer öğrenci seçilmiş ise silme işlemini gerçekleştiriyoruz,alsi takdirde uyarı vermesini söylüyoruz.

            if (OgrenciId != 0)
            {


                using (OgrenciKayitEntities db = new OgrenciKayitEntities())
                {
                    db.Ogrenci.Remove(db.Ogrenci.Find(OgrenciId));
                    db.SaveChanges();
                    dvOgrenci.DataSource = db.Ogrenci.ToList();
                    MessageBox.Show("Öğrenci başarılı bir şekilde silinmiştir.");

                    cbOgrenciSec.DataSource = db.Ogrenci.ToList();
                    cbOgrenciSec.ValueMember = "OgrenciId";
                    cbOgrenciSec.DisplayMember = "OgnreciAdi";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Öğrenci Seçiniz.");
            }



        }



        //Devamsızlık ekle butonuna basılınca çalışacak olan kod

        private void btnDevamsizlikEkle_Click(object sender, EventArgs e)
        {

            //Devamsızlık ekleme Ekdanımız.
            // Eğer Ogrenci Seçilmiş ise kaydı başlat diyoruz.




            if (cbOgrenciSec.SelectedItem != null)
            {


                using (OgrenciKayitEntities db = new OgrenciKayitEntities())
                {

                    Devamsizlik devamsizlik = new Devamsizlik();
                    devamsizlik.OgrenciId = Convert.ToInt32(cbOgrenciSec.SelectedValue.ToString());
                    devamsizlik.Gun = Convert.ToDateTime(dtTarih.Value.ToString("yyyy-dd-MMMM")); //Sadece yıl-ay-gün olacak şekilde kodluyoruz.


                    //Seçili radio buttonlara göre yapılacak işlemler ve veritabanına yazılacak metin.

                    if (rbİzinli.Checked == true)
                    {
                        devamsizlik.Durumu = "İzinli";
                    }

                    else if (rbRaporlu.Checked == true)
                    {
                        devamsizlik.Durumu = "Raporlu";
                    }

                    else if (rbGelmedi.Checked == true)
                    {
                        devamsizlik.Durumu = "Gelmedi";
                    }

                    else if (rbGeldi.Checked == true)
                    {
                        devamsizlik.Durumu = "Geldi";
                    }


                    db.Devamsizlik.Add(devamsizlik);
                    db.SaveChanges();


                    dtDevamsizlik.DataSource = db.Devamsizlik.ToList();

                    MessageBox.Show("Devamsızlık Eklendi");



                }

            }

        }


        //Devamsızlık GridView'inde içerisindeki satırlara tıkladıgnda çalışan metottur.
        //Burada değişkeni classtaki tüm metotlarda kullanabilmek için tanımlıyoruz.Çünkü bu değişkene göre kayıt silme yapılacaktır.

        int Devamsizlik = 0;

        private void dtDevamsizlik_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            Devamsizlik = Convert.ToInt32(dtDevamsizlik.Rows[e.RowIndex].Cells[0].Value.ToString());
            MessageBox.Show("Devamsızlık Seçildi. " + Devamsizlik.ToString());

        }

        //Devamsızlık Sil butonuna tıklandığında çalışacak metot.


        private void btnDevamsizliSil_Click(object sender, EventArgs e)
        {



            //Eğer Devamsızlık seçilmiş ise silme işlemini gerçekleştir diyoruz,aksi takdirde uyarı vermesini söylüyoruz.


            if (Devamsizlik != 0)
            {


                using (OgrenciKayitEntities db = new OgrenciKayitEntities())
                {
                    db.Devamsizlik.Remove(db.Devamsizlik.Find(Devamsizlik));

                    db.SaveChanges();


                    dtDevamsizlik.DataSource = db.Devamsizlik.ToList();

                    MessageBox.Show("Devamsızlık bilgisi sillindi.");

                }
            }

            else
            {

                MessageBox.Show("Lütfen Devamsızlık Bilgisi Seçiniz.");
            }


        }
    }
}