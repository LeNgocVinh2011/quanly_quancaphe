   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5          Cafe_manager.StaffMng   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:Cafe_manager  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $
��Bold"�6   $��DANH SÁCH NHÂN VIÊN��60   $��0��6N   $��Center=�6[   $��Center=�6v   $��Sitka Subheading)�6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��	30,0,30,0q�6.   $��1��6A   $��Center=�6N   .+�5      �� -   5         ��Name$ 	txtSearch��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm��6)    %  !MaterialDesignFloatingHintTextBox#��[  6T   $	��200��6�   $
��Left=�6�   �� 5      $��
Vai trò: ��6   $��Sitka Subheading)�6(   $��Center=�6F   �� 5      -   5         ��Name$ cbxRoleAdmin��5      $��5,8,5,0q�5      $	��100��5      $��13(�5      $��Sitka Subheading)�5      
������ $��
0,0,0,0.25q�5      �� 5      -   5         ��Name$ 	btnSearch��5   |   
��� � �$��	10,0,10,0q�6(    * &MaterialDesignFloatingActionMiniButton#��[ 6<   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6+   $��Center=�69   5      �� 5       -   5        $ btnReset��5    {   
����  �$��	10,0,10,0q�6'   #��[ 6;   .��5!        $ Reload=�6+   $��Center=�69   5"      5#      �� 5$   
   $ 
Horizontal=�6   $��1��6.   $��Right=�6;   $��0,0,30,0q�6W   .+�5%      �� -   5         ��Name$ lbData��5%   `   $��Thêm mới��6   $��Sitka Subheading)�6'   $��Center=�6E   6`   �� 5&      -   5        $ addStaff��5&   f   #��[ 6   $��5,0,5,0q�6U   .��5'        $	 Add=�6+   $��Center=�66   5(      �� 5)      -   5        $ btnPrev��5)      
���**��#��[ 6:   $��5,0,5,0q�6z   .��5*        $ KeyboardArrowLeft=�6+   $��Center=�6D   5+      �� 5,      -   5        $ lbPageNumber��5,      $��	Trang 1/2��6*   $��Sitka Subheading)�6>   $��Center=�6\   �� 5-      -	   5        $ btnNext��5-      
���**��#��[ 69   $��5,0,5,0q�6y   .��5.        $ KeyboardArrowRight=�6+   $��Center=�6E   5/      50      &   System.Windows.Controls.DataGrid  51   
   -
   5          Name$ drgStaff��51   2   $��2��6   $��5,20,5,5q�6    	   AutoGenerateColumns	 .  
   
IsReadOnly
 .    Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Tài khoản��55         MinWidth$	 250Q�56         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 57      1  +System.Windows.Controls.DataGridBoundColumn   Binding 54      �� *
UserName+57        59      $ Tên hiển thị��5;      $	 150Q�5<      $ * 5=       5:      �� *DisplayName+5=        5?      $ Mật khẩu��5A      $	 200Q�5B      $ * 5C       5@      �� *
PassWord+5C        5E      $ Vai trò��5G      $	 100Q�5H      $ * 5I       5F      �� *Type+5I      4  .System.Windows.Controls.DataGridTemplateColumn  5K      $	 100 6)   -   5        editData��   CellTemplate 5L      �� 5M      .R�5N      �� $ btnEditStaff��6P   -   5        $��50��5N   &   $��30��61   
��� � �.��5O   "     $
 Edit=�6;   $��Center=�6G   $��Center=�6b   5P      5Q      5S        5T      $	 100 6)   -   5        
DeleteData�� 5U      �� 5V      .R�5W      �� $ btnDeleteStaff��6M   -   5        $��50��5W   %   $��30��60   
���  ��.��5X   "     $ Delete=�6;   $��Center=�6I   $��Center=�6e   5Y      5Z      5\      5^      �� 5_   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�5`      �� $��
GHI CHÚ: ��6   $��Sitka Subheading)�6(   $
��Bold"�6F   $��20(�6X   �� 5a      $��1: Quản trị viên��6   $��Sitka Subheading)�6/   $��18(�6M   �� 5b      $��2: Nhân viên��6   $��Sitka Subheading)�6+   $��18(�6I   5c      5d      5e      