   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.MainUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Cafe_manager     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStyle$
  None=�5	   	    � Title$  Trang chủ người dùng��5
   	   $	��550��6&   $	��750��63    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Icon$ assets/cafe.jpg��6   .��5      � .+�5   
   � 
�������.+�5      � $��60��6   $	��Top=�6   ���	#FF34268A.+�5      �� $��Sitka Subheading)�6   $��Cafe HV��6:   $��Center=�6I   $��Center=�6f   $��22(�6�   
�������6�   �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�68   $��Right=�6Q   .+�5      �� -   5         ��Name$ txtUserName��5       $��Sitka Subheading)�65   $��16(�6S   $��Lê Ngọc Vinh��6a   $��Center=�6u   
�������6�   '  !MaterialDesignThemes.Wpf.PopupBox  5      $��10q�6/      PlacementMode$ BottomAndAlignRightEdges=�6;      	StaysOpen .  
�������	   PopupContent.	 5      �� $	��150��6%   .+�5      �� ��5   "   �� 5   &   $��Center=�61   $��Center=�5   -   $ 
Horizontal=�5   -   $��20��5   -   .+�5   *   '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 	UserBadge=�6C   $��Center=�6T   $��Center=�6q   �� 5   *   $��Thay đổi thông tin��60   $��Sitka Subheading)�6M   $��Center=�6k   $��Center=�6�   6�   5   '   5      �� 5       ��5!   "   �� 5"   &   $��Center=�61   $��Center=�5#   -   $ 
Horizontal=�5$   -   $��20��5%   -   .+�5&   *     $
 Settings=�6C   $��Center=�6S   $��Center=�6p   �� 5'   *   $��Cài đặt��60   $��Sitka Subheading)�6B   $��Center=�6`   $��Center=�6}   6�   5(   '   5*      �� 5+      ��5,   "   �� 5-   &   $��Center=�61   $��Center=�5.   -   $ 
Horizontal=�5/   -   $��20��50   -   .+�51   *     $

 Help=�6C   $��Center=�6O   $��Center=�6l   �� 52   *   $��Giúp đỡ��60   $��Sitka Subheading)�6B   $��Center=�6`   $��Center=�6}   6�   53   '   55      �� 56      �� 57      -   5         ��Name$ btnLogoutUser��57   %   ��58   "   �� 59   &   $��Center=�61   $��Center=�5:   -   $ 
Horizontal=�5;   -   $��20��5<   -   .+�5=   *     $
 Logout=�6C   $��Center=�6Q   $��Center=�6n   �� 5>   *   $��Đăng xuất��60   $��Sitka Subheading)�6D   $��Center=�6b   $��Center=�6   6�   5?   '   5A      5B      5C      �� 5D      -   5        $ btnMiniSize��5D       � Cursor$
 Hand��5F      $��0q�5G      ��5D   2   Z� ��6H   Z� .��5I        $
 WindowMinimize=�63   $��Center=�6I   5J      �� 5K      -   5        $ btnMax��5K      {�.  ��6-   Z� ��6C   Z� .��5M        $
 WindowMaximize=�63   $��Center=�6I   5N      �� 5O      -   5        $ btnClose��5O      ��6/   Z� ��6E   Z� .��5P        $
 Close=�63   $��Center=�6@   5Q      5R      5S      5T      � 5U   
   .+�5V      �� $	��350��6   $��20q�6%   
������� �� RadiusX$ 10��6>    �� RadiusY$ 10��6K    J� Effect 5W      3  -System.Windows.Media.Effects.DropShadowEffect  5X         
BlurRadius$ 20Q�6'      ShadowDepth$ 1Q�67   5Z      � 5[      $��25q�6   $	��350��6    � ColumnDefinitions 5\      �� 5]      $	��53* �6'   �� 5^      $	��47* �6'   .+�5`      � $��35��6   $��50��6"   
����  �$
��Left=�6@   $	��Top=�6[   $��20,0,0,0q�6s    5a        5b      .+�5d        $��20��6/   $��20��6:   
�������$
 	LocalCafe=�6Y   $��5q�6j   $��Center=�6u   $��Bottom=�6�   5e      �� 5f      -   5        $ txtCafe��5f      $��Sitka Subheading)�6-   $��CAFE_HOA_VINH��6K   $��	60,28,0,0q�6`   $	��Top=�6s   $
��Left=�6�   
���   �6�   �� 5g      $��	20,55,0,0q�6   $	��Top=�60   $ 
Horizontal=�6H   .+�5h      �� $ 
Horizontal=�6"   .+�5i        $��15��63   $��15��6>   
���   �$
 Phone=�6]   $��2q�6j   �� 5j      $��Sitka Subheading)�6$   $��
0352025764��6B   $��2q�6T   
���   �6_   5k      �� 5l      $ 
Horizontal=�6!   .+�5m        $��15��63   $��15��6>   
���   �$
 AddressMarker=�6]   $��2q�6r   �� 5n      $��Sitka Subheading)�6$   $*��$565 Quang Trung Street, Dong Ve Ward��6B   $��2q�6n   
���   �6y   5o      5p      �� 5r      $*��$/assets/Capture-removebg-preview.png��6   $	��Top=�6F   $��Right=�6^   $	��120��6z   $��80��6�   $��	0,10,10,0q�6�   $��1��6�   �� 5s       �� CornerRadius$ 10��6   $	��250��6+   $��Bottom=�68   $��0,0,0,25q�6S   $��2��6e   ._�5t      �� $��HÂN HẠNH PHỤC VỤ��6   $��Sitka Subheading)�6:    5u        5v      .��5x      �� $ 
Horizontal=�6%   $��10q�6>   $��Center=�6J   .+�5y      �� $ Vertical=�6)   $	��150��6@   $��10q�6L   $��Center=�6X   $��Center=�6s   .+�5z   "   �� -   5        $ btnTable��5z   �   $��60��6)   $��60��65   $��10q�6@    !  MaterialDesignPaperDarkButton#��[  6L   
��� � �.��5{   &     $
 TableAdd=�6?   
�������$��35��6b   $��35��6m   $��Center=�6y   $��Center=�6�   5|   #   �� 5}   "   $��ĐẶT BÀN��6(     MaterialDesignLabel#��[ 6:   $��Center=�6g   $��20(�6�   ���	#FF34268A$��Sitka Subheading)�6�   $
��Bold"�6�   5~      �� 5�      $ Vertical=�6)   $	��150��6@   $��10q�6L   $��Center=�6X   $��Center=�6s   .+�5�   "   �� -   5        $ btnBill��5�   )   $��60��6P   $��60��6\   $��10q�6g   #��[  6s   
����+��.��5�   &     $
 CheckAll=�6?   
�������$��35��6b   $��35��6m   $��Center=�6y   $��Center=�6�   5�   #   �� 5�   "   $��THANH TOÁN��6(   #��[ 6=   $��Center=�6j   $��20(�6�   ���	#FF34268A$��Sitka Subheading)�6�   $
��Bold"�6�   5�      5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��Bottom=�66   $��5,0,5,5q�6Q   $��2��6b   .+�5�        $
 	Copyright=�6/   $��Center=�6@   $	��2 0q�6[   
��� � �$��10��6{   $��10��6�   �� 5�      $��Sitka Subheading)�6    $��Center=�6>   $��1 0 0 0q�6Y   $��Design by Le Ngoc Vinh��6j   
��� � �$��10(�6�   5�      5�      5�      5�      5�      