   M S B A M L   `   `   `  ����P  LHaberSitesi.DesktopUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:HaberSitesi.DesktopUI.SayfalarHaberSitesi.DesktopUI.Sayfalar  5      .    (HaberSitesi.DesktopUI.Sayfalar.YazarPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:HaberSitesi.DesktopUI.Sayfalar     5        N� 
Background  �#30336b N� Title$ 	YazarPage��5	      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $ Vertical=�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ yazar_dataGrid��5   $   $	��200��6   6q   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� $��
Yazar Adı��6   
�������$
��Bold"�6;   $
��15px(�6M   $��10,5,0,0q�6]   6q   �� 5      $��Yazar Soyadı��6   
�������$
��Bold"�6>   $
��15px(�6P   $��70,5,0,0q�6`   6t   �� 5      $��Yazar Fotoğrafı��6   
�������$
��Bold"�6A   $
��15px(�6S   $��70,5,0,0q�6c   6w   �� 5      $��Yazar Biyografisi��6   
�������$
��Bold"�6C   $
��15px(�6U   $��70,5,0,0q�6e   6y   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ adTxt��5      $	��100��6'   $��25��63   
�������$��10,5,0,0q�6R   6f   �� 5      -   5        $ soyadTxt��5      $	��100��6*   $��25��66   
�������$��45,5,0,0q�6U   6i   �� 5      -   5        $ fotoTxt��5      $	��100��6)   $��25��65   
�������$��70,5,0,0q�6T   6h   �� 5      -   5        $ biyografiTxt��5      $	��100��6.   $��25��6:   
�������$��88,5,0,0q�6Y   6m   5      �� 5   
   $ 
Horizontal=�6   $��0,50,0,0q�6.   $��Center=�6@   .+�5      �� -   5         ��Name$ 	kaydetBtn��5   )   $��100px��6<   $
��30px��6J   $��10,0,0,0q�6X   $��Kaydet��6j   6}   �� 5      -   5        $ guncelleBtn��5   )   $��100px��6>   $
��30px��6L   $��10,0,0,0q�6Z   $��	Güncelle��6l   6�   �� 5      -   5        $ silBtn��5   )   $��100px��69   $
��30px��6G   $��10,0,0,0q�6U   $	��Sil��6g   6w   5      5       5!      