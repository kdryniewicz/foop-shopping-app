   M S B A M L   `   `   `  ����G  CShoppingCart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ShoppingCartShoppingCart  5   	       ShoppingCart.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ShoppingCart     5   	   -   5          �Name$  frmShoppingCart��5   	    � Title$ Shopping Cart��5   	   $	��408��6   $��731.5��6,    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P   .��5	      � $	��319��6   $��1,0,0,0q�6   .+�5
   
   �� -   5         ��Name$ label��5
      $
��Left=�6   $��85,6,0,0q�6:   $	��Top=�6L   $	��120��6d   .��5      �� -   5        $ labelProducts��5      $��	Products:��6+   $
��Bold"�6?   $��21.333(�6Q   $	��110��6c   5      �� 5   
   -   5         ��Name$ listBoxProducts��5      $
��Left=�6+   $	��176��6F   $��	12,85,0,0q�6S   $	��Top=�6f   $	��298��6~   �� 5   
   -   5        $ 	labelCart��5      $
��Cart��6#   $
��Left=�62   $��
517,16,0,0q�6M   $	��Top=�6a   $��21.333(�6y   $��43��6�   $��60��6�   $
��Bold"�6�   �� 5   
   -   5        $ listBoxCart��5      $
��Left=�6'   $	��176��6B   $��
423,85,0,0q�6O   $	��Top=�6c   $	��292��6{   �� 5   
   -   5         ��Name$ 	btnAddTax��5      $��Add Tax��6$   $
��Left=�66   $��
32,272,0,0q�6Q   $	��Top=�6e   $��58��6}   6�   �� 5   
   -   5        $ btnExit��5      $
��Exit��6"   $
��Left=�61   $��234,272,0,0q�6L   $	��Top=�6a   $��48��6y    J� RenderTransformOrigin$ 
0.46,0.875&�6�    �� IsCancel . 6�   �� 5   
   -	   5        $ btnAddToCart��5      $��Add To Cart��6'   $
��Left=�6=   $��324,116,0,0q�6X   $	��Top=�6m   $��84��6�   $��23��6�   6�   �� 5   
   -
   5        $ btnRemoveFromCart��5      $��Remove
From Cart��6,   $
��Left=�6P   $��324,167,0,0q�6k   $	��Top=�6�   $��84��6�   $��40��6�   6�   �� 5   
   -   5        $ 
labelTotal��5      $��Total Costs:��6$   $
��Left=�6;   $��383,272,0,0q�6V   $	��Top=�6k   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ totalAmount��5      $�� ��6%   $
��Left=�60   $��573,277,0,0q�6K   $	��Top=�6`   $��80��6x   �� 5   
   -   5        	 ��Name$	 comboBoxBikeType��5      $
��Left=�6-   $��
134,54,0,0q�6H   $	��Top=�6\   $	��120��6t   6�   �� 5   
   -   5        $ labelBikeType��5      $��
Bike Type:��6'   $
��Left=�6<   $��	50,54,0,0q�6W   $	��Top=�6j   $��79��6�   $
��Bold"�6�   5      5      