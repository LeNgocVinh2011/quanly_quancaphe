   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.MainAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Cafe_manager     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Trang quản lý��5	   	   $	��600��6   $
��1080��6,    � WindowStartupLocation$ CenterScreen=�5
   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � Icon$ /assets/cafe.jpg��6    � WindowStyle$
 None=�68    � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value  	MenuClose��%�  &	        &	 r    �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $	 0��6'   $
 60Q�63     5      $	 0:0:0.5��6'   $	
 200Q�69   5      U� 5      $ (FrameworkElement.Width)�6,   $ GridMain��6a   .\�5        $	 0��6'   $

 1010Q�63     5      $	 0:0:0.5��6'   $	
 870Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $	 0��6'   $	
 200Q�63     5      $	 0:0:0.5��6'   $
 60Q�69   5      U� 5      $ (FrameworkElement.Width)�6,   $ GridMain��6a   .\�5        $	 0��6'   $	
 870Q�63     5      $	 0:0:0.5��6'   $

 1010Q�69   5       5!      5"       � Triggers 5$      :� 5%   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ btnOpenMenu��66   .[�5&      �� #��[  6   5'      :� 5(   
   $ ButtonBase.Click��6   $ btnCloseMenu��66   .[�5)      �� #��[ 6   5*      .��5,      � 
�������.+�5-   
   � $��60��6   $	��Top=�6   ���	#FF34268A.+�5.      �� $��Sitka Subheading)�6   $��Quản lý Cafe HV��66   $��Center=�6M   $��Center=�6j   $��22(�6�   
�������6�   �� 5/      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�50      �� -   5         ��Name$ txtUserName��50      $��Sitka Subheading)�61   $��16(�6O   $��Lê Ngọc Vinh��6]   $��Center=�6q   
�������6�   '  !MaterialDesignThemes.Wpf.PopupBox  51      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen .  
�������   PopupContent. 52      �� $	��150��6!   .+�53      �� ��54      �� 55   "   $��Center=�6-   $��Center=�56   -   $ 
Horizontal=�57   -   $��20��58   -   .+�59   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	UserBadge=�6?   $��Center=�6P   $��Center=�6m   �� 5:   &   $��Thay đổi thông tin��6,   $��Sitka Subheading)�6I   $��Center=�6g   $��Center=�6�   6�   5;   #   5=      �� 5>      ��5?      �� 5@   "   $��Center=�6-   $��Center=�5A   -   $ 
Horizontal=�5B   -   $��20��5C   -   .+�5D   &     $ Settings=�6?   $��Center=�6O   $��Center=�6l   �� 5E   &   $��Cài đặt��6,   $��Sitka Subheading)�6>   $��Center=�6\   $��Center=�6y   6�   5F   #   5H      �� 5I      ��5J      �� 5K   "   $��Center=�6-   $��Center=�5L   -   $ 
Horizontal=�5M   -   $��20��5N   -   .+�5O   &     $
 Help=�6?   $��Center=�6K   $��Center=�6h   �� 5P   &   $��Giúp đỡ��6,   $��Sitka Subheading)�6>   $��Center=�6\   $��Center=�6y   6�   5Q   #   5S      �� 5T      �� 5U      -   5         ��Name$ 	btnLogout��5U   !   ��5V      �� 5W   "   $��Center=�6-   $��Center=�5X   -   $ 
Horizontal=�5Y   -   $��20��5Z   -   .+�5[   &     $ Logout=�6?   $��Center=�6M   $��Center=�6j   �� 5\   &   $��Đăng xuất��6,   $��Sitka Subheading)�6@   $��Center=�6^   $��Center=�6{   6�   5]   #   5_      5`      5a      �� 5b      -   5        $ btnMiniSize��5b       � Cursor$
 Hand��5d      $��0q�5e      ��5b   .   Z� ��6D   Z� .��5g        $ WindowMinimize=�6/   $��Center=�6E   5h      �� 5i      -   5        $ btnMax��5i      {�.  ��6)   Z� ��6?   Z� .��5k        $ WindowMaximize=�6/   $��Center=�6E   5l      �� 5m      -   5        $ btnClose��5m      ��6+   Z� ��6A   Z� .��5n        $ Close=�6/   $��Center=�6<   5o      5p      5q      � 5r   
   -   5         �Name$ GridMenu��5r      $��60��6!   $
