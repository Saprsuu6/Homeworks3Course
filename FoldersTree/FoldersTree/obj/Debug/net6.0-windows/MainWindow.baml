   M S B A M L   `   `   `  ����F  BFoldersTree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FoldersTreeFoldersTree  5   	       FoldersTree.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FoldersTree     5   	     � Title$  FoldersTree��5   	   $	��300��6   $	��600��6*    � WindowStartupLocation$ CenterScreen=�66    � Icon$! /documents_folder_18875.png��6[   .��5	      A�  A� Columns$ 2��6   .+�5
   
   � $��5,5,5,5q�6    � ColumnDefinitions 5      �� 5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      .+�5      �� -   5        $
��Path��5   l    �� TextWrapping$
 Wrap=�6   $��0��6*   $��0��67   $��3��6G   $��5,5,5,5q�6[   $ �� HorizontalScrollBarVisibility$ Disabled=�5      " �� VerticalScrollBarVisibility$
 Auto=�6?   6b   �� 5      -   5        $	��Add��5   �   $	��Add��6N   $��1��6\   $��0��6i   $��5,5,5,5q�6y   {�6   �� 	 �� ElementName$
	 Path��
 �� Path$
 Text.Length�6�   �� 5      -   5        $��Clear��5   �   $��Clear��6N   $��1��6^   $��1��6k   $��5,5,5,5q�6{   {�6   �� $
	 Tree��$
 Items.Count�6�   �� 5      -   5        $��Remove��5   f   ${�False��6   $��Remove��6'   $��1��68   $��2��6E   $��5,5,5,5q�6U   6t   5      �� 5   
   $��	Live view��6   $��5,5,5,5q�6&   .��5      R� -   5        $
��Tree��5   +   $��0q�6   67   5      5       5!      