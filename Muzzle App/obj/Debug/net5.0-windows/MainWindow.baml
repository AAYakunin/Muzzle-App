   M S B A M L   `   `   `  ����E  AMuzzle App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Muzzle_App
Muzzle_App  5   	       Muzzle_App.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Muzzle_App     5   	     � Title$  
Muzzle App��5   	   $	��800��6   $
��1300��6*    � 
ResizeMode$ NoResize=�67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��321* �6   �� 5      $
��979* �6   .+�5   
   �� -   5         ��Name$ 	LeftPanel��5      ���	#FFFFE4FF.+�5      �� -   5         ��Name$ 
VisitCheck��5      $��Посещение��6)   $��25, 30, 25, 25q�6=   $��30q�6U   ���	#FFFF4A6D
�������6�   �� 5      -   5        $ AddUser��5      $��Новый клиент��6&   $��25, 25, 25, 25q�6=   $��30q�6U   ���	#FFFF4A6D
�������6�   �� 5      -   5        $ 
UpdateList��5      $��Обновить��6*   $��25, 400, 25, 0q�6=   $��30q�6U   ���	#FFFF4A6D
�������6�   5      �� 5   
   -   5        $ 
RightPanel��5      $��1��6)   .+�5      �� -   5         ��Name$
 Tabs��5      .@�5      �� -   5         ��Name$
 Tab1��5      $	��300��6(   ��5      �� 5      Список клиентов65   ��5      �� 5      -   5        $��scroll��5   '   $
��True��65   $	��780��6M   .��5      �� -	   5        $ scrollPanel��5   )   5       5!      5#      5%      5&      5(      5)      