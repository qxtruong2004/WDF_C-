   M S B A M L   `   `   `  ����?  ;Bai3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Bai3Bai3  5   	       Bai3.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Bai3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��lblName��5
      $��Họ và tên��6   $
��Left=�63   $��26��6N   $��	10,23,0,0q�6Z   $	��Top=�6m   $��69��6�   �� 5   
   -   5        $��txtName��5      $
��Left=�6!   $��26��6<   $��	84,23,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6p   $	��136��6�   �� 5   
   -   5        $��lblAge��5      $��Tuổi��6   $
��Left=�6-   $��26��6H   $��	10,65,0,0q�6T   $	��Top=�6g   $��69��6   �� 5   
   -   5        $��txtAge��5      $
��Left=�6    $��26��6;   $��	84,65,0,0q�6G   $
 Wrap=�6Z   $	��Top=�6o   $	��136��6�   �� 5   
   -   5        $��grbGioiTinh��5      $
��Left=�6&   $	��108��6A   $��Giới tính��6N   $��
10,109,0,0q�6a   $	��Top=�6u   $	��210��6�   .��5      �� $��64��6   .+�5      	� -   5        $��radGioiTinhNam��5      $	��Nam��65   $��20��6C    �� Left$ 10��6O   
 �� Top$ 10��6`   $	��102��6p   	� 5      -   5        $��radGioiTinhNu��5      $
��Nữ��63   $��20��6@   $ 10��6L   $ 43��6]   $	��102��6m   5      5      �� 5   
   -   5        $��btnAdd��5      $��Thêm��6   $
��Left=�6.   $��32��6I   $��
10,232,0,0q�6U   $	��Top=�6i   $��89��6�   6�   �� 5   
   -	   5        $��btnIn��5      $��In��6   $
��Left=�6+   $��32��6F   $��131,232,0,0q�6R   $	��Top=�6g   $��89��6   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5        $��dtgInfo��5      $
��Left=�6"   $��79��6=   $��
268,23,0,0q�6I   $	��Top=�6]   $	��472��6u      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Họ và tên��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Name+6S     5      $ Tuổi��6%    63   �� *Age+6M     5      $ Giới Tính��6%    68   �� *
GioiTinh+6W   5      5      5       