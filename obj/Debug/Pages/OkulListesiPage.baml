   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication1.PagesWpfApplication1.Pages  5      +    %WpfApplication1.Pages.OkulListesiPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication1.Pages     5        N� Title$  OkulListesiPage��5	      .��5      � 
����·�.+�5   
   �� .+�5      � .+�5      �  � Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 
textBlock1��5   $   $
��Wrap=�68   $��	Bölüm :��6L   $��5q�6\   �� 5      $��80��6   $��20��6*   5      5      � 5      $ 
Horizontal=�6   .+�5      �� -   5        $ 
textBlock2��5       $
��Wrap=�64   $��Prog.Türü :��6H   $��5q�6\   �� 5      $��80��6   $��20��6*   5      5      � 5      $ 
Horizontal=�6   .+�5      �� -   5        $ 
textBlock3��5       $
��Wrap=�64   $��Uni.Türü :��6H   $��5q�6[   �� 5      $��80��6   $��20��6*   5      5      � 5      $ 
Horizontal=�6   .+�5       �� -   5        $ 
textBlock4��5        $
��Wrap=�64   $��Burs Türü :��6H   $��5q�6\   �� 5!      $��80��6   $��20��6*   5"      5#      � 5$      $ 
Horizontal=�6   .+�5%      �� -   5        $ 
textBlock5��5%       $
��Wrap=�64   $��Şehir :��6H   $��5q�6X   �� 5&      $��80��6   $��20��6*   5'      5(      �� 5)      $��80��6   $��Listele��6$   $
��10,3q�66   6F   5*      &   System.Windows.Controls.DataGrid  5+      -   5          Name$ dg��5+         AutoGenerateColumns .  
����·�   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Okul Adı��6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	PompaNo+   ClipboardContentBinding 6A   Z� 6d     5.      $ Bölüm��6s    6%   �� *YakıtTürü.YakıtTürüAdı+ 6P   Z� 6s     5/      $ 	Kontenjan��6k    6%   �� *YakıtTürü.Stok+ 6H   Z� 6k     50      $
 Puan��6k    6%   �� *YakıtTürü.Stok+ 6H   Z� 6k   52      53      54      55      