   M S B A M L   `   `   `  ����H  DPersonInfoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PersonInfoWPFPersonInfoWPF  5   	       PersonInfoWPF.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PersonInfoWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Person info��5	   	   $	��410��6   $	��600��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � Icon$- '/iconfinder-3-avatar-2754579_120516.png��6q   ���	#FFADCD69.��5
      �  � ColumnDefinitions 5   
   �� 5      $
��150* �6   �� 5      $
��217* �6   �� 5      $
��184* �6   �� 5      $	��49* �6   .+�5   
   ]� $��2��6   .+�5      A� $	��Top=�6    A� Columns$ 2��6/    A� Rows$ 6��6;   $��Stretch=�6D   $	��320��6`   .+�5      �� $��Center=�6   $��Name*��67   $��20(�6D   $��Normal"�6R   $��20,0,0,0q�6f   �� 5      -   5        $
��Name��5   o    %  !MaterialDesignFloatingHintTextBox#��[  5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter your name��5      $��Center=�6F   $��20(�6a   6{   �� 5      $��Center=�6   $��Surname*��67   $��20(�6G   $��Normal"�6U   $��20,0,0,0q�6i   �� 5      -   5        $��Surname��5   r   #��[  5      $ Enter your surname��5      $��Center=�6I   $��20(�6d   6�   �� 5      $��Center=�6   $��Patronimic*��67   $��20(�6J   $��Normal"�6X   $��20,0,0,0q�6l   �� 5      -   5        $��
Patronimic��5   u   #��[  5      $ Enter your patronimic��5      $��Center=�6L   $��20(�6g   6�   �� 5       $��Center=�6   $	��Sex��67   $��20(�6B   $��Normal"�6P   $��20,0,0,0q�6d   �� 5!      .��5"      A� $ 2��6"   $��
0,-10,0,-9q�6.   .+�5#      	� -   5        $
��Male��5$   �    ( $MaterialDesignActionDarkToggleButton#��[ 5#   &   $��Center=�5$   &   $��Center=�6H   $��Center=�6l   $
��Male��6�   $��Center=�6�   $��14(�6�   	� 5%      -   5        $��Famale��5&   �   #��[ 5%   &   $��Center=�5&   &   $��Center=�6H   $��Famale��6c   $��Center=�6t   $��14(�6�   $��61��6�   5'      5(      �� 5*      $��Center=�6   $��Birthday��67   $��20(�6G   $��Normal"�6U   $��20,0,0,0q�6i   (  "System.Windows.Controls.DatePicker  5+      -   5        $��Birthday��5,   �    ( $MaterialDesignFloatingHintDatePicker#��[ 5+      $ Enter your birthday��5,      $��Center=�6J   $��20(�6e   $��Stretch=�6s   6�   �� 5.      $
��Info��6   $��20(�6(   $��Normal"�66   $��20,0,0,0q�6J   �� 5/      -   5        $
��Info��50   �   #��[  5/      $ Enter your info��50      " �� VerticalScrollBarVisibility$
 Auto=�6F   	 �� TextWrapping$
	 Wrap=�6i   
 �� AcceptsReturn$

 True��6}   $��20(�6�   $��Stretch=�6�   6�   51      A� 53      $ 1��6   .+�54      �� -   5        $
��Save��54   m   $��0q�6   ${�False��6-   $
��Save��6?   $��20(�6N   $��5,5,5,5q�6\   6y   �� 55      -	   5        $
��Edit��55   m   $��0q�6   ${�False��6-   $
��Edit��6?   $��20(�6N   $��5,5,5,5q�6\   6y   �� 56      -
   5        $��Remove��56   o   $��0q�6   ${�False��6-   $��Remove��6?   $��20(�6P   $��5,5,5,5q�6^   6}   57      58      �� 5:   
   -   5        $��Persons��5:   r    ) %MaterialDesignChoiceChipAccentListBox#��[ 6   $��2��6Q   $��5,5,0,5q�6a   $��14(�6�   �� 5<   
   $��3��6   .+�5=      �� -   5        $��SavePersons��5=   >   $��/Save_37110.png��6   $��5,5,5,5q�6-   ${�False��6s    J� Effect 5>      -  'System.Windows.Media.Effects.BlurEffect  5?      5A      5B      5C      5D      