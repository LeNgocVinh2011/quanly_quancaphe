   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.MainLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:Cafe_manager  5   	     � WindowStyle$
  None=�5   	    � Title$ Đăng nhập��5
   	   $	��500��6   $	��350��6(    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5, 0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF332888��6#   $	 0.5Q�65   5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $	��Top=�6J   .+�5      �� -   5        	 ��Name$	 btnMiniSize��5      
 � Cursor$

 Hand��5      $��0q�5      ��5   *   Z� ��6@   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6+   $��Center=�6A   5      �� 5      -   5        $	 btnMax��5      {�.  ��6%   Z� ��6;   Z� .��5!        $ WindowMaximize=�6+   $��Center=�6A   5"      �� 5#      -   5        $	 btnClose��5#      ��6'   Z� ��6=   Z� .��5$        $ Close=�6+   $��Center=�68   5%      5&      �� 5(   
   $��50q�6   $*��$/assets/Capture-removebg-preview.png��6   $	��150��6J   $��80��6V   $	��Top=�6b   �� 5)   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $
��0,80q�6U    �� RadiusY$ 33.281��6c    �� RadiusX$ 33.281��6t    J� Effect 5*      3  -System.Windows.Media.Effects.DropShadowEffect  5+         RenderingBias$ Quality=�6#      ShadowDepth$ 1Q�6;      Color$ 	#FFBBBBBB��6K      	Direction$ 0Q�6]      
BlurRadius$ 15Q�6k   5-      � 5.   
   $	��280��6   $	��240��6   $��Bottom=�6(   $
��0,80q�6C   .+�5/      �� $��Sitka Subheading)�6   $��18(�66   $��ĐĂNG NHẬP��6D   $��Center=�6U   $	��Top=�6r   $��5q�6�   
���   �6�   � 50      $��Center=�6   $��10q�6.    � RowDefinitions 51      �� 52      $��* �6$   �� 53      $��* �6$   �� 54      $��* �6$   .+�56      �� -   5        $��editUsername��56   �   $��0��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��6'    %  !MaterialDesignFloatingHintTextBox#��[  6O   $
��0,10q�6�   6�   G� 57      -   5        $��editPassword��57   �   $��1��6   $ MẬT KHẨU��6+    ) %MaterialDesignFloatingHintPasswordBox#��[ 6V   $
��0,10q�6�   6�   �� 58      -   5        $��editPasswordView��58   �   $��1��6   $y�Hidden=�6'   $ MẬT KHẨU��6;   #��[  6f   $
��0,10q�6�   6�   �� 59      -   5         ��Name$ ShowPass��59   (   $��2��6   $��Hiển thị mật khẩu��6:   $��Sitka Subheading)�5:      $��9(�5;      $
��0,10q�5<      5>      5@      5A      �� 5B   
   -   5        $	 btnLogin��5B      $��Bottom=�6#   $
��0,65q�6>   $	��150��6L   $��ĐĂNG NHẬP��6X   6l   �� 5C   
   $��3��6   $��8(�5D      $��Bottom=�5E      $
��0,45q�6/   $��Sitka Subheading)�5F      $��Center=�5G      CHƯA CÓ TÀI KHOẢN? �� 5I      -	   5         �Name$ btnRegister��5K      
���   �$
��Bold"�5J      .�5K   E   
ĐĂNG KÝ5M      5N      5O      5P      