   M S B A M L   `   `   `  ����D  @WordAddIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WordAddIn	WordAddIn  5   	       WordAddIn.WindowTelegram   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WordAddIn     5   	     � Title$  WindowTelegram��5   	   $	��266��6    $	��368��6-    � WindowStyle$
 None=�69    � 
ResizeMode$ NoResize=�6L    � WindowStartupLocation$ CenterScreen=�6b   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��197* �6   �� 5      $	��29* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF0A0832��6    � Offset$ 0Q�61   � 5      $ 	#FF322E85��6   $ 1Q�61   � 5      $ 	#FFC3C2E8��6   $ 0.111Q�61   � 5      $ 	#FFC3C2E8��6   $ 0.111Q�61   5      .+�5   
   �� $
��Left=�6   $��
144,33,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��Century Gothic)�6o   ���	#FF132E68$��35��6�   $	��185��6�   �� 6�   $2�,Введите название канала��6�   �� 6�   �� 6�   $�в формате ��6�   �� 6  $�@voronenokhse��6  6   � 5   
   -   5        $
��Left=�5      $��18��6*   $	��Top=�66   $	��368��6N   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ 	#FFAEADDA��6#   $ 1Q�65   5      .+�5      �� -   5        	 ��Name$	 	exit_Copy��5      
������ $
��Left=�6B   $��334,-5,0,-3q�6]   $	��Top=�6r   $��31��6�   $��26��6�   ��6�   Z� .��5      �� 
 �� Orientation$
 Vertical=�6   $��29��64   $��19��6?   .+�5       �� $(��"icons/icons8-удалить-64.png��6   $��20��6A    J� RenderTransformOrigin$ 0.5,0.5&�6M   $��4,0,-4,0q�6m   5!      5"      5#      �� 5$   
   $
��Left=�6   $��
18,18,0,92q�6+   $��69��6?   $��icons/teleg.png��6J   �� 5%   
   -   5         ��Name$ nameCha��5%      $
��Left=�6#   $��23��6>   $��	99,70,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��255��6�   
���������6�   Z� 6�   �� 5&   
   $
��Left=�6   $��	99,98,0,0q�6+   $	��259��6>   $��Images/profil.png��6J   $��2��6e   �� 5'   
   -   5        $��Сохранить��5'      $
��Left=�6%   $��	9,152,0,0q�6@   $	��Top=�6S   $��86��6k   ���	#FF132E68��6v   Z� 6�   5)      5*      