   M S B A M L   `   `   `  ����D  @WordAddIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WordAddIn	WordAddIn  5   	       WordAddIn.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WordAddIn     5   	     � Title$  
MainWindow��5   	   $��458.5��6   $	��770��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ NoResize=�6\    � WindowStyle$
 None=�6r   .��5	      � -   5         �Name$ MainGrid��5	      $��1,0,-2,0q�6L   ���	#FF363291 � ColumnDefinitions 5
   
   �� 5      $
��137* �6   �� 5      $
��634* �6    � RowDefinitions 5   
   �� 5      $
��293* �6   �� 5      $
��117* �6   �� 5      $	��40* �6   .+�5   
   �� -   5         ��Name$ TxtFile��5      $
��Left=�6#   $��23��6>   $��	14,22,0,0q�6J   $��1��6]    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��120��6�   � 5   
   $
��Left=�6   $	��458��6*   $	��Top=�67   $	��172��6O   $��3��6[   $��-3,0,0,0q�6l   $��2��6~   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FF4640BB��6#   $ 1Q�65   5      .+�5      �� $
��Left=�6   $	��175��6/   $��4,5,0,0q�6<   $	��Top=�6M   $	��165��6e   $��icons/vshe.png��6q   5      �� 5    
   -   5         ��Name$ 
sendButton��5       $��Отправить��6%   $��	0,178,0,0q�69   $	��Top=�6L   $	��167��6d   $��47��6p   $��16(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��61  ��6|   Z� 61  �� 5!   
   $
��Left=�6   $��
2,184,0,73q�6+   $��39��6?   $��icons/MAIL.png��6J   �� 5"   
   $
��Left=�6   $��36��6+   $��	1,232,0,0q�67   $	��Top=�6J   $��39��6b   $��icons/SETTINGS.png��6m   �� 5#   
   $
��Left=�6   $��36��6+   $	��Top=�67   $��39��6O   $��icons/INFO.ico��6Z   $��	0,282,0,0q�6r   $��2��6�   �� 5$   
   -   5         ��Name$ MainControl��5$      $
��Left=�6*   $��	32,19,0,6q�6E   $	��598��6X   $��3��6d   $��1��6u   
������  J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5%      V� 5&      .~�5'      �� �� 5(       �� AngleX$ 0.275Q�6$   �� 5)      T� 5*       T� X$ 0.995Q�6)   5+      .@�5-      �� $��TabItem��6   
������ $��22��6A   $	��Top=�6M   .��5.      � ���	#FFE5E5E5 5/      �� 50      $	��83* �6+   �� 51      $
��602* �6+   .+�53      � -   5        $ gridSend��53      $
��Left=�6-   $	��438��6H   $	��Top=�6U   $	��606��6m   $ 0.488,0.346&�6y   ���	#FF363291$��2��6�   $��-7,-2,-2,-4q�6�    54      �� 55      $	��40* �6/   �� 56      $	��63* �6/   �� 57      $	��26* �6/   �� 58      $	��14* �6/   �� 59      $
��463* �6/    5;      �� 5<      $
��113* �6,   �� 5=      $
��325* �6,   .+�5?      � $
��Left=�6   $	��100��6:   $��	17,35,0,0q�6G   $	��Top=�6Z   $	��100��6r   $��2��6~   $��3��6�   ��5@      �� 5A   "   $	 0.5,1&�66   $
 0.5,0&�6G   .��5B   &   � $ Black��63   $ 0Q�6A   � 5C   &   $ 	#FF421EBD��63   $ 1Q�6E   5D   #   5F      � 5G      $
��Left=�6   $	��100��6:   $��7,35,0,0q�6G   $	��Top=�6Y   $	��100��6q   $��2��6}   $��3��6�   $��2��6�   ��5H      �� 5I   "   $	 0.5,1&�66   $
 0.5,0&�6G   .��5J   &   � $ Black��63   $ 0Q�6A   � 5K   &   $ 	#FF421EBD��63   $ 1Q�6E   5L   #   .+�5N      � $
��Left=�6#   $	��100��6>   $��119,-1,-119,0q�6K   $	��Top=�6b   $	��100��6z   ��5O   "   �� 5P   &   $	 0.5,1&�6:   $
 0.5,0&�6K   .��5Q   *   � $ Black��67   $ 0Q�6E   � 5R   *   $ 	#FF421EBD��67   $ 1Q�6I   5S   '   5U      � 5V      $
��Left=�6#   $	��100��6>   $��239,0,-239,0q�6K   $	��Top=�6a   $	��100��6y   ��5W   "   �� 5X   &   $	 0.5,1&�6:   $
 0.5,0&�6K   .��5Y   *   � $ Black��67   $ 0Q�6E   � 5Z   *   $ 	#FF421EBD��67   $ 1Q�6I   5[   '   5]      � 5^      $
��Left=�6#   $	��100��6>   $��359,-1,-359,0q�6K   $	��Top=�6b   $	��100��6z   ��5_   "   �� 5`   &   $	 0.5,1&�6:   $
 0.5,0&�6K   .��5a   *   � $ Black��67   $ 0Q�6E   � 5b   *   $ 	#FF421EBD��67   $ 1Q�6I   5c   '   5e      5f      �� 5g      $
