   M S B A M L   `   `   `  ����C  ?StartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StartApp.ValidationRulesStartApp.ValidationRules  5   	   #clr-namespace:StartAppStartApp  5   	       StartApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   BvalidationRules&clr-namespace:StartApp.ValidationRules     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:StartApp  5   	   -   5          �Name$  
mainWindow��5
   J    � Title$ 
MainWindow��6	   $	��550��6   $	��800��6)   ���#F2F2F2 � 
ResizeMode$ NoResize=�6^    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Grey.xaml?�6%   �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml?�6%   �� 5      $0 */ResourceDictionaries/ValidationRules.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��90* �6   �� 5      $
��307* �6   .+�5   
   ]� $��2��6   .+�5      � $��10,60q�6   $
��Left=�6"   $	��150��68    � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5       $
��auto �6$   �� 5!      $
��auto �6$   �� 5"      $
��auto �6$   �� 5#      $
��auto �6$   �� 5$      $
��auto �6$   �� 5%      $
��auto �6$   .+�5(      �� $��0��6    �� Orientation$ 
Horizontal=�6+   $��Center=�6D   .+�5)      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 Home=�6.      PackIconStyle#��[  6;   $��5q�6b   �� 5*      -   5        
 ��Name$
 txtName��5*   *   $��5q�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Home��6;   $	��100��6a   $��0��6m     TextBoxStyle#��[ 6z   $
��Home��6�   .��6�   5+      5,      �� 5-      $��1��6   $ 
Horizontal=�6+   $��Center=�6D   .+�5.        $	 AddBox=�6.   #��[  6=   $��5q�6d   �� 5/      -   5        $
 txttwo��5/   *   $��5q�6   $ New Club��6:   $	��100��6d   $��0��6p   #��[ 6}   $��New Club��6�   .��6�   50      51      �� 52      $��2��6   $ 
Horizontal=�6+   $��Center=�6D   .+�53        $	 SelectGroup=�6.   #��[  6B   $��5q�6i   �� 54      -   5        $
 txtfivee��54   *   $��5q�6   $ Select Club��6<   $	��100��6i   $��0��6u   #��[ 6�   $��Select Club��6�   .��6�   55      56      �� 57      $��3��6   $ 
Horizontal=�6+   $��Center=�6D   .+�58        $	 Notifications=�6.   #��[  6D   $��5q�6k   �� 59      -   5        $
 txtthree��59   *   $��5q�6   $ Notifications��6<   $	��250��6k   $��0��6w   #��[ 6�   $��Notifications��6�   .��6�   5:      5;      �� 5<      $��4��6   $ 
Horizontal=�6+   $��Center=�6D   .+�5=        $	 MailOutline=�6.   #��[  6B   $��5q�6i   �� 5>      -   5        $
 txtfor��5>   *   $��5q�6   $ Messages��6:   $	��100��6d   $��0��6p   #��[ 6}   $��Messages��6�   .��6�   5?      5@      �� 5B      $��5��6   $ 
Horizontal=�6+   $��Center=�6D   .+�5C        $	 FormatListBulleted=�6.   #��[  6I   $��5q�6p   �� 5D      -   5        $
 txtNsixe��5D   *   $��5q�6   $ Lists��6<   $	��100��6c   $��0��6o   #��[ 6|   $��Lists��6�   .��6�   5E      5F      �� 5G      $��6��6   $ 
Horizontal=�6+   $��Center=�6D   .+�5H        $
	 User=�6.   #��[  6;   $��5q�6b   �� 5I      -   5        $
 txtme��5I   *   $��5q�6   $ Profile��69   $	��100��6b   $��0��6n   #��[ 6{   $��Profile��6�   .��6�   5J      5K      5L      �� 5M      ���#5C5A5A$��3q�6+   ._�5N      � $
��Left=�6   $
��Auto��6-    5O      �� 5P      $
��Auto �6(   �� 5Q      $
��Auto �6(   �� 5R      $
��Auto �6(   .+�5T      �� -	   5        $

 Tile��5T   }   $��	0,20,0,10q�6   $��0��61   $��Profile��6>   $
��Bold"�6M   $��Center=�6`   $��2q�6�   $	��200��6�   $	��500��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   ���	#FF5B5B5B$��25(�6�   $��Segoe UI)�6	  ���#5C5A5A �� 
CaretBrush �	#FF6C6C6C �� TextAlignment$ Center=�6M  � 5U      $��1��6    5V      �� 5W      $
��Auto �6/   �� 5X      $
��Auto �6/   .+�5Z      �� -
   5        $	
 img��5Z   d   $��60,10,10,10q�6"   $��0��67   $��Center=�6G   $��2q�6q   $��50��6�   $	��237��6�   $
 Wrap=�6�   $	��Top=�6�   $��Rated Clubs��6�   ���	#FF5B5B5B$��20(�6�   $��Segoe UI)�6  ���#5C5A5A �	#FF6C6C6C6-  �� 5[      -   5        $

 dfsd��5[   ^   $��10,10q�6"   $��1��61   $��Center=�6A   $��2q�6l   $��50��6�   $
 Wrap=�6�   $	��240��6�   $	��Top=�6�   $��Comments��6�   ���	#FF5B5B5B$��20(�6�   $��Segoe UI)�6�   ���#5C5A5A �	#FF6C6C6C6%  5\      �� 5]      -   5        $
 picture��5]   T   $��10q�6   $��2��6*   $��Center=�67   $��2q�6e   $	��180��6y   $	��500��6�   $
 Wrap=�6�   $	��Top=�6�   $��Rated Clubs��6�   ���	#FF5B5B5B$��25(�6�   $��Segoe UI)�6�   ���#5C5A5A �	#FF6C6C6C6"  5a      5b      5f      5h      5|      