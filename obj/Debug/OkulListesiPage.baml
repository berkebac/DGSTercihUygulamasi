   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication1.PagesWpfApplication1.Pages  5      +    %WpfApplication1.Pages.OkulListesiPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication1.Pages     5        N� Title$  OkulListesiPage��5	      .��5      � 
����·�.+�5   
   �� .+�5      � .+�5      �  � Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 
textBlock4��5       $
��Wrap=�64   $��Burs Türü :��6H   $��5q�6\   �� 5      -   5         ��Name$ 	comboBurs��5      $��80��62   $��20��6=    �� SelectedIndex$ 0��6I   6[   5      � 5      $ 
Horizontal=�6   .+�5      �� -   5        $ 
textBlock1��5       $
��Wrap=�64   $��	Bölüm :��6H   $��5q�6X   �� 5      -   5        $ 
comboBolum��5      $��80��63   $��20��6>   $ 0��6J   6\   5      � 5      $ 
Horizontal=�6   .+�5      �� -   5        $ 
textBlock2��5       $
��Wrap=�64   $��Prog.Türü :��6H   $��5q�6\   �� 5      -   5        $ comboProgturu��5      $��80��66   $��20��6A   $ 0��6M   6_   5      � 5      $ 
Horizontal=�6   .+�5      �� -   5        $ 
textBlock3��5       $
��Wrap=�64   $��Uni.Türü :��6H   $��5q�6[   �� 5      -   5        $ comboUnituru��5      $��80��65   $��20��6@   $ 0��6L   6^   5      � 5       $ 
Horizontal=�6   .+�5!      �� -	   5        $ 
textBlock5��5!       $
��Wrap=�64   $��Şehir :��6H   $��5q�6X   �� 5"      -
   5        $ 
comboSehir��5"      $��80��63   $��20��6>   $ 0��6J   6\   5#      5$      &   System.Windows.Controls.DataGrid  5%      -   5          Name$ dg��5%      
����·�   AutoGenerateColumns .     CanUserAddRows .     Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *id+   ClipboardContentBinding 6L   Z�   5(      $	 	Okul Adı��6)   
 6;   �� *	OkulAdi+ 6W   Z�   5)      $	 Bolum��6)   
 68   �� *Bolum+ 6R   Z�   5*      $	 Program Türü��6)   
 6?   �� *ProgramTuru+ 6_   Z�   5+      $	 Universite Türü��6)   
 6B   �� *UniversiteTuru+ 6e   Z�   5,      $	 Burs Türü��6)   
 6<   �� *
BursTuru+ 6Y   Z�   5-      $	 Şehir��6)   
 68   �� *Sehir+ 6R   Z�   5.      $
	 Puan��6)   
 67   �� *Puan+ 6P   Z�   5/      $	 	Kontenjan��6)   
 6<   �� *	Kontenjan+ 6Z   Z� 4  .System.Windows.Controls.DataGridTemplateColumn  50      $	 Tercih��6P      ClipboardContentBinding 6-   Z�    CellTemplate 51      �� 52      .R�53   "   ��  ��Name$ 	btntercih��6:   -   5        $��tercih��53   )   $��60��6e   54      56      59      5:      5;      5<      