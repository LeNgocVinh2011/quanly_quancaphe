   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.AddCat   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:Cafe_manager  5   	     � WindowStyle$
  None=�5	   	    � Title$ AddCat��5
   	   $	��450��6   $	��500��6%    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��45* �6   �� 5      $	��44* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $
��100* �6   �� 5      $	��44* �6   .+�5   
   � $��60��6   $	��Top=�6   ���	#FF34268A$��0��6J   .+�5      �� $��Sitka Subheading)�6   $��Quản lý Cafe HV��66   $��Center=�6M   $��Center=�6j   $��22(�6�   
�������6�   �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5      �� -   5         ��Name$ btnMiniSize��5       � Cursor$
 Hand��5      $��0q�5      ��5   .   Z� ��6D   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6/   $��Center=�6E   5       �� 5!      -   5        $ btnMax��5!      {�.  ��6)   Z� ��6?   Z� .��5#        $ WindowMaximize=�6/   $��Center=�6E   5$      �� 5%      -   5        $ btnClose��5%   0   ��6B   Z� ��6X   Z� .��5&        $ Close=�6/   $��Center=�6<   5'      5(      5)      �� 5*   
   -   5        	 ��Name$	 lbName��5*      $��20(�6    $
��Bold"�6.   $��THÊM MỚI DANH MỤC��6@   $��1��6\   $��Center=�6i   $��Center=�6�   $��Sitka Subheading)�6�   �� 5+   
   -   5        $��editCatName��5+   �   $��2��6   $��36��6   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 TÊN DANH MỤC��6+    %  !MaterialDesignFloatingHintTextBox#��[  6Z   $��5q�6�   6�   �� 5,   
   -   5        $��editImgPath��5,   �   $��3��6   $��36��6   $
 
LINK ẢNH��6+   #��[  6V   $��5q�6�   6�   �� 5-   
   $��4��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�5.      �� -   5        $ 
btnGetLink��5.   ,   $��40��6   $��40��6    $��5q�6Y    & "MaterialDesignFloatingActionButton#��[ 6d   .��5/        $ ImageAdd=�6+   $��Center=�6;   50      �� 51      $��Thêm ảnh��6   $��Center=�6'   $��Center=�6B   $��Sitka Subheading)�6_   52      �� 54   
   -   5         ��Name$ imgPath��54      $��5��6!   �� 55   
   -	   5        $ 	btnCreate��55      $��6��6   $��Center=�61   $	��150��6L   $��THÊM DANH MỤC��6X   6p   56      57      