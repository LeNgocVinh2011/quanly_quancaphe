   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5          Cafe_manager.CustomerMng   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:Cafe_manager  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $
��Bold"�6   $��DANH SÁCH NGƯỜI DÙNG��60   $��0��6O   $��Center=�6\   $��Center=�6w   $��Sitka Subheading)�6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��	30,0,30,0q�6.   $��1��6A   $��Center=�6N   .+�5      �� -   5         ��Name$ 	txtSearch��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm��6)    %  !MaterialDesignFloatingHintTextBox#��[  6T   $	��200��6�   $
��Left=�6�   �� 5      -   5         ��Name$ 	btnSearch��5   |   
��� � �$��	10,0,10,0q�6(    * &MaterialDesignFloatingActionMiniButton#��[ 6<   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6+   $��Center=�69   5      �� 5      -   5        $ btnReset��5   {   
����  �$��	10,0,10,0q�6'   #��[ 6;   .��5        $ Reload=�6+   $��Center=�69   5      5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��Right=�6;   $��0,0,30,0q�6W   .+�5      �� -   5         ��Name$ lbData��5   `   $��Thêm mới��6   $��Sitka Subheading)�6'   $��Center=�6E   6`   �� 5      -   5        $ addStaff��5   f   #��[ 6   $��5,0,5,0q�6U   .��5        $	 Add=�6+   $��Center=�66   5       �� 5!      -   5        $ 
btnPrevCus��5!      
���**��#��[ 6=   $��5,0,5,0q�6}   .��5"        $ KeyboardArrowLeft=�6+   $��Center=�6D   5#      �� 5$      -   5        $ lbPageNumber��5$      $��	Trang 1/2��6*   $��Sitka Subheading)�6>   $��Center=�6\   �� 5%      -   5        $ 	btnNexCus��5%      
���**��#��[ 6;   $��5,0,5,0q�6{   .��5&        $ KeyboardArrowRight=�6+   $��Center=�6E   5'      5(      &   System.Windows.Controls.DataGrid  5)   
   -	   5          Name$ drgStaff��5)   2   $��2��6   $��5,20,5,5q�6       AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ Tài khoản��5-         MinWidth$	 250Q�5.         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5/      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5,      �� *
UserName+5/        51      $ Tên hiển thị��53      $	 150Q�54      $ * 55       52      �� *DisplayName+55        57      $ Mật khẩu��59      $	 200Q�5:      $ * 5;       58      �� *
PassWord+5;        5=      $ Vai trò��5?      $	 100Q�5@      $ * 5A       5>      �� *Type+5A      4  .System.Windows.Controls.DataGridTemplateColumn  5C      $	 100 6)   -
   5        editData��   CellTemplate 5D      �� 5E      .R�5F      �� $ btnEditStaff��6P   -   5        $��50��5F   &   $��30��61   
��� � �.��5G   "     $
 Edit=�6;   $��Center=�6G   $��Center=�6b   5H      5I      5K        5L      $	 100 6)   -   5        
DeleteData�� 5M      �� 5N      .R�5O      �� $ btnDeleteStaff��6M   -   5        $��50��5O   %   $��30��60   
���  ��.��5P   "     $ Delete=�6;   $��Center=�6I   $��Center=�6e   5Q      5R      5T      5V      �� 5W   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�5X      �� $��
GHI CHÚ: ��6   $��Sitka Subheading)�6(   $
��Bold"�6F   $��20(�6X   �� 5Y      $(��"0: Người dùng thông thường��6   $��Sitka Subheading)�69   $��18(�6W   5Z      5[      5\      