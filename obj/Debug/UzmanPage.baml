   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication1.PagesWpfApplication1.Pages  5      %    WpfApplication1.Pages.UzmanPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication1.Pages     5        N� Title$  	UzmanPage��5	      .��5
      � 
����·�.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dg��5         AutoGenerateColumns .  
����·�   CanUserAddRows .  $y�Visible=�6g      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+   ClipboardContentBinding 6<   Z� 6_     5      $ 
Ogrenci Ad��6_    6%   �� *Ad+ 6<   Z� 6_     5      $ Ogrenci Soyad��6b    6%   �� *SoyAd+ 6?   Z� 6b     5      $
 Okul��6d    6%   �� *	OkulAdi+ 6A   Z� 6d     5      $ Bölüm��6e    6%   �� *
BolumAdi+ 6B   Z� 6e   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Tercihleri Görüntüle��6L      ClipboardContentBinding 6)   Z� 	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$
 	btntercih��6D   -   5        $��Tercihleri Görüntüle��5   %   $	��120��6x   5      5      5      �� 5   
   -   5         ��Name$ stackTercih��5      $y�Hidden=�6*   .+�5      � $��Center=�6   .+�5      �� -   5         ��Name$ tbOgrenciAdi��5      $	��100��60   $��30��6<    �� TextWrapping$
 Wrap=�6H   {�.  6p   �� 5      -   5        $
 buttonGoster��5      $��Yorumla��6/   $	��100��6A   $��10,10q�6M   $��30��6\   ���	#FF1E722D���	#FF020202
�������$
��Bold"�6�   6�   5         5"      -   5        $ dgTercihler��5"       .  
����·� .   5#        5$      $ 	Okul Adı��6h    6)   �� *	OkulAdi+ 6E   Z� 6h     5%      $ Bolum��6f    6)   �� *Bolum+ 6C   Z� 6f     5&      $ ProgramTuru��6l    6)   �� *ProgramTuru+ 6I   Z� 6l     5'      $ UniversiteTuru��6o    6)   �� *UniversiteTuru+ 6L   Z� 6o     5(      $ BursTuru��6i    6)   �� *
BursTuru+ 6F   Z� 6i     5)      $ Sehir��6f    6)   �� *Sehir+ 6C   Z� 6f   5+      5-      � 5.   
   -   5         �Name$ wpYorum��5.       � Orientation$ 
Horizontal=�6%   $��Bottom=�6>   $��Center=�6Y   $y�Hidden=�6v   $��10,10q�6�   .+�5/      �� -   5         ��Name$ 
textBlock1��5/      $
��Wrap=�6,   $��
Yorumunuz:��6@   $	��120��6R   $��5q�6^   � 50      $ Vertical=�6   .+�51      �� -	   5        $ tbYorum��51      $	��400��6+   $	��150��67   �� 52      -
   5        $
 buttonyorumGonder��52      $��Gönder��64   6g   53      54      55      56      