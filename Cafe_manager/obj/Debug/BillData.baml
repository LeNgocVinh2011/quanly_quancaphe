   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5   	       Cafe_manager.BillData   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:Cafe_manager  5   	     � Title$  BillData��5	   	    � WindowStyle$
 None=�5
   	   $	��550��5   	   $	��700��6    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � 
�������.+�5   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6-   $��Right=�6F   .+�5      �� -   5         ��Name$ btnMiniSize��5       � Cursor$
 Hand��5      $��0q�5      ��5   *   Z� ��6@   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6+   $��Center=�6A   
���   �6\   5      �� 5      -   5        $ btnMax��5      {�.  ��6%   Z� ��6;   Z� .��5        $ WindowMaximize=�6+   $��Center=�6A   
���   �6\   5      �� 5      -   5        $ btnClose��5      ��6'   Z� ��6=   Z� .��5        $ Close=�6+   $��Center=�68   
���   �6S   5      5      � 5   
   $	��520��6   $��20q�6   .+�5       �� $	��500��6   $��10q�6%   
������� �� RadiusX$ 10��6>   	 �� RadiusY$	 10��6K   
 J� Effect
 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         
BlurRadius$ 20Q�6'      ShadowDepth$ 1Q�67   5$      �� 5%      $*��$/assets/Capture-removebg-preview.png��6   $	��Top=�6B   $��Center=�6Z   $	��100��6w   $��60��6�   $��0,15,0,0q�6�   �� 5&      -   5         ��Name$ grbData��5&      $��Sitka Subheading)�6(   $��
10,0,10,40q�6F   $!��DANH SÁCH BILL THANH TOÁN��6Z   $	��420��6}   $��Bottom=�6�   .��5'      &   System.Windows.Controls.DataGrid  -   5          Name$ drgBill��5'   3   $��5q�6   $	��300��6&      AutoGenerateColumns .     
IsReadOnly . $	��Top=�6r      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Tên sản phẩm��5+         MinWidth$ 70Q�5,         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5-      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5*      �� *
FRUID.Name+5-        5/      $ 	Ngày mua��51      $ 70Q�52      $ * 53       50      �� *BILL.DateCheckIn+53        56      $ Số lượng��58      $ 70Q�59      $ * 5:       57      �� *count+5:        5=      $ Thành tiền��5?      $ 70Q�5@      $ * 5A       5>      �� *sum+5A        5C      $ Bàn ăn��5E      $ 70Q�5F      $ * 5G       5D      �� *BILL.TBL_STATUS.tbl_Name+5G      5J      5K      �� 5L      $y�Hidden=�6    �� CornerRadius$ 10��6)   $��2q�6;   $	��600��6O   
����  �
�������._�5M      �� -   5         ��Name$ billData��5M      $ Vertical=�6/   $��5q�6F   .+�5N      �� -   5         ��Name$ 
lbTimeBill��5N   :   $��Sitka Subheading)�6   $
��Left=�6N   $��5q�6i   .��6t   Ngày xuất:6�   �� 5O      $*��$/assets/Capture-removebg-preview.png��6   $	��200��6J   $��5q�6V   �� 5P      $��Sitka Subheading)�6   $��18(�6:   $��Center=�6H   .��6e   HOÁ ĐƠN COFFEE_HOA_VINH6~   �� 5Q      -   5        $ 
lbCustumer��5Q      $��Sitka Subheading)�60   $��16(�6N   $��Center=�6\   .��6y   KHÁCH HÀNG:6�     5R      -	   5        $ drgBillPrint��5R   7   $��5q�6   $	��350��6*    .   . $	��Top=�6{    5S        5T      $ Tên sản phẩm��5V      $ 70Q�5W      $ * 5X       5U      �� *
FRUID.Name+5X        5Z      $ 	Ngày mua��5\      $ 70Q�5]      $ * 5^       5[      �� *BILL.DateCheckIn+5^        5a      $ Số lượng��5c      $ 70Q�5d      $ * 5e       5b      �� *count+5e        5h      $ Thành tiền��5j      $ 70Q�5k      $ * 5l       5i      �� *sum+5l        5n      $ Bàn ăn��5p      $ 70Q�5q      $ * 5r       5o      �� *BILL.TBL_STATUS.tbl_Name+5r      5u      �� 5v      -
   5        $ 	lbBillSum��5v   :   $��Sitka Subheading)�6   $��Right=�6M   $��10q�6i   $
��Bold"�6u   .��6�   Tổng tiền:6�   5w      5x      �� 5y      -   5        $ grbEmty��5y      $��Sitka Subheading)�6(   $��
10,0,10,40q�6F   $!��DANH SÁCH BILL THANH TOÁN��6Z   $	��420��6}   $��Bottom=�6�   .��5z      �� -   5        $ txtEmpty��5z      $��Center=�6*   $��Center=�6E   $��Sitka Subheading)�6b   $��24(�6�   
���  ��$
��Bold"�6�   .��6�   !Bạn chưa có hoá đơn nào6�   5{      �� 5|      $��Bottom=�6   $��50��64   $��Center=�6@   $��
15,0,15,50q�6]   $ 
Horizontal=�6q   .+�5}      �� -   5        $ txtCount��5}      $��Center=�6*   $
��Bold"�6E   $��Sitka Subheading)�6W   .��6u   Tổng tiền thanh toán: 06�   �� 5~      -   5        $ btnPrintBill��5~      $��5q�6/    !  MaterialDesignPaperDarkButton#��[  6Q   .��5      �� $ 
Horizontal=�6!   .+�5�        $ Printer=�63   
����  �$��35��6T   $��35��6_   $��Center=�6k   $��Center=�6�   �� 5�      $��Center=�6    $��Sitka Subheading)�6;   
����  �$��1q�6k   .��6v   Xuất hoá đơn6�   5�      5�      �� 5�      -   5        $ btnCheckBill��5�      $��5q�6D   #��[  6O   {�.  .��5�      �� $ 
Horizontal=�6!   .+�5�        $ CheckAll=�63   
����  �$��35��6U   $��35��6`   $��Center=�6l   $��Center=�6�   �� 5�      $��Center=�6    $��Sitka Subheading)�6;   
����  �$��1q�6k   .��6v   Thanh toán6�   5�      5�      5�      �� 5�      $��Bottom=�6   $��50��64   $��Center=�6@   $��
15,0,15,70q�6]   .+�5�      �� $��Sitka Subheading)�6   $
��Bold"�66   .��6H   CAGhi chú: Bạn phải xuất hoá đơn trước khi thanh toán6}   5�      �� 5�      $ 
Horizontal=�6   $��Bottom=�62   $��	15,0,0,20q�6M   .+�5�        $ 	Copyright=�6+   $��Center=�6<   $	��2 0q�6W   
��� � �$��10��6w   $��10��6�   �� 5�      $��Sitka Subheading)�6   $��Center=�6:   $��1 0 0 0q�6U   $��Design by Le Ngoc Vinh��6f   
��� � �$��10(�6�   5�      5�      5�      5�      