   M S B A M L   `   `   `  ����G  CAssignment 6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Assignment_6Assignment_6  5   	       Assignment_6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Assignment_6     5   	     � Title$  Customer Registry��5   	   $	��600��6#   $	��800��60   .��5	   
   � .+�5
   
   �� -   5         ��Name$ LabelID��5
      $��ID��6!   $
��Left=�6.   $��	10,35,0,0q�6I   $	��Top=�6\   �� 5   
   -   5        $ 	LabelName��5      $
��Name��6#   $
��Left=�62   $��	71,35,0,0q�6M   $	��Top=�6`   �� 5   
   -   5        $ LabelAdress��5      $%��Street, zip code, city, country��6%   $
��Left=�6O   $��
153,35,0,0q�6j   $	��Top=�6~   �� 5   
   -   5        $ 
LabelPhone��5      $��Office and Home phone��6$   $
��Left=�6D   $��
474,35,0,0q�6_   $	��Top=�6s   �� 5   
   -   5        $ 
LabelEmail��5      $��E-mail��6$   $
��Left=�65   $��
670,35,0,0q�6P   $	��Top=�6d   �� 5   
   -   5         ��Name$ ListBoxContent��5      $
��Left=�6K   $	��388��6f   $��	10,66,0,0q�6s   $	��Top=�6�   $	��772��6�   ��6*   �� *
GetInfo/+��5      �� 5      .R�5      �� .+�5      �� ��6$   ��  �� Path$ id��� 5      ��6$   �� $ CustomerContact.FullName��� 5      ��6$   �� $ CustomerContact.Caddress��� 5      ��6$   �� $ CustomerContact.Cemail�5      5      5      �� 5)   
   -   5         ��Name$ BtnAdd��5)      $	��Add��68   $
��Left=�6F   $��190,500,0,0q�6a   $	��Top=�6v   $��75��6�   �� 5*   
   -   5        $ 	BtnChange��5*      $��Change��6$   $
��Left=�65   $��353,500,0,0q�6P   $	��Top=�6e   $��75��6}   �� 5+   
   -	   5        $ 	BtnDelete��5+      $��Delete��6$   $
��Left=�65   $��536,500,0,0q�6P   $	��Top=�6e   $��75��6}   5-      5.      