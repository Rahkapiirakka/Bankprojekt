   M S B A M L   `   `   `  ����C  ?Bank_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Bank_WPFBank_WPF  5   	   Q MBank_Klassenbibliothek, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_Dclr-namespace:Bank_Klassenbibliothek;assembly=Bank_KlassenbibliothekBank_Klassenbibliothek 5   	   %    Bank_WPF.Auswahl_Kunden_Berater   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Bank_WPF     5   	   gBank_KlassenbibliothekDclr-namespace:Bank_Klassenbibliothek;assembly=Bank_Klassenbibliothek     5   	   -   5          �Name$  Win_Kundenübersicht��5   m    � Title$ Kundenauswahl��5	   	   $	��400��6   $	��600��6/   $	��600��6>    � WindowStartupLocation$ CenterScreen=�6J   .��5
      � .+�5   
   �� $��
10,5,10,10q�6   .@�5      �� -   5         ��Name$ tab_Privatkunde��5      $��Privatkunde��6/   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $	��10* �6+   �� 5      $
��203* �6+   �� 5      $	��11* �6+   �� 5      $
��342* �6+   .+�5      �� -   5         ��Name$ List_Berater��5      $��
0,30,10,50q�64   $��1��6H   ��5      �� 5      .R�5   "   � $	��0,2q�6'    5   &   �� 5   *   $
��Auto �6;   �� 5   *   $
��Auto �6;   .+�5   &   �� $��0,0,3,0q�60   ��6A   �� *	Vorname+�� 5   &   $��0,0,3,0q�60   $��1��6W   ��6A   �� *Name+6W   5   #   5      5!      &   System.Windows.Controls.DataGrid  5"      -   5          Name$ List_Kunden��5"      $��3��64      	RowHeight$ 20Q�6D      
IsReadOnly . 	   HeadersVisibility$	 Column=�6e   $��
0,30,10,50q�6�   
   AutoGenerateColumns
 .  $��Stretch=�6�      GridLinesVisibility$
 None=�6�      SelectionMode$ Single=�6�   $��Stretch=�62   � 	Resources 5#       �� Color*  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value��%�   (��       5$   .   *1/SystemColors.InactiveSelectionHighlightBrushKey+)'       �� 6   $ DarkGray��6q   �� 5%      "  6$   .�5&   "   ��  � ��$ 0q�6D   �� 5'   "    �@�FocusVisualStyle 6E   Z� 5(      5)         Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 61      Header$ Nr��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *Kundennummer+  5,      $ * 61   $ Vorname��6;    6L   �� *	Vorname+  5-      $ * 61   $ Nachname��6;    6M   �� *Name+5/      �� 50      -   5         ��Name$ btn_NeuerBerater��50      $��Neuer Berater��67   $��1��6O   $
��Left=�6_   $��0,0,0,10q�6z   $��90��6�   $��30��6�   $��Bottom=�6�   6�   �� 51      -   5        $ btn_NeuerKunde��51      $��Neuer Kunde��65   $��3��6K   $
��Left=�6[   $��0,0,0,10q�6v   $��95��6�   $��30��6�   $��Bottom=�6�   6�   �� 52      -   5        $ btn_Kundebearbeiten��52      $��Kunde bearbeiten��6:   $��3��6U   $��
215,0,0,10q�6e   $��30��6y   $��Bottom=�6�   $
��Left=�6�   $	��110��6�   6�   �� 53      -   5        $ btn_KundeLöschen��53      $��Kunde löschen��67   $��3��6O   $��
105,0,0,10q�6_   $��30��6s   $��Bottom=�6   $
��Left=�6�   $	��100��6�   6�   �� 54      -	   5         ��Name$ lbl_Beraterauswählen��54      $��Berater auswählen��6:   $��1��6V   $
��Left=�6f   $��0,5,0,0q�6�   $	��Top=�6�   $��26��6�   $	��107��6�   �� 55      -
   5        $ lbl_Kundeauswählen��55      $��Kunde auswählen��68   $��3��6R   $
��Left=�6b   $��0,5,0,0q�6}   $	��Top=�6�   $��26��6�   $	��102��6�   56      57      �� 58      -   5        $ tab_Geschäftskunde��58      $��Geschäftskunde��62   .��59      � ���	#FFE5E5E5 5:      �� 5;      $	��10* �6+   �� 5<      $
��203* �6+   �� 5=      $	��11* �6+   �� 5>      $
��342* �6+   .+�5@      �� -   5        $ List_GBerater��5@      $��
0,30,10,50q�65   $��1��6I   ��5A      �� 5B      .R�5C   "   � $	��0,2q�6'    5D   &   �� 5E   *   $
��Auto �6;   �� 5F   *   $
��Auto �6;   .+�5H   &   �� $��0,0,3,0q�60   ��6A   �� *	Vorname+�� 5I   &   $��0,0,3,0q�60   $��1��6W   ��6A   �� *Name+6W   5J   #   5K      5M      �� 5N      -   5        $ btn_NeuerGBerater��5N      $��Neuer Berater��68   $��1��6P   $
��Left=�6`   $��0,0,0,10q�6{   $��90��6�   $��30��6�   $��Bottom=�6�   6�   �� 5O      -   5        $ btn_NeuerGKunde��5O      $��Neuer Kunde��66   $��3��6L   $
��Left=�6\   $��0,0,0,10q�6w   $��95��6�   $��30��6�   $��Bottom=�6�   6�   �� 5P      -   5        $ btn_GKundeLöschen��5P      $��Kunde löschen��68   $��3��6P   $
��Left=�6`   $��
105,0,0,10q�6{   $	��100��6�   $��30��6�   $��Bottom=�6�   6�   �� 5Q      -   5        $ btn_GKundebearbeiten��5Q      $��Kunde bearbeiten��6;   $��3��6V   $��
215,0,0,10q�6f   $��30��6z   $��Bottom=�6�   $
��Left=�6�   $	��110��6�   6�   �� 5R      -   5        $ lbl_GBeraterauswählen��5R      $(��"Geschäftskundenberater auswählen��6;   $��1��6f   $
��Left=�6v   $��0,5,0,0q�6�   $	��Top=�6�   $��26��6�   $	��200��6�   �� 5S      -   5        $ lbl_GKundeauswählen��5S      $ ��Geschäftskunde auswählen��69   $��3��6\   $
��Left=�6l   $��0,5,0,0q�6�   $	��Top=�6�   $��26��6�   $	��172��6�     5T      -   5        $ List_GKunden��5T      $��3��65   $ 20Q�6E    . $	 Column=�6f   $��
0,30,10,50q�6�   
 .  $��Stretch=�6�   $
 None=�6�   $ Single=�6�    5U      ��%�   (��       5V   .   *1/SystemColors.InactiveSelectionHighlightBrushKey+)'       �� 6   $ DarkGray��6q   �� 5W      "  6$   .�5X   "   ��  � ��$ 0q�6D   �� 5Y   "    �@�FocusVisualStyle 6E   Z� 5Z      5[       5\        5]      $ 40 61   $ Nr��6<    6H   �� *Kundennummer+  5^      $ * 61   $ Vorname��6;    6L   �� *	Vorname+  5_      $ * 61   $ Nachname��6;    6M   �� *Name+4  .System.Windows.Controls.DataGridCheckBoxColumn  5`      $ * 65   $ Bonität��6?    6P   �� *
Bonität+5b      5c      5d      5e      5f      5g      