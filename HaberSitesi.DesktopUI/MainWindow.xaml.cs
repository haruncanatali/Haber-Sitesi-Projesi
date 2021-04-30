using HaberSitesi.DesktopUI.Sayfalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HaberSitesi.DesktopUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Islem_Secici_Btns(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Content)
            {
                case "Yazar İşlemleri":
                    yerlesim_frame.Navigate(new YazarPage());
                    break;
                case "Editör İşlemleri":
                    yerlesim_frame.Navigate(new EditorPage());
                    break;
                case "Yorum İşlemleri":
                    yerlesim_frame.Navigate(new YorumPage());
                    break;
            }
        }
    }
}
