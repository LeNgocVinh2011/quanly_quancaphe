   M S B A M L   `   `   `  ����G  CCafe_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cafe_managerCafe_manager  5          Cafe_manager.ProductsMng   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:Cafe_manager  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��6* �6   .+�5   
   �� $��20(�6   $
��Bold"�6   $��DANH SÁCH SẢN PHẨM��60   $��0��6M   $��Center=�6Z   $��Center=�6u   $��Sitka Subheading)�6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��	30,0,30,0q�6.   $��1��6A   $��Center=�6N   .+�5      �� -   5         ��Name$ 	txtSearch��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm��6)    %  !MaterialDesignFloatingHintTextBox#��[  6T   $	��200��6�   $
��Left=�6�   �� 5      $��Danh mục: ��6   $��Sitka Subheading)�6)   $��Center=�6G   �� 5      -   5         ��Name$ cbxCategories��5      $��5,8,5,0q�5      $	��100��5      $��13(�5      $��Sitka Subheading)�5      
������ $��
0,0,0,0.25q�5       �� DisplayMemberPath$
 Name��5       �� SelectedValuePath$ cat_Id��5      �� 5      -   5         ��Name$ 	btnSearch��5   �   
��� � �$��	10,0,10,0q�6@    * &MaterialDesignFloatingActionMiniButton#��[ 6T   .��5       '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6+   $��Center=�69   5!      �� 5"      -   5        $ btnReset��5"   �   
����  �$��	10,0,10,0q�6>   #��[ 6R   .��5#        $ Reload=�6+   $��Center=�69   5$      5%      �� 5&   
   $ 
Horizontal=�6   $��1��6.   $��Right=�6;   $��0,0,30,0q�6W   .+�5'      �� -   5        	 ��Name$	 lbData��5'   `   $��Thêm mới��6   $��Sitka Subheading)�6'   $��Center=�6E   6`   �� 5(      -   5        $ 
addProduct��5(   f   #��[ 6   $��5,0,5,0q�6U   .��5)        $	 Add=�6+   $��Center=�66   5*      �� 5+      -   5        $ btnPrev��5+      
���**��#��[ 6O   $��5,0,5,0q�6�   .��5,        $ KeyboardArrowLeft=�6+   $��Center=�6D   5-      �� 5.      -   5        $	 lbPageNumber��5.      $��	Trang 1/2��6*   $��Sitka Subheading)�6>   $��Center=�6\   �� 5/      -	   5        $ btnNext��5/      
���**��#��[ 6O   $��5,0,5,0q�6�   .��50        $ KeyboardArrowRight=�6+   $��Center=�6E   51      52      &   System.Windows.Controls.DataGrid  53   
   -
   5        
  Name$
 drgProducts��53   2   $��2��6   $��5,20,5,5q�6       AutoGenerateColumns .     
IsReadOnly .    Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ Tên sản phẩm��57         MinWidth$	 200Q�58         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 59      1  +System.Windows.Controls.DataGridBoundColumn   Binding 56      �� *Name+59        5;      $ Giá sản phẩm��5=      $	 200Q�5>      $ * 5?       5<      �� *Price+5?      4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ Hình ảnh sản phẩm��6)   $	 200Q�6D   $ * 6S      CellTemplate 5B      �� 5C      .R�5D      �� $��30��6?   $��30��6J   $
��Left=�6V   ��6$   �� *	imgPath+6V   5E      5G        5H      $ Danh mục sản phẩm��5J      $	 200Q�5K      $ * 5L       5I      �� *FRUID_CATEGORIES.Name+5L        5O      $	 100 6)   -   5        editData�� 5P      �� 5Q      .R�5R      �� $ btnEditProduct��6P   -   5        $��50��5R   &   $��30��61   
��� � �.��5S   "     $
 Edit=�6;   $��Center=�6G   $��Center=�6b   5T      5U      5W        5X      $	 100 6)   -   5        
DeleteData�� 5Y      �� 5Z      .R�5[      �� $ btnDeleteProduct��6M   -   5        $��50��5[   %   $��30��60   
���  ��.��5\   "     $ Delete=�6;   $��Center=�6I   $��Center=�6e   5]      5^      5`      5b      5c      5d      