��Left=�6,   ���	#FF34268A.+�5s      �� .+�5t      � $	��150��6   
�������.+�5u      �� -   5        $ btnCloseMenu��5u      $��60��63   $��60��6k   $	��Top=�6w   $��Right=�6�   $y�	Collapsed=�6�   ��6>   Z� ��6T   Z� .��5v        $��25��63   $��25��6>   $ 	ArrowLeft=�6J   
���   �6[   5w      �� 5x      -   5        $ btnOpenMenu��5x      $��60��62   $��60��6j   $	��Top=�6v   $��Right=�6�   ��6=   Z� ��6S   Z� .��5y        $��25��63   $��25��6>   $
 Menu=�6J   
���   �6V   5z      �� 5{      $*��$/assets/Capture-removebg-preview.png��6   $��0,60,0,0q�6J   5|      �� 5}      -	   5         ��Name$ ListViewMenu��5}      $��Disabled=�61   .@�5~      �� -
   5         ��Name$ ItemHome��5~   #   $��60��65   
�������.��5      �� $ 
Horizontal=�6%   .+�5�        $ ViewDashboard=�67   $��25��6L   $��25��6W   $��Center=�6c   $��10q�6~   �� 5�      $��Sitka Subheading)�6(   $��Trang chủ��6F   $��Center=�6W   $��20 10q�6r   5�      5�      �� 5�      -   5        $ 	ItemStaff��5�   #   $��60��66   
�������.��5�      �� $ 
Horizontal=�6%   .+�5�        $��10q�67   $
 User=�6C   $��25��6O   $��25��6Z   $��Center=�6f   �� 5�      $��Sitka Subheading)�6(   $��Quàn lý nhân viên��6F   $��Center=�6_   $��20 10q�6z   5�      5�      �� 5�      -   5        $ ItemCus��5�   #   $��60��64   
�������.��5�      �� $ 
Horizontal=�6%   .+�5�        $��10q�67   $ CustomerService=�6C   $��25��6Z   $��25��6e   $��Center=�6q   �� 5�      $��Sitka Subheading)�6(   $��Quàn lý người dùng��6F   $��Center=�6`   $��20 10q�6{   5�      5�      �� 5�      -   5        $ ItemTab��5�   #   $��60��64   
�������.��5�      �� $ 
Horizontal=�6%   .+�5�        $��10q�67   $ Table=�6C   $��25��6P   $��25��6[   $��Center=�6g   �� 5�      $��Sitka Subheading)�6(   $��Quàn lý bàn��6F   $��Center=�6Y   $��20 10q�6t   5�      5�      �� 5�      -   5        $ ItemCat��5�   #   $��60��64   
�������.��5�      �� $ 
Horizontal=�6%   .+�5�        $��10q�67   $ PlaylistPlus=�6C   $��25��6W   $��25��6b   $��Center=�6n   �� 5�      $��Sitka Subheading)�6(   $��Quản lý danh mục��6F   $��Center=�6^   $��20 10q�6y   5�      5�      �� 5�      -   5        $ ItemPro��5�   #   $��60��64   
�������.��5�      �� $ 
Horizontal=�6%   .+�5�        $��10q�67   $ FruitCherries=�6C   $��25��6X   $��25��6c   $��Center=�6o   �� 5�      $��Sitka Subheading)�6(   $��Quản lý sản phẩm��6F   $��Center=�6^   $��20 10q�6y   5�      5�      5�      5�      5�      � 5�   
   -   5        $ GridMain��5�      $��Right=�6!   $��Bottom=�6=   $	��530��6X   $
��1010��6e   
�������6r   5�      5�      