   M S B A M L   `   `   `  ����D  @WordAddIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WordAddIn	WordAddIn  5   	       WordAddIn.QWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WordAddIn     5   	     � AllowsTransparency  . 
������  � Title$ MessBox��5	   	   $	��139��6   $	��317��6&    � WindowStartupLocation$ CenterScreen=�62    � WindowStyle$
 None=�6W    � Triggers 5
      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�6&    W� From$ 0X�6J   	 W� To$ 1X�6S   	 g� Duration$	 0:0:1D�6Z   
 g� FillBehavior$
 HoldEnd=�6k   5      5      5      .��5      � .+�5   
   �� 
�������$��1q�6%   $
��Left=�69   $	��139��6T   $	��Top=�6a   $	��313��6y    �� CornerRadius$ 10��6�   $��1,0,0,0q�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF1D1A87��6#    � Offset$ 0Q�65   � 5      $ 	#FF5C59AA��6#   $ 0.991Q�65   5      ._�5      �� $,��&Сохранить изменения?��6   $
��Left=�63   $	��Top=�6N   $��	44,19,0,0q�6f   $	��225��6y   $��Century Gothic)�6�   $��18(�6�   
�������6�   5      �� 5   
   -   5         ��Name$ settings��5      $
��Да��6#   $��	22,72,0,0q�60   $	��Top=�6C   $	��127��6[   $��47��6g   $��16(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   ���	#FFD0D1E6��6s   Z� 6�   �� 5   
   -   5        $ settings_Copy��5      $��Нет��6(   $��
166,72,0,0q�66   $	��Top=�6J   $	��127��6b   $��47��6n   $��16(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   ���	#FFD7D7E6��6z   Z� 6�   5!      5"      