using HaberSitesi.Business.FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// EditorPage.xaml etkileşim mantığı
    /// </summary>
    public partial class EditorPage : Page
    {
        Editor editor = new Editor();
        EditorValidator validator = new EditorValidator();

        public EditorPage()
        {
            InitializeComponent();
            GridDoldur();
        }

        private void GridDoldur()
        {
            List<Editor> editorler = new List<Editor>();
            SqlCommand komut = new SqlCommand("exec Editor_Tablosu",SqlBaglantisi.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                editorler.Add(new Editor
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    EditorAdi = okuyucu[1].ToString(),
                    EditorSoyadi = okuyucu[2].ToString()
                });
            }
            SqlBaglantisi.BaglantiDondur().Close();

            editor_dataGrid.ItemsSource = editorler;
        }

       

        public void Islem_Click(object sender,EventArgs e)
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

        private void Temizle()
        {
            adTxt.Text = "";
            soyadTxt.Text = "";
        }

        private void SilFonk()
        {
            try
            {
                SqlCommand komut = new SqlCommand("exec Editor_Sil @p1", SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", editor.Id);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                MessageBox.Show("Editor silme başarılı oldu.", "Bilgilendirme", MessageBoxButton.OK, MessageBoxImage.Information);

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

                editor.EditorAdi = adTxt.Text.ToString();
                editor.EditorSoyadi = soyadTxt.Text.ToString();

                ValidationTool.Validate(validator, editor);
                SqlCommand komut = new SqlCommand("exec Editor_Guncelle @p1,@p2,@p3", SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", editor.Id);
                komut.Parameters.AddWithValue("@p2", editor.EditorAdi);
                komut.Parameters.AddWithValue("@p3", editor.EditorSoyadi);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                MessageBox.Show("Editor güncelleme başarılı oldu.", "Bilgilendirme", MessageBoxButton.OK, MessageBoxImage.Information);
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
                Editor _editor = new Editor
                {
                    EditorAdi = adTxt.Text.ToString(),
                    EditorSoyadi = soyadTxt.Text.ToString()
                };

                ValidationTool.Validate(validator, _editor);

                SqlCommand komut = new SqlCommand("exec Editor_Ekle @p1,@p2", SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", _editor.EditorAdi);
                komut.Parameters.AddWithValue("@p2", _editor.EditorSoyadi);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                MessageBox.Show("Editor ekleme başarılı oldu.", "Bilgilendirme", MessageBoxButton.OK, MessageBoxImage.Information);
                Temizle();
                GridDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. =>" + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editor_dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = editor_dataGrid.SelectedItem;
            
            if(item != null)
            {
                editor = new Editor
                {
                    Id = int.Parse((editor_dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text.ToString()),
                    EditorAdi = (editor_dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text.ToString(),
                    EditorSoyadi = (editor_dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToString()
                };
            }

            adTxt.Text = editor.EditorAdi;
            soyadTxt.Text = editor.EditorSoyadi;
        }
    }
}
