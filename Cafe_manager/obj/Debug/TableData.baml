   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.TableData   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Cafe_manager     5   	     � WindowStyle$
  None=�5	   	    � Title$ Table��5
   	   $	��550��6   $	��750��6$    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � 
�������.+�5   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6-   $��Right=�6F   .+�5      �� -   5         ��Name$ btnMiniSize��5       � Cursor$
 Hand��5      $��0q�5      ��5   *   Z� ��6@   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6+   $��Center=�6A   
���   �6\   5      �� 5      -   5        $ btnMax��5      {�.  ��6%   Z� ��6;   Z� .��5        $ WindowMaximize=�6+   $��Center=�6A   
���   �6\   5      �� 5      -   5        $ btnClose��5      ��6'   Z� ��6=   Z� .��5        $ Close=�6+   $��Center=�68   
���   �6S   5      5      � 5   
   $	��520��6   $��20q�6   .+�5      �� $	��500��6   $��10q�6%   
������� �� RadiusX$ 10��6>   	 �� RadiusY$	 10��6K   
 J� Effect
 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         
BlurRadius$ 20Q�6'      ShadowDepth$ 1Q�67   5#      �� 5$      $*��$/assets/Capture-removebg-preview.png��6   $	��Top=�6B   $��Center=�6Z   $	��100��6w   $��60��6�   $��0,15,0,0q�6�   �� 5%      -   5         ��Name$ grbData��5%      $��Sitka Subheading)�6(   $��
10,0,10,40q�6F   $��CHỌN BÀN��6Z   $	��420��6l   $��Bottom=�6y   .��5&      �� -   5        $��lstBox��5&      $
��Left=�6(   $��Center=�6C   $	��160��6^   ��5(      �� 5)      .R�5*      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5+   "     $ TableAdd=�6;   
����  �$��45��6]   $��45��6h   $��Center=�6t   $��Center=�6�   �� 5,   "   $ Vertical=�6-   .+�5-   &   �� $��5q�60   $��Center=�6;   $��Center=�6V   $��14(�6�   $��Sitka Subheading)�6�   ��6s   �� *
tbl_Name+6�   �� 5.   &   $��5q�60   $��Center=�6;   $��Center=�6V   $��14(�6�   $��Sitka Subheading)�6�   ��6s   �� *status+6�   5/   #   50      51      53      55      �� 56      -   5         ��Name$ 	stContent��56      $��Right=�6,   $��Center=�6H   $��	0,50,10,0q�6c   $	��500��6v   $	��380��6�   $ Vertical=�6�   .+�57      �� -   5         ��Name$ lbTable��57      $��Center=�6)   $
��Bold"�6F   $��Sitka Subheading)�6X   $��Center=�6v   $��20(�6�   .��6�   Chọn bàn số:6�   �� 58      $ 
Horizontal=�6   .+�59      �� $��Center=�6   $��Sitka Subheading)�67   .��6U   Chọn danh mục món ăn:6m   �� 5:      -   5         ��Name$ cbxCat��5:      $	��100��5<      $��5q�6+   ��5>      �� 5?      .R�5@   "   �� $ 
Horizontal=�6-   .+�5A   &   �� $��25��6G   $��25��6R   ��6,   �� *	imgPath+6R   �� 5B   &   $��Sitka Subheading)�60   $��5q�6N   $��Center=�6Y   ��6t   �� *Name+5C   #   5D      5F      �� 5H      $��Center=�6   $��Sitka Subheading)�67   .��6U   Chọn món ăn:6c   �� 5I      -	   5        $ cbxProducts��5I      {�.  $	��150��5K      $��5q�6+   ��5N      �� 5O      .R�5P   "   �� $ 
Horizontal=�6-   .+�5Q   &   �� $��25��6G   $��25��6R   ��6,   �� *	imgPath+6R   �� 5R   &   $��Sitka Subheading)�60   $��5q�6N   $��Center=�6Y   ��6t   �� *Name+5S   #   5T      5V      5W      �� 5X      $��Center=�6   $��Center=�6:   $��5q�6U   $ 
Horizontal=�6`   .+�5Y      �� $��Sitka Subheading)�6   $��Center=�6;   .��6V   Số lượng:6a   �� 5Z      -
   5         ��Name$ txtCount��5Z      $��5q�60   $��50��6;   6F   �� 5[      -   5        $ btnAddFruid��5[   T    !  MaterialDesignPaperDarkButton#��[  6   .��5\      �� $ 
Horizontal=�6%   $��Center=�6>   .+�5]        $	 Add=�67   
����  �$��35��6T   $��35��6_   $��Center=�6k   $��Center=�6�   �� 5^      $��Center=�6$   $��Sitka Subheading)�6?   
����  �$��1q�6o   .��6z   Thêm món ăn6�   5_      5`      5a      &   System.Windows.Controls.DataGrid  5b      -   5          Name$ drgBill��5b   @   $��2��6   $��5q�6(   $	��210��63      AutoGenerateColumns .     
IsReadOnly .    Columns 5c      0  *System.Windows.Controls.DataGridTextColumn  5d      ,  &System.Windows.Controls.DataGridColumn   Header$ Tên sản phẩm��5f         MinWidth$ 70Q�5g         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5h      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5e      �� *
FRUID.Name+5h        5j      $ 
Đơn giá��5l      $ 70Q�5m      $ * 5n       5k      �� *FRUID.Price+5n        5q      $ Số lượng��5s      $ 70Q�5t      $ * 5u       5r      �� *count+5u        5x      $ Thành tiền��5z      $ 70Q�5{      $ * 5|       5y      �� *sum+5|      5      �� 5�      $��Bottom=�6   $��Right=�68   $ 
Horizontal=�6T   .+�5�      �� -   5        $ cancelTable��5�   _   #��[  6   $��2q�6T   $y�Hidden=�6�   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ Cancel=�67   
����  �$��35��6W   $��35��6b   $��Center=�6n   $��Center=�6�   �� 5�      $��Center=�6$   $��Sitka Subheading)�6?   
����  �$��1q�6o   .��6z   Huỷ đặt bàn6�   5�      5�      �� 5�      -   5        $ setTable��5�   _   #��[  6   $��2q�6T   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ 	Subtitles=�67   
����  �$��35��6Z   $��35��6e   $��Center=�6q   $��Center=�6�   �� 5�      $��Center=�6$   $��Sitka Subheading)�6?   
����  �$��1q�6o   .��6z   Đặt bàn6�   5�      5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��Bottom=�62   $��	15,0,0,20q�6M   .+�5�        $ 	Copyright=�6+   $��Center=�6<   $	��2 0q�6W   
��� � �$��10��6w   $��10��6�   �� 5�      $��Sitka Subheading)�6   $��Center=�6:   $��1 0 0 0q�6U   $��Design by Le Ngoc Vinh��6f   
��� � �$��10(�6�   5�      5�      5�      5�      