��Left=�6    $��32,28,0,321q�6;   $��69��6P   $��icons/teleg.png��6[   $��2��6t   $��2��6�   �� 5h      -   5        $ TelegramCheckButton��5h   !   $��Telegram��6>   $��
25,109,0,0q�6Q   $	��Top=�6e   $��88��6}   $��22��6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6F  $��3��6W  ��6�   Z� 6W  �� 5i      $
��Left=�6    $��
8,26,0,324q�6;   $��66��6O   $��icons/vk.png��6Z   $ 1.557,0.569&�6p   $��2��6�   $��4��6�   �� 5j      -   5        $ 	vkontakte��5j   !   $��VK��64   $��
12,111,0,0q�6A   $	��Top=�6U   $��88��6m   $��22��6x   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6*  $��3��6;  $��2��6K  ��6�   Z� 6K  �� 5k      $
��Left=�6    $��
136,36,0,8q�6;   $��57��6O   $��icons/HSE1.png��6Z   $ 0.509,0.627&�6r   $��4��6�   �� 5l      -   5        $	 hse��5l   !   $	��HSE��6.   $��115,111,0,0q�6<   $	��Top=�6Q   $��92��6i   $��22��6t   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6   $��4��61  ��6�   Z� 61  �� 5m      $
��Left=�6    $��251,31,0,324q�6;   $��64��6Q   $"��icons/Outlook_2013_23477.ico��6\   $ 1.557,0.569&�6�   $��2��6�   $��4��6�   �� 5n      $
��Left=�6    $��
371,26,0,1q�6;   $��68��6O   $��icons/Rg-icon-copie.png��6Z   $ 1.557,0.569&�6{   $��4��6�   z�5o      V� 5p   "   .~�5q   &   �� �� 5r   &   �� 5s   &    �� Angle$ -0.772Q�66   T� 5t   &   5u   #   5w      �� 5x      -	   5        $ OutLook��5x   !   $��OutLook��62   $��238,111,0,0q�6D   $	��Top=�6Y   $��88��6q   $��22��6|   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6,  $��4��6=  ��6�   Z� 6=  �� 5y      -
   5        $ ResearchGate��5y   !   $��ResearchGate��67   $��359,112,0,0q�6N   $	��Top=�6c   $��88��6{   $��22��6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6?  $��4��6P  ��6�   Z� 6P  �� 5z      -   5         ��Name$ richTextBox1��5z   &   $
��Left=�6<   $	��270��6W   $��2,49,0,0q�6d   $	��Top=�6v   $	��455��6�   $��1��6�   $��4��6�   . �5{      /� 5|      �� 5}      -   5        $ sendButton_Copy6��5}   !   $-��'Добавить изображение��6;   $��	6,129,0,0q�6Z   $	��Top=�6m   $	��139��6�   $��49��6�   $��10(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��1��6X  $��5��6e  ��6#  Z� 6e  �� 5~      -   5        $ sendButton_Copy7��5~   !   $!��Приложить файл��6;   $��5,78,0,0q�6T   $	��Top=�6f   $	��138��6~   $��49��6�   $��10(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��1��62  $��4��6?  ��6  Z� 6S  �� 5      -   5        $ sendMain��5   !   $��Отправить��63   $��	8,225,0,0q�6G   $	��Top=�6Z   $	��134��6r   $��47��6~   $��16(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��1��6=  $��4��6J  ��6�   Z� 6J  �� 5�      $i��cВыберите соцсети, в которые нужно отправить сообщение��6    $
��Left=�6`   $��2,1,0,0q�6{   $	��Top=�6�   $	��369��6�   $��Century Gothic)�6�   ���	#FFADABCB$��3��6�   $��2��6�   $��25��6  5�      5�      5�      �� 5�      $��TabItem��6   $
��Left=�6'   $��54��6B   $��	-2,-2,0,2q�6M   .��5�      � ���	#FFE5E5E5.+�5�      � -   5        $ gridSettings��5�      $
��Left=�61   $	��603��6L   ���	#FF363291$��
-3,0,-3,-3q�6o   .+�5�      � $
��Left=�6   $	��162��6:   $��346,224,0,0q�6G   $	��Top=�6\   $	��238��6t   ��5�      �� 5�   "   $	 0.5,1&�66   $
 0.5,0&�6G   .��5�   &   � $ Black��63   $ 0Q�6A   � 5�   &   $ 	#FF421EBD��63   $ 1Q�6E   5�   #   5�      � 5�      $
��Left=�6   $	��161��6:   $��
32,225,0,0q�6G   $	��Top=�6[   $	��239��6s    5�      �� 5�   "   $
��227* �63   �� 5�   "   $	��12* �63   ��5�      �� 5�   "   $	 0.5,1&�66   $
 0.5,0&�6G   .��5�   &   � $ Black��63   $ 0Q�6A   � 5�   &   $ 	#FF421EBD��63   $ 1Q�6E   5�   #   .+�5�      �� -   5        $ HSE_Settings��5�   %   $	��Top=�6;   $	��239��6S   $	��161��6_   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6  ��6l   Z� .��5�   "   ��  �� Orientation$ Vertical=�6-   $	��162��6D   .+�5�   &   �� $��icons/logo-hse-raven.png��6,   $	��156��6N   $ 
0.75,0.481&�6[   $
��Left=�6~   $	��152��6�   5�   #   5�      5�      �� 5�      $����Выберите соцсеть, для которой необходимо настроить  праметры отправки��6    $
��Left=�6p   $��66,0,0,0q�6�   $	��Top=�6�   $	��484��6�   $��Century Gothic)�6�   ���	#FFADABCB6�   � 5�      $
��Left=�6   $	��161��6:   $��
420,35,0,0q�6G   $	��Top=�6[   $	��164��6s   ��5�      �� 5�   "   $	 0.5,1&�66   $
 0.5,0&�6G   .��5�   &   � $ Black��63   $ 0Q�6A   � 5�   &   $ 	#FF421EBD��63   $ 1Q�6E   5�   #   .+�5�      �� -   5        $ VkSettingsButton��5�   %   $	��Top=�6?   $	��164��6W   $	��161��6c   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ ��6p   Z� .��5�   "   �� $ Vertical=�6-   $	��162��6D   .+�5�   &   �� $��icons/vk-icon.png��6,   $	��129��6G   $ 
0.75,0.481&�6T   $��10,0,0,0q�6w   $
��Left=�6�   $	��142��6�   5�   #   5�      �� 5�      -   5        $ button_Copy5��5�   %   $	��Top=�6;   $��60��6S   $��50��6^   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��104,-91,0,0q�6  $ 
0.925,0.25&�6%  ��6j   Z� 6%  5�      � 5�      $
��Left=�6   $	��161��6:   $��
227,33,0,0q�6G   $	��Top=�6[   $	��164��6s   ��5�      �� 5�   "   $	 0.5,1&�66   $
 0.5,0&�6G   .��5�   &   � $ Black��63   $ 0Q�6A   � 5�   &   $ 	#FF421EBD��63   $ 1Q�6E   5�   #   5�      � 5�      $
��Left=�6   $	��161��6:   $��	32,35,0,0q�6G   $	��Top=�6Z   $	��164��6r   ��5�      �� 5�   "   $	 0.5,1&�66   $
 0.5,0&�6G   .��5�   &   � $ Black��63   $ 0Q�6A   � 5�   &   $ 	#FF421EBD��63   $ 1Q�6E   5�   #   .+�5�      �� -   5        $
 _out��5�   %   $	��Top=�63   $	��163��6K   $	��161��6W   $��Century Gothic)�6z   
�������$
��Left=�6�   $��Medium"�6�   
������ ��6d   Z� .��5�   "   �� $ Vertical=�6-   $	��162��6D   .+�5�   &   �� $��icons/outlook.png��6,   $	��141��6G   $ 
0.75,0.481&�6T   $��10,0,0,0q�6w   $
��Left=�6�   $	��142��6�   5�   #   5�      5�      �� 5�      -   5        $ telegramSettings��5�   !   $��
227,33,0,0q�6;   $	��Top=�6O   $	��163��6g   $	��161��6s   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ ��6�   Z� .��5�      �� $ Vertical=�6)   $	��162��6@   .+�5�   "   �� $��icons/Telegram-icon.png��6(   $	��156��6I   $ 
0.75,0.481&�6V   $��	2,0,-18,0q�6y   $
��Left=�6�   $	��178��6�   5�      5�      �� 5�      -   5        $ 
rgSettings��5�   !   $	��Top=�65   $	��239��6M   $	��161��6Y   $��Century Gothic)�6|   
�������$
��Left=�6�   $��Medium"�6�   
������ $��346,224,0,0q�6  ��6f   Z� .��5�      �� $ Vertical=�6)   $	��162��6@   .+�5�   "   �� $��icons/Rg-icon-copie.png��6(   $	��156��6I   $ 
0.75,0.481&�6V   $
��Left=�6y   $	��152��6�   5�      5�      5�      5�      5�      �� 5�      $��TabItem��6   $
��Left=�6'   $��20��6B   $	��Top=�6N   $��54��6f   .��5�      � ���	#FF383395$��-9,0,0,0q�6.    5�      �� 5�      $	��15* �6+   �� 5�      $
��133* �6+   .+�5�      �� $��2��6#   $��14,0,0,0q�67   .��5�      �� $
��Auto��6$   $
��Wrap=�61   �� 6G   ���	#FFFBF2F2$��24(�6c   .�6r   �� $�		��6v   6�   �� 6�   ���	#FFFBF2F2$��24(�6�   .�6�   �� $#�Краткая справка��6�   6�   �� 6�   ���	#FFFBF2F2$��12(�6�   $��Segoe UI)�6
  .�6!  �� 6.  �� 64  ���	#FF28DCDC$��16(�6P  .�6_  �� $�           Общее��6c  6~  �� 6�  �� 6�  ���	#FFFBF2F2$��12(�6�  .�6�  �� $
�    ��6�  6�  �� 6�  ���	#FF28DCDC.�6�  �� $���В ваших руках программа, с помощью которой можно отправить сообщение в пять различных мест по одному лишь клику мышки.��6�  6v  �� 6|  ���	#FFFBF2F2$��12(�6�  $��Segoe UI)�6�  .�6�  �� 6�  �� 6�  ���	#FF28DCDC.�6�  �� $���Изначально необходимо зайти во вкладку "Настройки" и удостовериться, что все настроено правильно и сообщение отправится именно в те социальные медиа, в которые и должно. ��6�  6�  �� 6�  �� 6�  ���	#FF28DCDC.�6�  �� $���В основном окне размещается текст письма или новости, к нему можно приложить файл и/или изображение. Чтобы выбрать социальные медиа, в которые необходимо отправить сообщение, нужно кликнуть по соответствующей надписи, после чего она окрасится в серый цвет, это означает, что в данное место сообщение будет отправлено.��6�  6+  �� 61  �� 6=  ���	#FF28DCDC$��16(�6Y  .�6h  �� $
�    ��6l  6{  �� 6�  ���	#FFFBF2F2$��12(�6�  $��Segoe UI)�6�  .�6�  �� 6�  �� 6�  ���	#FF28DCDC$��16(�6�  .�6   �� $�   1. ��6  6  �� 6  ���	#FF28DCDC$��16(�67  .�6F  �� $�OutLook��6J  6\  �� 6b  ���	#FFFBF2F2$��12(�6~  $��Segoe UI)�6�  .�6�  �� 6�  �� 6�  ���	#FF28DCDC$��16(�6�  .�6�  �� $7�1   Для отправки сообщения в ��6�  6  �� 6  ���	#FF28DCDC$��16(�6.  .�6=  �� $�OutLook��6A  6S  �� 6Y  ���	#FF28DCDC$��16(�6u  .�6�  �� $��� необходимо в "Настройках" выбрать                 соответствующую иконку и заполнить всплывающую таблицу данными. Не обязательно заполнять в каждой строке все поля, достаточно лишь заполнить поле с адресом почты (��6�  6s  �� 6y  ���	#FF28DCDC$��16(�6�  .�6�  �� $�Email��6�  6�  �� 6�  ���	#FF28DCDC$��16(�6�  .�6�  �� $s�m), остальные ячейки предназначены лишь для Вашего удобства. ��6�  64	  �� 6:	  �� 6F	  ���	#FF28DCDC.�6c	  �� $���   Чуть ниже таблицы заполните поле с темой письма (стоит отметить, что почты сохраняются и повторном запуске программы таблица будет заполнена с прошлого раза, а тему письма нужно каждый раз писать заново).��6g	  6A
  �� 6G
  �� 6S
  ���	#FF28DCDC.�6p
  �� $�    2. ��6t
  6�
  �� 6�
  ���	#FF28DCDC.�6�
  �� $�Telegram��6�
  6�
  �� 6�
  �� 6�
  ���	#FF28DCDC.�6�
  �� $8�2    Для отправки сообщения в ��6�
  6  �� 6!  ���	#FF28DCDC.�6>  �� $�Telegram��6B  6U  �� 6[  ���	#FF28DCDC.�6x  �� $1�+ канал необходимо бота @��6|  6�  �� 6�  ���	#FF28DCDC.�6�  �� $�
LinaLinBot��6�  6�  �� 6�  ���	#FF28DCDC.�6�  �� $��� сделать администратором своего канала, после чего в "Настройках" выбрать                 соответствующую иконку и вписать имя канала, на котором необходимо размещать новости.��6  6�  �� 6�  �� 6�  ���	#FF28DCDC.�6�  �� $�    3. ВКонтакте��6�  6  �� 6  �� 6&  ���	#FF28DCDC.�6C  �� $
�    ��6G  6V  �� 6\  ���	#FF28DCDC.�6y  �� $�a��6}  6�  �� 6�  ���	#FF28DCDC.�6�  �� $���) Если программа была запущена в первый раз, нужно зайти в настройки, выбрать иконку ВК, во всплывающем окне кликнуть на вкладку "В первый раз". Заполнить все поля, которые предлагаются, и кликнуть на кнопку "Регистрация"��6�  6�  �� 6�  �� 6�  ���	#FF28DCDC.�6�  �� $���ВНИМАНИЕ! Программа не хранит Ваши логин и пароль. Эти данные нужны для разового использования.��6�  6I  �� 6O  �� 6[  ���	#FF28DCDC.�6x  �� $
�    ��6|  6�  �� 6�  ���	#FF28DCDC.�6�  �� $�b��6�  6�  �� 6�  ���	#FF28DCDC.�6�  �� $���) После того, как регистрация прошла успешно(программа Вас об этом уведомит), нужно перейти во вкладку "Не в первый раз" и либо выбрать дату и время размещения поста, либо поставить галочку на "Опубликовать в ближайшее доступное время", тогда программа опубликует новость в группу в ближайшее доступное время(в ВК можно публиковать новость только в определенное время).��6�  6u  �� 6{  �� 6�  ���	#FF28DCDC.�6�  �� $���Если вы хотите поменять группу для публикации, то необходимо проделать операцию, описанную под пунктом ��6�  6  �� 6   ���	#FF28DCDC.�6=  �� $�a��6A  6M  �� 6S  ���	#FF28DCDC.�6p  �� $�) повторно.��6t  6�  �� 6�  �� 6�  ���	#FF28DCDC$��16(�6�  $��Segoe UI)�6�  .�6�  �� $�     4. ��6�  6�  �� 6�  �� 6  6  5�      5�      5�      �� 5�      $��TabItem��6   $
��Left=�6'   $��20��6B   $	��Top=�6N   $��54��6f   .��5�      � ���	#FFE5E5E5.+�5�      �� $
��Left=�6   $	��415��67   $	��Top=�6D   $	��624��6\   $+��%images/12695398_images_2409224177.jpg��6h   $��-13,0,-19,-10q�6�   5�      5�      5�      �� 5�   
   -   5        $
 info��5�      $��Инфо��6   $��	2,273,0,0q�6.   $	��Top=�6A   $	��167��6Y   $��47��6e   $��16(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6$  $��2��68  ��6q   Z� 68  �� 5�   
   -   5        $ settings��5�      $��Настройки��6#   $��	2,225,0,0q�67   $	��Top=�6J   $	��167��6b   $��47��6n   $��16(�6�   $��Century Gothic)�6�   
�������$
��Left=�6�   $��Medium"�6�   
������ $��2��6)  ��6z   Z� 6)  � 5�   
   $
��Left=�6   $��25��6*   $��	25,0,-1,0q�66   $	��Top=�6I   $	��610��6a   $��1��6m   ��5�      �� 5�      $	 0.5,1&�6&   $
 0.5,0&�67   .��5�      � $ Black��6#   $ 0Q�61   � 5�      $ Black��6#   $ 1Q�61   5�       5�      �� 5�      $
��339* �6#   �� 5�      $
��307* �6#   5�      �� 5�   
   -   5        $
 exit��5�      $��1��6   
������ $
��Left=�6I   $��
601,-5,0,0q�6d   $	��Top=�6x   $��31��6�   $��32��6�   ��6�   Z� .��5�      �� $ Vertical=�6   $��29��60   $��26��6;   .+�5�      �� $(��"icons/icons8-удалить-64.png��6   $��28��6=   $ 0.5,0.5&�6I   5�      5�      5�      5�      