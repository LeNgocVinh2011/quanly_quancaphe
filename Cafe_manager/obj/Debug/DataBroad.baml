   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5      b ^Syncfusion.SfChart.WPF, Version=19.3460.0.57, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts 5	          Cafe_manager.DataBroad   5      a ]Syncfusion.Shared.Wpf, Version=19.3460.0.57, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
syncfusion!http://schemas.syncfusion.com/wpf   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:Cafe_manager  5      SchartGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF  5	      .��5      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6   .+�5      �� $	��100��6   $��20q�6%   
��� ��� �� RadiusX$ 10��6?    �� RadiusY$ 10��6L    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6'      ShadowDepth$ 1Q�67   5      � 5      $��25q�6   $	��100��6   .+�5      � $��35��6   $��50��6"   
����  �$
��Left=�6@   $	��Top=�6[   $
��20 0q�6s    5        5      .+�5!      '  !MaterialDesignThemes.Wpf.PackIcon  $��20��6/   $��20��6:   
�������   Kind$ 
InfoCircle=�6Y   $��5q�6k   $��Center=�6v   $��Bottom=�6�   5"      �� 5#      $��Sitka Subheading)�6   $��5 25 5 5q�6:   $��CAFE_HOA_VINH��6L   $	��Top=�6a   $��Right=�6y   
�������6�   �� 5$      $��	10 40 0 0q�6    �� Orientation$ 
Horizontal=�60   $��Right=�6I   $��Center=�6e   .+�5%      �� $��Sitka Subheading)�6    $��	K21B CNTT��6>   $��Center=�6O   
�������$��30(�6}   �� 5&      $��Sitka Subheading)�6    $	��0 5q�6>   $��HDU SOFTWARE��6K   $��Bottom=�6_   
�������$��10(�6�   5'      �� 5(      $ 
Horizontal=�6   $��Bottom=�66   $��5q�6Q   .+�5)        $ 	Copyright=�6/   $��Center=�6@   $	��2 0q�6[   
��� � �$��10��6{   $��10��6�   �� 5*      $��Sitka Subheading)�6    $��Center=�6>   $��1 0 0 0q�6Y   $��Design by Le Ngoc Vinh��6j   
��� � �$��10(�6�   5+      5,      5-      � 5.   
   $��0��6   $��1��6   .+�5/      �� $	��100��6   $��20q�6%   
��� ���$ 10��6?   $ 10��6L    50        51      $ 20Q�6'   $ 1Q�67   53      � 54      $��25q�6   $	��100��6   .+�55      � $��35��6   $��50��6"   
��� � �$
��Left=�6A   $	��Top=�6\   $
��20 0q�6t    56        57      .+�59        $��20��6/   $��20��6:   
�������$ UserArrowLeft=�6Y   $��5q�6n   $��Center=�6y   $��Bottom=�6�   5:      �� 5;      $��Sitka Subheading)�6   $��5 25 5 5q�6:   $��KHÁCH HÀNG��6L   $	��Top=�6^   $��Right=�6v   
�������6�   �� 5<      $��	10 40 0 0q�6   $ 
Horizontal=�60   $��Right=�6I   $��Center=�6e   .+�5=      �� $��Sitka Subheading)�6    $��
20.112.000��6>   $��Center=�6P   
�������$��30(�6~   �� 5>      $��Sitka Subheading)�6    $	��0 5q�6>   $��NGƯỜI DÙNG��6K   $��Bottom=�6]   
�������$��10(�6�   5?      �� 5@      $ 
Horizontal=�6   $��Bottom=�66   $��5q�6Q   .+�5A        $ Calendar=�6/   $��Center=�6?   $	��2 0q�6Z   
��� � �$��10��6z   $��10��6�   �� 5B      $��Sitka Subheading)�6    $��Center=�6>   $��1 0 0 0q�6Y   $��Thống kê năm 2021��6j   
��� � �$��10(�6�   5C      5D      5E      � 5F   
   $��0��6   $��2��6   .+�5G      �� $	��100��6   $��20q�6%   
��� ���$ 10��6?   $ 10��6L    5H        5I      $ 20Q�6'   $ 1Q�67   5K      � 5L      $��25q�6   $	��100��6   .+�5M      � $��35��6   $��50��6"   
����+��$
��Left=�6F   $	��Top=�6a   $
��20 0q�6y    5N        5O      .+�5Q        $��20��6/   $��20��6:   
�������$ Location=�6Y   $��5q�6i   $��Center=�6t   $��Bottom=�6�   5R      �� 5S      $��Sitka Subheading)�6   $��5 25 5 5q�6:   $��ĐỊA CHỈ��6L   $	��Top=�6[   $��Right=�6s   
�������6�   �� 5T      $��	10 40 0 0q�6   $ 
Horizontal=�60   $��Right=�6I   $��Center=�6e   .+�5U      �� $��Sitka Subheading)�6    $��HỒNG ĐỨC��6>   $��Center=�6N   
�������$��30(�6|   �� 5V      $��Sitka Subheading)�6    $	��0 5q�6>   $��
UNIVERSITY��6K   $��Bottom=�6]   
�������$��10(�6�   5W      �� 5X      $ 
Horizontal=�6   $��Bottom=�66   $��5q�6Q   .+�5Y        $
 Call=�6/   $��Center=�6;   $	��2 0q�6V   
��� � �$��10��6v   $��10��6�   �� 5Z      $��Sitka Subheading)�6    $��Center=�6>   $��1 0 0 0q�6Y   $#��Điện thoại: 035.202.5764��6j   
��� � �$��10(�6�   5[      5\      5]      � 5^   
   $��1��6   $��3��6   $��0��60   $��2��6@   $��Center=�6Q   $	��600��6n   .+�5_      � $��20 50 20 20q�6   	 J� OpacityMask	 5`      !� 5a      
 !� Visual
 6"   ��  �� ElementName$ borderG1��.+�5c      �� -   5         ��Name$ borderG1��5c       �� CornerRadius$ 5��6+   
������6<   �� 5d      -   5         ��Name$ 
txtThongKe��5d      $��Sitka Subheading)�60   $��20q�6N   $��THỐNG KÊ NGÀY: ��6Z   $��Bottom=�6q   
�������$��20(�6�   5e      � 5f      $��50 20 50 80q�6   	 5g      !� 5h      
 6"   �� $ borderG2��.+�5j      �� -   5        $ borderG2��5j      $ 15��6+   ���	#FF34268A._�5k      )  #Syncfusion.UI.Xaml.Charts.SfChart3D     PrimaryAxis 5l      /  )Syncfusion.UI.Xaml.Charts.NumericalAxis3D  5m         SecondaryAxis 5o        5p         Series. 5r      .  (Syncfusion.UI.Xaml.Charts.ColumnSeries3D  /  )Syncfusion.UI.Xaml.Charts.ChartSeriesBase   XBindingPath$ 	TimeStamp��6/   .  (Syncfusion.UI.Xaml.Charts.XyDataSeries3D   YBindingPath$ 	NoOfUsers��5s      64   5t      5u      5v      5w      5x      5y      