   M S B A M L   `   `   `  ����C  ?Bank_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Bank_WPFBank_WPF  5   	        Bank_WPF.Kredit_Beantragen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Bank_WPF     5   	   -   5          �Name$  Win_KreditBeantragen��5   	    � Title$ Kredit beantragen��5   	   $	��260��6#   $	��328��60    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R   .��5	      � .+�5
   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ dp_StartDatum��5
      $
��Left=�6,   $��
20,132,0,0q�6G   $	��Top=�6[     5   
   -   5        $ dp_EndDatum��5      $
��Left=�6*   $��170,132,0,0q�6E   $	��Top=�6Z   �� 5   
   -   5         ��Name$ 
txtb_Summe��5      $��23��6&   $��	20,32,0,0q�6Y    �� TextWrapping$
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $
��Left=�6�   $	��280��6�   �� 5   
   -   5        $ 	txtb_Zins��5      $��23��6%   $��	20,82,0,0q�6X   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $
��Left=�6�   $	��280��6�   �� 5   
   -   5         ��Name$ 	lbl_Summe��5      $��Summe��6#   $
��Left=�63   $��	16,10,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $ lbl_Zins��5      $��Zinssatz��6"   $
��Left=�65   $��	16,60,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ lbl_StartDatum��5      $��Start��6(   $
��Left=�68   $��
16,110,0,0q�6S   $	��Top=�6g   �� 5   
   -	   5        $ lbl_EndDatum��5      $
��Ende��6&   $
��Left=�65   $��166,110,0,0q�6P   $	��Top=�6e   �� 5   
   -
   5         ��Name$ btn_Beantragen��5      $��
Beantragen��6)   $��115,180,0,0q�6>   $	��Top=�6S   $��30��6k   $
��Left=�6w   $��90��6�   6�   5      5      