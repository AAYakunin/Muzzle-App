   M S B A M L   `   `   `  ����E  AMuzzle App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Muzzle_App
Muzzle_App  5   	       Muzzle_App.UserInfo   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Muzzle_App     5   	     � Title$,  &Информация о клиенте��5   	   $	��325��6&   $	��450��63    � 
ResizeMode$ NoResize=�6?   .��5	      � .+�5
   
   �� -   5         ��Name$ UserTabs��5
      .@�5      �� -   5         ��Name$ UserInfoTab��5      $	��210��6+   $,��&Информация о клиенте��5   F   ��5      �� 5       �� Orientation$ Vertical=�6!   $��10q�68   .+�5      �� -   5         ��Name$ 	UserPanel��5   %   $��Center=�68   .+�5      �� -   5        $ UserName��5   )   $ 
Horizontal=�6;   5      �� 5      -   5        $ 
UserGender��5   )   $ 
Horizontal=�6=   5      �� 5      -   5        $ 	UserBirth��5   )   $ 
Horizontal=�6<   5      �� 5      -   5        $ UserRegDate��5   )   $ 
Horizontal=�6>   5      �� 5      -   5        $ 	UserEmail��5   )   $ 
Horizontal=�6<   5      �� 5      -	   5        $ 	UserPhone��5   )   $ 
Horizontal=�6<   5!      5"      �� 5#      -
   5        $ UserButtons��5#   %   $ 
Horizontal=�6:   $��Center=�6S   $��Bottom=�6p   $��0, 15, 0, 0q�6�   .+�5$      �� -   5         ��Name$ UserButtonEdit��5$   %   $ ��Редактировать��6=   $��10q�6U   $��20q�6a   ���	#FFFF4A6D
�������6�   �� 5%      -   5        $ UserButtonAddVisit��5%   %   $+��%Назначить посещение��6A   $��10q�6_   $��20q�6k   ���	#FFFF4A6D
�������6�   5&      5'      5)      �� 5*      -   5        $ UserHistory��5*      $	��210��6+   $��Посещения��5+   ;   ��5,      �� 5-      -   5        $��
scrollServ��5-   #   $
��True��65   $	��780��6M   .��5.      �� -   5        $ scrollPanelServ��5.   %   50      51      53      55      56      57      