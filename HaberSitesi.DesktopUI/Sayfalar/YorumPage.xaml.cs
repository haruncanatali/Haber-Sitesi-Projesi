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
    /// YorumPage.xaml etkileşim mantığı
    /// </summary>
    public partial class YorumPage : Page
    {
        Yorum yorum = new Yorum();
        public YorumPage()
        {
            InitializeComponent();
            GridDoldur();
        }

        private void yorum_dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = yorum_dataGrid.SelectedItem;

            if (item != null)
            {
                yorum = new Yorum
                {
                    Id = int.Parse((yorum_dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text.ToString()),
                    Ad = (yorum_dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                    Soyad = (yorum_dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                    Mesaj = (yorum_dataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                    YorumTarihi = DateTime.Parse((yorum_dataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text.ToString())
                };
            }
        }
        public void Islem_Click(object sender,EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("exec Yorum_Sil @p1", SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", yorum.Id);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                MessageBox.Show("Yorum silme başarılı oldu.", "Bilgilendirme", MessageBoxButton.OK, MessageBoxImage.Information);

                GridDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. =>" + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GridDoldur()
        {
            List<Yorum> yorumlar = new List<Yorum>();
            SqlCommand komut = new SqlCommand("exec Yorumlar_Tablosu", SqlBaglantisi.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                yorumlar.Add(new Yorum
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    Ad = okuyucu[1].ToString(),
                    Soyad = okuyucu[2].ToString(),
                    Mesaj = okuyucu[3].ToString(),
                    YorumTarihi = DateTime.Parse(okuyucu[4].ToString())
                });
            }
            SqlBaglantisi.BaglantiDondur().Close();

            yorum_dataGrid.ItemsSource = yorumlar;
        }
    }
}
