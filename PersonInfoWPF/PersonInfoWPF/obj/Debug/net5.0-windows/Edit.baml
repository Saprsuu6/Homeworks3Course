   M S B A M L   `   `   `  ����H  DPersonInfoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PersonInfoWPFPersonInfoWPF  5   	       PersonInfoWPF.EditPerson   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PersonInfoWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$
  Edit��5	   	   $	��480��6   $	��450��6#    � 
ResizeMode$ NoResize=�6/    � WindowStartupLocation$ CenterScreen=�6E    � Icon$- '/iconfinder-3-avatar-2754579_120516.png��6j   ���	#FFE6D06E.��5
      A�  A� Columns$ 2��6    A� Rows$ 6��6   $	��Top=�6'   $	��378��6?   .+�5   
   �� $��Center=�6   $��Name*��6/   $��20(�6<   $��Normal"�6J   $��20,0,0,0q�6^   �� 5   
   -   5        $
��Name��5   o    %  !MaterialDesignFloatingHintTextBox#��[  5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter correct name��5      $��Center=�6F   $��20(�6a   $��0,0,5,0q�6{   6�   �� 5   
   $��Center=�6   $��Surname*��6/   $��20(�6?   $��Normal"�6M   $��20,0,0,0q�6a   �� 5   
   -   5        $��Surname��5   r   #��[  5      $ Enter correct surname��5      $��Center=�6I   $��20(�6d   $��0,0,5,0q�6�   6�   �� 5   
   $��Center=�6   $��Patronimic*��6/   $��20(�6B   $��Normal"�6P   $��20,0,0,0q�6d   �� 5   
   -   5        $��
Patronimic��5   u   #��[  5      $ Enter correct patronimic��5      $��Center=�6L   $��20(�6g   $��0,0,5,0q�6�   6�   �� 5   
   $��Center=�6   $	��Sex��6/   $��20(�6:   $��Normal"�6H   $��20,0,0,0q�6\   �� 5   
   $��0,0,5,0q�6   .��5      A� $ 2��6   $��
0,-10,0,-9q�6&   .+�5      	� -   5        $
��Male��5   �    ( $MaterialDesignActionDarkToggleButton#��[ 5      $��Center=�5   &   $��Center=�6H   $��Center=�6l   $
��Male��6�   $��Center=�6�   $��14(�6�   	� 5      -   5        $��Famale��5   �   #��[ 5      $��Center=�5   &   $��Center=�6H   $��Famale��6c   $��Center=�6t   $��14(�6�   $��61��6�   5      5      �� 5!   
   $��Center=�6   $��Birthday��6/   $��20(�6?   $��Normal"�6M   $��20,0,0,0q�6a   (  "System.Windows.Controls.DatePicker  5"   
   -   5        $��Birthday��5#   �    ( $MaterialDesignFloatingHintDatePicker#��[ 5"      $ Enter correct birthday��5#      $��Center=�6M   $��20(�6h   $��Stretch=�6v   $��0,0,5,0q�6�   �� 5%   
   $
��Info��6   $��20(�6    $��Normal"�6.   $��20,0,0,0q�6B   �� 5&   
   -   5        $
��Info��5'   �   #��[  5&      $ Enter correct info��5'      " �� VerticalScrollBarVisibility$
 Auto=�6F    �� TextWrapping$
 Wrap=�6i   	 �� AcceptsReturn$
	 True��6}   $��20(�6�   $��Stretch=�6�   $��0,0,5,0q�6�   �� 5)   
   -   5        $
��Save��5)   h   $��0q�6   ${�False��6%   $
��Save��67   $��20(�6F   $��
5,5,-220,5q�6T   6t   5*      5+      