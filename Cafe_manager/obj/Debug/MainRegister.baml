   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.MainRegister   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:Cafe_manager  5   	     � WindowStyle$
  None=�5	   	    � Title$ 
Đăng ký��5
   	   $	��500��6   $	��350��6&    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5, 0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF332888��6#   $	 0.5Q�65   5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $	��Top=�6J   .+�5      �� -   5        	 ��Name$	 btnMiniSize��5      
 � Cursor$

 Hand��5      $��0q�5      ��5   *   Z� ��6@   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6+   $��Center=�6A   5      �� 5      -   5        $	 btnMax��5      {�.  ��6%   Z� ��6;   Z� .��5!        $ WindowMaximize=�6+   $��Center=�6A   5"      �� 5#      -   5        $	 btnClose��5#      ��6'   Z� ��6=   Z� .��5$        $ Close=�6+   $��Center=�68   5%      5&      �� 5(   
   $��129,25,130,0q�6   $*��$/assets/Capture-removebg-preview.png��6&   $��55��6T   $	��Top=�6`   �� 5)   
   $	��280��6   $	��350��6    
�������$��Bottom=�6:   $
��0,55q�6U    �� RadiusY$ 33.281��6c    �� RadiusX$ 33.281��6t    J� Effect 5*      3  -System.Windows.Media.Effects.DropShadowEffect  5+         RenderingBias$ Quality=�6#      ShadowDepth$ 1Q�6;      Color$ 	#FFBBBBBB��6K      	Direction$ 0Q�6]      
BlurRadius$ 15Q�6k   5-      � 5.   
   $	��280��6   $	��350��6   $��Bottom=�6(   $
��0,55q�6C   .+�5/      �� $��Sitka Subheading)�6   $��18(�66   $��ĐĂNG KÝ TÀI KHOẢN��6D   $��Center=�6]   $	��Top=�6z   $��5q�6�   
���   �6�   � 50      $��Center=�6   $��10q�6.    � RowDefinitions 51      �� 52      $��* �6$   �� 53      $��* �6$   �� 54      $��* �6$   �� 55      $��* �6$   �� 56      $��* �6$   �� 57      $��* �6$   .+�59      �� -   5        $��editUsernameRes��59   �   $��0��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��6'    %  !MaterialDesignFloatingHintTextBox#��[  6O   $
��0,10q�6�   6�   �� 5:      -   5        $��editDisplayNameRes��5:   �   $��1��6   $ TÊN HIỂN THỊ��6'   #��[  6V   $
��0,10q�6�   6�   G� 5;      -   5        $��editPasswordRes��5;   �   $��2��6   $ MẬT KHẨU��6+    ) %MaterialDesignFloatingHintPasswordBox#��[ 6V   $
��0,10q�6�   6�   G� 5<      -   5        $��editConfirmPass��5<   �   $��3��6P   $ XÁC NHẬN MẬT KHẨU��6]   #��[ 6�   $
��0,10q�6�   6�   �� 5=      -   5        $��lbError��5A      $��4��5=      $��Right=�5>      $��Sitka Subheading)�5?      $��12(�5@      5B      5D      5E      �� 5F   
   -	   5        $	 btnLogUp��5F      $��Bottom=�6#   $
��0,40q�6>   $	��150��6L   $��
ĐĂNG KÝ��6X   6j   �� 5G   
   $��3��6   $��8(�5H      $��Bottom=�5I      $
��0,20q�6/   $��Sitka Subheading)�5J      $��Center=�5K      �� 5L      -
   5         �Name$ 	btnReturn��5N      
���  ��$
��Bold"�5M      .�5N   A   
HUỶ BỎ5P      5Q      5R      5S      