   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseReport   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - View Expense��5   	   $	��450��6*   $	��800��67   .��5	      � $��
10,0,10,10q�6   ��5
   
   �� 5       �� ImageSource$2 ,H:\proj\PS_30_Ivelin\ExpenseIt\watermark.png��6    � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��1��6   $��3��6#      AutoGenerateColumns$ False��6U      RowHeaderWidth$ 0Q�6q   ��60   ��  �� Path$ Expense�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 6:   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6F   �� $ ExpenseType�  5      $ Amount��6%   
 65   �� $ ExpenseAmount�5       �� 5"   
   $��1��6   $��28(�6    .��6.   View Expense Report For6G   �� 5#   
   $��1��6   $��1��6    $��15(�6-   .��6;   Name:6B   �� 5$   
   $��1��6   $��1��6    $��15(�6-   $��Right=�6;   ��6W   �� $
 Name�6w   �� 5%   
   $��1��6   $��2��6    $��15(�6-   .��6;   Department:6H   �� 5&   
   $��1��6   $��2��6    $��15(�6-   $��Right=�6;   ��6W   �� $ 
Department�6}   5*      5+      