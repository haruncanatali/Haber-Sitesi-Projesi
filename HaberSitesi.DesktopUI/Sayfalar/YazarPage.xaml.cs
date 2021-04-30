using HaberSitesi.Business.FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HaberSitesi.DesktopUI.Sayfalar
{
    /// <summary>
    /// YazarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class YazarPage : Page
    {
        Yazar yazar=new Yazar();
        YazarValidator validator = new YazarValidator();
        public YazarPage()
        {
            InitializeComponent();
            GridDoldur();
        }

        private void GridDoldur()
        {
            List<Yazar> yazarlar = new List<Yazar>();
            SqlCommand komut = new SqlCommand("exec Yazar_Tablosu", SqlBaglantisi.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                yazarlar.Add(new Yazar
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    YazarAdi = okuyucu[1].ToString(),
                    YazarSoyadi = okuyucu[2].ToString(),
                    YazarBiyografisi = okuyucu[3].ToString(),
                    YazarFotoUrl = okuyucu[4].ToString()
                });
            }
            SqlBaglantisi.BaglantiDondur().Close();

            yazar_dataGrid.ItemsSource = yazarlar;
        }

        public void Temizle()
        {
            adTxt.Text = "";
            soyadTxt.Text = "";
            fotoTxt.Text = "";
            biyografiTxt.Text = "";
        }

        public void yazar_dataGrid_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {
            object item = yazar_dataGrid.SelectedItem;

            if (item != null)
            {
                yazar = new Yazar
                {
                    Id = int.Parse((yazar_dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text.ToString()),
                    YazarAdi = (yazar_dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                    YazarSoyadi = (yazar_dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                    YazarBiyografisi = (yazar_dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                    YazarFotoUrl = (yazar_dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                };
            }

            adTxt.Text = yazar.YazarAdi;
            soyadTxt.Text = yazar.YazarSoyadi;
            fotoTxt.Text = yazar.YazarFotoUrl;
            biyografiTxt.Text = yazar.YazarBiyografisi;
        }

        public void Islem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "kaydetBtn":
                    KaydetFonk();
                    break;
                case "guncelleBtn":
                    GuncelleFonk();
                    break;
                case "silBtn":
                    SilFonk();
                    break;
            }
        }

        private void SilFonk()
        {
            try
            {
                SqlCommand komut = new SqlCommand("exec Yazar_Sil @p1", SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", yazar.Id);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                MessageBox.Show("Yazar silme başarılı oldu.", "Bilgilendirme", MessageBoxButton.OK, MessageBoxImage.Information);

                Temizle();
                GridDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. =>" + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GuncelleFonk()
        {
            try
            {
                yazar.YazarAdi = adTxt.Text.ToString();
                yazar.YazarSoyadi = soyadTxt.Text.ToString();
                yazar.YazarBiyografisi = biyografiTxt.Text.ToString();
                yazar.YazarFotoUrl = fotoTxt.Text.ToString();

                ValidationTool.Validate(validator, yazar);
                SqlCommand komut = new SqlCommand("exec Yazar_Guncelle @p1,@p2,@p3,@p4,@p5", SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", yazar.Id);
                komut.Parameters.AddWithValue("@p2", yazar.YazarAdi);
                komut.Parameters.AddWithValue("@p3", yazar.YazarSoyadi);
                komut.Parameters.AddWithValue("@p4", yazar.YazarBiyografisi);
                komut.Parameters.AddWithValue("@p5", yazar.YazarFotoUrl);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                MessageBox.Show("Yazar güncelleme başarılı oldu.", "Bilgilendirme", MessageBoxButton.OK, MessageBoxImage.Information);
                Temizle();
                GridDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. =>" + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void KaydetFonk()
        {
            try
            {
                yazar.YazarAdi = adTxt.Text.ToString();
                yazar.YazarSoyadi = soyadTxt.Text.ToString();
                yazar.YazarBiyografisi = biyografiTxt.Text.ToString();
                yazar.YazarFotoUrl = fotoTxt.Text.ToString();

                ValidationTool.Validate(validator, yazar);
                SqlCommand komut = new SqlCommand("exec Yazar_Ekle @p1,@p2,@p3,@p4", SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", yazar.YazarAdi);
                komut.Parameters.AddWithValue("@p2", yazar.YazarSoyadi);
                komut.Parameters.AddWithValue("@p3", yazar.YazarBiyografisi);
                komut.Parameters.AddWithValue("@p4", yazar.YazarFotoUrl);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                MessageBox.Show("Yazar ekleme başarılı oldu.", "Bilgilendirme", MessageBoxButton.OK, MessageBoxImage.Information);
                Temizle();
                GridDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. =>" + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
