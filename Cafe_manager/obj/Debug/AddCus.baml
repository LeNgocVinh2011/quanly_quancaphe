   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.AddCus   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Cafe_manager     5   	     � WindowStyle$
  None=�5	   	    � Title$ AddCus��5
   	   $	��350��6   $	��450��6%    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��45* �6   �� 5      $	��44* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��44* �6   .+�5   
   � $��60��6   $	��Top=�6   ���	#FF34268A$��0��6J   .+�5      �� $��Sitka Subheading)�6   $��Quản lý Cafe HV��66   $��Center=�6M   $��Center=�6j   $��22(�6�   
�������6�   �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5      �� -   5         ��Name$ btnMiniSize��5       � Cursor$
 Hand��5      $��0q�5      ��5   .   Z� ��6D   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6/   $��Center=�6E   5       �� 5!      -   5        $ btnMax��5!      {�.  ��6)   Z� ��6?   Z� .��5#        $ WindowMaximize=�6/   $��Center=�6E   5$      �� 5%      -   5        $ btnClose��5%      ��6+   Z� ��6A   Z� .��5&        $ Close=�6/   $��Center=�6<   5'      5(      5)      �� 5*   
   -   5        	 ��Name$	 lbName��5*      $��20(�6    $
��Bold"�6.   $ ��THÊM MỚI NGƯỜI DÙNG��6@   $��1��6^   $��Center=�6k   $��Center=�6�   $��Sitka Subheading)�6�   �� 5+   
   -   5        $��editUsernameAdd��5+   �   $��2��6   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 EMAIL��6    %  !MaterialDesignFloatingHintTextBox#��[  6G   $��5q�6�   6�   �� 5,   
   -   5        $��editDisplayNameAdd��5,   �   $��3��6   $
 TÊN HIỂN THỊ��6   #��[  6N   $��5q�6�   6�   G� 5-   
   -   5        $��editPasswordAdd��5-   �   $��4��6   $
 MẬT KHẨU��6#    ) %MaterialDesignFloatingHintPasswordBox#��[ 6N   $��5q�6�   6�   �� 5.   
   -   5        $��editPasswordView��5.   �   $��4��6   $y�Hidden=�6   $
 MẬT KHẨU��63   #��[  6^   $��5q�6�   6�   �� 5/   
   -	   5         ��Name$ ShowPass��5/       $��5��6   $��Hiển thị mật khẩu��62   $��Sitka Subheading)�50      $��9(�51      $
��0,10q�52      54      �� 56   
   -
   5        $ 	btnCreate��56      $��6��6   $��Center=�61   $	��150��6L   $��THÊM THÔNG TIN��6X   6q   57      58      