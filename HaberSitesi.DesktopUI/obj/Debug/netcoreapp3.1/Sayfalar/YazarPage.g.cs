#pragma checksum "..\..\..\..\Sayfalar\YazarPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "231A9700895B994AA6BE869FCD37D4029CEF3046"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using HaberSitesi.DesktopUI.Sayfalar;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace HaberSitesi.DesktopUI.Sayfalar {
    
    
    /// <summary>
    /// YazarPage
    /// </summary>
    public partial class YazarPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid yazar_dataGrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock adTxt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock soyadTxt;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fotoTxt;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock biyografiTxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button kaydetBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button guncelleBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Sayfalar\YazarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button silBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HaberSitesi.DesktopUI;component/sayfalar/yazarpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Sayfalar\YazarPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.yazar_dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\..\..\Sayfalar\YazarPage.xaml"
            this.yazar_dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.yazar_dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.adTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.soyadTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.fotoTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.biyografiTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.kaydetBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Sayfalar\YazarPage.xaml"
            this.kaydetBtn.Click += new System.Windows.RoutedEventHandler(this.Islem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.guncelleBtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Sayfalar\YazarPage.xaml"
            this.guncelleBtn.Click += new System.Windows.RoutedEventHandler(this.Islem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.silBtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Sayfalar\YazarPage.xaml"
            this.silBtn.Click += new System.Windows.RoutedEventHandler(this.Islem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

