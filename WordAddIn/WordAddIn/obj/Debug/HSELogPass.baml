   M S B A M L   `   `   `  ����D  @WordAddIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WordAddIn	WordAddIn  5   	       WordAddIn.HSELogPass   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WordAddIn     5   	     � Title$  
HSELogPass��5   	   $	��244��6   $��476.5��6)    � WindowStyle$
 None=�67    � 
ResizeMode$ NoResize=�6J    � WindowStartupLocation$ CenterScreen=�6`   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFA0A0CF��6    � Offset$ 0.011Q�61   � 5      $ 	#FF1D1A87��6   $ 0.989Q�61   5      .+�5   
   � $
��Left=�6   $��28��6*   $	��Top=�66   $	��476��6N   $��0,-2,0,0q�6Z   .+�5      �� -   5         ��Name$
 exit��5      
������ $
��Left=�6=   $��	443,0,0,0q�6X   $	��Top=�6k   $��31��6�   $��28��6�   ��6�   Z� .��5      �� 	 �� Orientation$	 Vertical=�6   $��29��64   $��26��6?   .+�5      �� $(��"icons/icons8-удалить-64.png��6   $��27��6A   
 J� RenderTransformOrigin$
 0.5,0.5&�6M   5      5      ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF9897B9��6#   $ 0Q�65   � 5      $ 	#FF1D1A87��6#   $ 0.989Q�65   5      5      �� 5   
   -   5         ��Name$ loginHSE��5      $
��Left=�6$   $��24��6?   $��
176,72,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��282��6�   
������� �� SelectionBrush �	#FFF7F7F7
���������6�   Z� 6�   �� 5   
   $��
Логин��6   $
��Left=�6    $	��Top=�6;   $	��282��6S   $��Century Gothic)�6_   ���	#FF002059$��36��6�   $��
176,36,0,0q�6�   $��14(�6�   �� 5   
   $��Пароль��6   $
��Left=�6!   $	��Top=�6<   $	��290��6T   $��Century Gothic)�6`   
�������$��35��6�   $��176,102,0,0q�6�   $��14(�6�   �� 5    
   -   5        $ passwordHse��5       $
��Left=�6'   $��26��6B   $��176,142,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��282��6�   
������� �	#FFF7F7F7
���������6�   Z� 6�   �� 5!   
   $��20,50,320,46q�6   $��icons/Image1.png��6&   $
��Fill=�6@   �� 5"   
   -   5        $��Сохранить��5"      $
��Left=�6%   $��232,188,0,0q�6@   $	��Top=�6U   $	��150��6m   
�������$��36��6�   $��14(�6�   $��Century Gothic)�6�   ��6y   Z� 6�   5$      5%      