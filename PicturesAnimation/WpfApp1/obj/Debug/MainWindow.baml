   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � Triggers 5	      :� 5
   
    :� 
SourceName$ cmdStart��6    :� RoutedEvent$ Button.Click��6-   .[�5      �� -   5         ��Name$ fadeStoryboardBegin��5      .��5      �� -   5         g�Name$ fadeStoryboard��5       g� 
SpeedRatio 6n   ��  �� ElementName$ sldSpeed�� �� Path$ Value�.��5      W� 	 �� 
TargetName$	 Picture5��5      
 �� TargetProperty$
 Opacity�5       W� From$ 1X�5      	 W� To$ 0X�6"    g� Duration$ 0:0:1D�6)   5      W� 5      $	 Picture4��5      $
 Opacity�5      $ 1X�5      $ 0X�6"   $ 0:0:1D�6)    g� 	BeginTime$ 0:0:1X�6:   5      W� 5      $	 Picture3��5      $
 Opacity�5      $ 1X�5      $ 0X�6"   $ 0:0:1D�6)   $ 0:0:2X�6:   5      W� 5      $	 Picture2��5       $
 Opacity�5!      $ 1X�5"      $ 0X�6"   $ 0:0:1D�6)   $ 0:0:3X�6:   5#      5$      5%      5&      :� 5(   
   $ cmdPause��6   $ Button.Click��6-   .[�5)      ?�  �� BeginStoryboardName$ fadeStoryboardBegin��6   5*      :� 5+   
   $ 	cmdResume��6   $ Button.Click��6.   .[�5,      �� $ fadeStoryboardBegin��6   5-      :� 5.   
   $ cmdStop��6   $ Button.Click��6,   .[�5/      �� $ fadeStoryboardBegin��6   50      :� 51   
   $ 	cmdMiddle��6   $ Button.Click��6.   .[�52      �� $ fadeStoryboardBegin��6    �� Offset$ 0:0:5h�6G   53       � 	Resources 55       �� 
TargetType �� Property �� Value��%t   '��       �� 56   
   " ��6   .�57      ��  � ��$ 5q�6(   �� 58       � ��$ 1q�6'   59      5:      .��5<      �  � RowDefinitions 5=   
   �� 5>      6   �� 5?      $
��Auto �6   �� 5@      $
��Auto �6   �� 5A      $
��Auto �6   �� 5B      $
��Auto �6   .+�5D   
   � 
���   �.+�5E      �� $��Imagines/1.jpg��6   �� 5F      -   5        $��Picture2��5F   ,   $��Imagines/2.jpg��6   6,   �� 5G      -   5        $��Picture3��5G   ,   $��Imagines/3.jpg��6   6,   �� 5H      -   5        $��Picture4��5H   ,   $��Imagines/4.jpg��6   6,   �� 5I      -   5        $��Picture5��5I   ,   $��Imagines/5.jpg��6   6,   5J      �� 5L   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��5q�6X   .+�5M      �� -   5        $��cmdStart��5M   %   $��Start��6   6%   �� 5N      -   5        $��cmdPause��5N   %   $��Pause��6   6%   �� 5O      -	   5        $��	cmdResume��5O   &   $��Resume��6   6&   �� 5P      -
   5        $��cmdStop��5P   $   $
��Stop��6   6$   �� 5Q      -   5        $��	cmdMiddle��5Q   .   $��Move To Middle��6   6.   5R      �� 5T   
   -   5        $��lblTime��5T   !   $��2��6   $��Center=�60   [[ stopped ]]6\   � 5U   
   $��3��6   $��5q�6    � ColumnDefinitions 5V      �� 5W      $
��Auto �6#   �� 5X      .+�5Z      �� $��Speed:��6   �� 5[      -   5        $��sldSpeed��5[   %   $��1��6    � Minimum$ 0Q�5\       � Maximum$ 3Q�6    � Value$ 1Q�6'    �� TickPlacement$ BottomRight=�61    �� TickFrequency$	 0.1Q�6M   6a   5]      � 5^   
   -   5        $��progressBar��5^   A   $��4��6   $��0,5,0,0q�6#   $��10��64   $ 0Q�6T   $ 1Q�6`   5_      5`      